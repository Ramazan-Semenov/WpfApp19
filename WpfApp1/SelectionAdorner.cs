using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Documents;
using System.Windows.Media;

namespace WpfApp1
{
    public sealed class SelectionAdorner : Adorner
    {
        private static readonly Dictionary<Selector, SelectionAdorner> _dictionary = new Dictionary<Selector, SelectionAdorner>();
        private static readonly Pen _pen = CreatePen();
        public static readonly DependencyProperty UseAdornerProperty = DependencyProperty.RegisterAttached("UseAdorner", typeof(bool), typeof(SelectionAdorner),
            new PropertyMetadata(OnUseAdornerChanged));
        static void AttachToScrollViewer(Selector selector)
        {
            ScrollViewer viewer = GetScrollViewer(selector);
            if (viewer != null)
            {
                viewer.Tag = selector;
                viewer.ScrollChanged += Viewer_ScrollChanged;
            }
        }
        private static Pen CreatePen()
        {
            Pen pen = new Pen(Brushes.Black, 2.0);
            pen.Freeze();
            return pen;
        }
        private static void DetachAdorner(Selector selector)
        {
            SelectionAdorner adorner;
            if (_dictionary.TryGetValue(selector, out adorner))
            {
                adorner._adornerLayer.Remove(adorner);
                _dictionary.Remove(selector);
            }
        }
        private static SelectionAdorner GetAdorner(Selector selector)
        {
            SelectionAdorner adorner;
            if (!_dictionary.TryGetValue(selector, out adorner))
            {
                _dictionary.Add(selector, adorner = new SelectionAdorner(selector));
            }
            return adorner;
        }
        private static Rect GetBounds(Selector selector, UIElement containerElement)
        {
            Rect bounds = VisualTreeHelper.GetDescendantBounds(containerElement);
            return new Rect(containerElement.TranslatePoint(bounds.TopLeft, selector), bounds.Size);
        }
        private static ScrollViewer GetScrollViewer(DependencyObject d)
        {
            List<DependencyObject> list = new List<DependencyObject>();
            foreach (DependencyObject child in Enumerable.Range(0, VisualTreeHelper.GetChildrenCount(d)).Select(index => VisualTreeHelper.GetChild(d, index)))
            {
                ScrollViewer viewer = child as ScrollViewer;
                if (viewer != null)
                {
                    return viewer;
                }
                list.Add(child);
            }
            return list.Select(GetScrollViewer).FirstOrDefault(viewer => viewer != null);
        }
        private static void OnUseAdornerChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            Selector selector = d as Selector;
            if (selector != null)
            {
                if (((bool)e.NewValue))
                {
                    selector.SelectionChanged += Selector_SelectionChanged;
                    if (!selector.IsLoaded)
                    {
                        selector.Loaded += Selector_Loaded;
                    }
                    else
                    {
                        AttachToScrollViewer(selector);
                    }
                    ProcessSelection(selector);
                }
                else
                {
                    selector.SelectionChanged -= Selector_SelectionChanged;
                    if (!selector.IsLoaded)
                    {
                        selector.Loaded -= Selector_Loaded;
                    }
                    else
                    {
                        ScrollViewer viewer = GetScrollViewer(selector);
                        if (viewer != null)
                        {
                            viewer.ScrollChanged -= Viewer_ScrollChanged;
                        }
                    }
                    DetachAdorner(selector);
                }
            }
        }
        private static void ProcessSelection(Selector selector)
        {
            ListBox listBox = selector as ListBox;
            if (listBox != null && listBox.SelectionMode != SelectionMode.Single)
            {
                if (listBox.SelectedItems.Count != 0)
                {
                    object[] selectedItems = new object[listBox.SelectedItems.Count];
                    listBox.SelectedItems.CopyTo(selectedItems, 0);
                    ProcessSelection(selector, selectedItems);
                    return;
                }
            }
            else if (selector.SelectedItem != null)
            {
                ProcessSelection(selector, new[] { selector.SelectedItem });
                return;
            }
            DetachAdorner(selector);
        }
        private static void ProcessSelection(Selector selector, IEnumerable<object> selectedItems)
        {
            List<DependencyObject> containers = new List<DependencyObject>();
            List<int> indices = new List<int>();
            foreach (DependencyObject container in selectedItems
                .Select(selectedItem => selector.ItemContainerGenerator.ContainerFromItem(selectedItem))
                .Where(container => container != null))
            {
                int containerIndex = selector.ItemContainerGenerator.IndexFromContainer(container);
                int index = indices.BinarySearch(containerIndex);
                containers.Insert(~index, container);
                indices.Insert(~index, containerIndex);
            }
            for (int i = 1; i < indices.Count; i++)
            {
                if (indices[i] != (indices[i - 1] + 1))
                {
                    // Not contiguous
                    DetachAdorner(selector);
                    return;
                }
            }
            Rect bounds = GetBounds(selector, (UIElement)containers[0]);
            for (int i = 1; i < containers.Count; i++)
            {
                bounds.Union(GetBounds(selector, (UIElement)containers[i]));
            }
            GetAdorner(selector).Update(bounds);
        }
        static void Selector_Loaded(object sender, RoutedEventArgs e)
        {
            var selector = (Selector)sender;
            AttachToScrollViewer(selector);
            selector.Loaded -= Selector_Loaded;
        }
        private static void Selector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ProcessSelection((Selector)sender);
        }
        static void Viewer_ScrollChanged(object sender, ScrollChangedEventArgs e)
        {
            ProcessSelection((Selector)((FrameworkElement)sender).Tag);
        }
        public static bool GetUseAdorner(Selector control)
        {
            return (bool)control.GetValue(UseAdornerProperty);
        }
        public static void SetUseAdorner(Selector control, bool useAdorner)
        {
            control.SetValue(UseAdornerProperty, useAdorner);
        }
        private readonly AdornerLayer _adornerLayer;
        private Rect _bounds;
        private void Update(Rect bounds)
        {
            this._bounds = bounds;
            this.InvalidateVisual();
        }
        protected override void OnRender(DrawingContext drawingContext)
        {
            drawingContext.DrawRectangle(null, _pen, this._bounds);
        }
        private SelectionAdorner(Selector selector)
            : base(selector)
        {
            if ((_adornerLayer = AdornerLayer.GetAdornerLayer(selector)) != null)
            {
                _adornerLayer.Add(this);
            }
        }
    }
}
