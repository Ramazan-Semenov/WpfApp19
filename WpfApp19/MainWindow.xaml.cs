using System.Collections.Generic;
using System.Diagnostics;
using System.Windows;
using System.Windows.Media;

namespace WpfApp19
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<a> data { get; set; } = new List<a>();
        public MainWindow()
        {
            InitializeComponent();

            Debug.WriteLine(RenderCapability.Tier >> 0);
            for (int i = 0; i < 200; i++)
            {

                data.Add(
                    new a
                    {
                        w0 = i.ToString(),
                        w1 = i.ToString(),
                        w2 = i.ToString(),
                        w3 = i.ToString(),
                        w4 = i.ToString(),
                        w5 = i.ToString(),
                        w6 = i.ToString(),
                        w7 = i.ToString(),
                        w8 = i.ToString(),
                        w9 = i.ToString(),
                        w10 = i.ToString(),
                        w11 = i.ToString(),
                        w12 = i.ToString(),
                        w13 = i.ToString(),
                        w14 = i.ToString(),
                        w15 = i.ToString(),
                        w16 = i.ToString(),
                        w17 = i.ToString(),
                        w18 = i.ToString(),
                        w19 = i.ToString(),
                        w20 = i.ToString(),
                        w21 = i.ToString(),
                        w22 = i.ToString(),
                        w23 = i.ToString(),
                        w24 = i.ToString(),
                        w25 = i.ToString(),
                        w26 = i.ToString(),
                        w27 = i.ToString(),
                        w28 = i.ToString(),
                        w29 = i.ToString(),
                        w30 = i.ToString(),
                        w31 = i.ToString(),
                        w32 = i.ToString(),
                        w33 = i.ToString(),
                        w34 = i.ToString(),
                        w35 = i.ToString(),
                        w36 = i.ToString(),
                        w37 = i.ToString(),
                        w38 = i.ToString(),
                        w39 = i.ToString(),
                        w40 = i.ToString(),
                        w41 = i.ToString(),
                        w42 = i.ToString(),
                        w43 = i.ToString(),
                        w44 = i.ToString(),
                        w45 = i.ToString(),
                        w46 = i.ToString(),
                        w47 = i.ToString(),
                        w48 = i.ToString(),
                        w49 = i.ToString(),
                        w50 = i.ToString(),
                        w51 = i.ToString(),
                        w52 = i.ToString(),
                        w53 = i.ToString(),
                        w54 = i.ToString(),
                        w55 = i.ToString(),
                        w56 = i.ToString(),
                        w57 = i.ToString(),
                        w58 = i.ToString(),
                        w59 = i.ToString(),
                        w60 = i.ToString(),
                        w61 = i.ToString(),
                        w62 = i.ToString(),
                        w63 = i.ToString(),
                        w64 = i.ToString(),
                        w65 = i.ToString(),
                        w66 = i.ToString(),
                        w67 = i.ToString(),
                        w68 = i.ToString(),
                        w69 = i.ToString(),
                        w70 = i.ToString(),
                        w71 = i.ToString(),
                        w72 = i.ToString(),
                        w73 = i.ToString(),
                        w74 = i.ToString(),
                        w75 = i.ToString(),
                        w76 = i.ToString(),
                        w77 = i.ToString(),
                        w78 = i.ToString(),
                        w79 = i.ToString(),
                        w80 = i.ToString(),
                        w81 = i.ToString(),
                        w82 = i.ToString(),
                        w83 = i.ToString(),
                        w84 = i.ToString(),
                        w85 = i.ToString(),
                        w86 = i.ToString(),
                        w87 = i.ToString(),
                        w88 = i.ToString(),
                        w89 = i.ToString(),
                        w90 = i.ToString(),
                        w91 = i.ToString(),
                        w92 = i.ToString(),
                        w93 = i.ToString(),
                        w94 = i.ToString(),
                        w95 = i.ToString(),
                        w96 = i.ToString(),
                        w97 = i.ToString(),
                        w98 = i.ToString(),
                        w99 = i.ToString(),
                        w100 = i.ToString(),
                        w101 = i.ToString(),
                        w102 = i.ToString(),
                        w103 = i.ToString(),
                        w104 = i.ToString(),
                        w105 = i.ToString(),
                        w106 = i.ToString(),
                        w107 = i.ToString(),
                        w108 = i.ToString(),
                        w109 = i.ToString(),
                        w110 = i.ToString(),
                        w111 = i.ToString(),
                        w112 = i.ToString(),
                        w113 = i.ToString(),
                        w114 = i.ToString(),
                        w115 = i.ToString(),
                        w116 = i.ToString(),
                        w117 = i.ToString(),
                        w118 = i.ToString(),
                        w119 = i.ToString(),
                        w120 = i.ToString(),
                        w121 = i.ToString(),
                        w122 = i.ToString(),
                        w123 = i.ToString(),
                        w124 = i.ToString(),
                        w125 = i.ToString(),
                        w126 = i.ToString(),
                        w127 = i.ToString(),
                        w128 = i.ToString(),
                        w129 = i.ToString(),
                        w130 = i.ToString(),
                        w131 = i.ToString(),
                        w132 = i.ToString(),
                        w133 = i.ToString(),
                        w134 = i.ToString(),
                        w135 = i.ToString(),
                        w136 = i.ToString(),
                        w137 = i.ToString(),
                        w138 = i.ToString(),
                        w139 = i.ToString(),
                        w140 = i.ToString(),
                        w141 = i.ToString(),
                        w142 = i.ToString(),
                        w143 = i.ToString(),
                        w144 = i.ToString(),
                        w145 = i.ToString(),
                        w146 = i.ToString(),
                        w147 = i.ToString(),
                        w148 = i.ToString(),
                        w149 = i.ToString(),
                        w150 = i.ToString(),
                        w151 = i.ToString(),
                        w152 = i.ToString(),
                        w153 = i.ToString(),
                        w154 = i.ToString(),
                        w155 = i.ToString(),
                        w156 = i.ToString(),
                        w157 = i.ToString(),
                        w158 = i.ToString(),
                        w159 = i.ToString(),
                        w160 = i.ToString(),
                        w161 = i.ToString(),
                        w162 = i.ToString(),
                        w163 = i.ToString(),
                        w164 = i.ToString(),
                        w165 = i.ToString(),
                        w166 = i.ToString(),
                        w167 = i.ToString(),
                        w168 = i.ToString(),
                        w169 = i.ToString(),
                        w170 = i.ToString(),
                        w171 = i.ToString(),
                        w172 = i.ToString(),
                        w173 = i.ToString(),
                        w174 = i.ToString(),
                        w175 = i.ToString(),
                        w176 = i.ToString(),
                        w177 = i.ToString(),
                        w178 = i.ToString(),
                        w179 = i.ToString(),
                        w180 = i.ToString(),
                        w181 = i.ToString(),
                        w182 = i.ToString(),
                        w183 = i.ToString(),
                        w184 = i.ToString(),
                        w185 = i.ToString(),
                        w186 = i.ToString(),
                        w187 = i.ToString(),
                        w188 = i.ToString(),
                        w189 = i.ToString(),
                        w190 = i.ToString(),
                        w191 = i.ToString(),
                        w192 = i.ToString(),
                        w193 = i.ToString(),
                        w194 = i.ToString(),
                        w195 = i.ToString(),
                        w196 = i.ToString(),
                        w197 = i.ToString(),
                        w198 = i.ToString(),
                        w199 = i.ToString()
                    }
                    );
                /*Debug.WriteLine(@"private string w0" + i + @";
        public string w" + i + @" { get => w0" + i + @"; set => w0" + i + @" = string.Intern(value ?? """"); }");*/
                //Debug.WriteLine("w" + i + " = i.ToString(),");
            }
            DataContext = this;
        }
    }
    public class a
    {
        private string w00;
        public string w0 { get => w00; set => w00 = string.Intern(value ?? ""); }
        private string w01;
        public string w1 { get => w01; set => w01 = string.Intern(value ?? ""); }
        private string w02;
        public string w2 { get => w02; set => w02 = string.Intern(value ?? ""); }
        private string w03;
        public string w3 { get => w03; set => w03 = string.Intern(value ?? ""); }
        private string w04;
        public string w4 { get => w04; set => w04 = string.Intern(value ?? ""); }
        private string w05;
        public string w5 { get => w05; set => w05 = string.Intern(value ?? ""); }
        private string w06;
        public string w6 { get => w06; set => w06 = string.Intern(value ?? ""); }
        private string w07;
        public string w7 { get => w07; set => w07 = string.Intern(value ?? ""); }
        private string w08;
        public string w8 { get => w08; set => w08 = string.Intern(value ?? ""); }
        private string w09;
        public string w9 { get => w09; set => w09 = string.Intern(value ?? ""); }
        private string w010;
        public string w10 { get => w010; set => w010 = string.Intern(value ?? ""); }
        private string w011;
        public string w11 { get => w011; set => w011 = string.Intern(value ?? ""); }
        private string w012;
        public string w12 { get => w012; set => w012 = string.Intern(value ?? ""); }
        private string w013;
        public string w13 { get => w013; set => w013 = string.Intern(value ?? ""); }
        private string w014;
        public string w14 { get => w014; set => w014 = string.Intern(value ?? ""); }
        private string w015;
        public string w15 { get => w015; set => w015 = string.Intern(value ?? ""); }
        private string w016;
        public string w16 { get => w016; set => w016 = string.Intern(value ?? ""); }
        private string w017;
        public string w17 { get => w017; set => w017 = string.Intern(value ?? ""); }
        private string w018;
        public string w18 { get => w018; set => w018 = string.Intern(value ?? ""); }
        private string w019;
        public string w19 { get => w019; set => w019 = string.Intern(value ?? ""); }
        private string w020;
        public string w20 { get => w020; set => w020 = string.Intern(value ?? ""); }
        private string w021;
        public string w21 { get => w021; set => w021 = string.Intern(value ?? ""); }
        private string w022;
        public string w22 { get => w022; set => w022 = string.Intern(value ?? ""); }
        private string w023;
        public string w23 { get => w023; set => w023 = string.Intern(value ?? ""); }
        private string w024;
        public string w24 { get => w024; set => w024 = string.Intern(value ?? ""); }
        private string w025;
        public string w25 { get => w025; set => w025 = string.Intern(value ?? ""); }
        private string w026;
        public string w26 { get => w026; set => w026 = string.Intern(value ?? ""); }
        private string w027;
        public string w27 { get => w027; set => w027 = string.Intern(value ?? ""); }
        private string w028;
        public string w28 { get => w028; set => w028 = string.Intern(value ?? ""); }
        private string w029;
        public string w29 { get => w029; set => w029 = string.Intern(value ?? ""); }
        private string w030;
        public string w30 { get => w030; set => w030 = string.Intern(value ?? ""); }
        private string w031;
        public string w31 { get => w031; set => w031 = string.Intern(value ?? ""); }
        private string w032;
        public string w32 { get => w032; set => w032 = string.Intern(value ?? ""); }
        private string w033;
        public string w33 { get => w033; set => w033 = string.Intern(value ?? ""); }
        private string w034;
        public string w34 { get => w034; set => w034 = string.Intern(value ?? ""); }
        private string w035;
        public string w35 { get => w035; set => w035 = string.Intern(value ?? ""); }
        private string w036;
        public string w36 { get => w036; set => w036 = string.Intern(value ?? ""); }
        private string w037;
        public string w37 { get => w037; set => w037 = string.Intern(value ?? ""); }
        private string w038;
        public string w38 { get => w038; set => w038 = string.Intern(value ?? ""); }
        private string w039;
        public string w39 { get => w039; set => w039 = string.Intern(value ?? ""); }
        private string w040;
        public string w40 { get => w040; set => w040 = string.Intern(value ?? ""); }
        private string w041;
        public string w41 { get => w041; set => w041 = string.Intern(value ?? ""); }
        private string w042;
        public string w42 { get => w042; set => w042 = string.Intern(value ?? ""); }
        private string w043;
        public string w43 { get => w043; set => w043 = string.Intern(value ?? ""); }
        private string w044;
        public string w44 { get => w044; set => w044 = string.Intern(value ?? ""); }
        private string w045;
        public string w45 { get => w045; set => w045 = string.Intern(value ?? ""); }
        private string w046;
        public string w46 { get => w046; set => w046 = string.Intern(value ?? ""); }
        private string w047;
        public string w47 { get => w047; set => w047 = string.Intern(value ?? ""); }
        private string w048;
        public string w48 { get => w048; set => w048 = string.Intern(value ?? ""); }
        private string w049;
        public string w49 { get => w049; set => w049 = string.Intern(value ?? ""); }
        private string w050;
        public string w50 { get => w050; set => w050 = string.Intern(value ?? ""); }
        private string w051;
        public string w51 { get => w051; set => w051 = string.Intern(value ?? ""); }
        private string w052;
        public string w52 { get => w052; set => w052 = string.Intern(value ?? ""); }
        private string w053;
        public string w53 { get => w053; set => w053 = string.Intern(value ?? ""); }
        private string w054;
        public string w54 { get => w054; set => w054 = string.Intern(value ?? ""); }
        private string w055;
        public string w55 { get => w055; set => w055 = string.Intern(value ?? ""); }
        private string w056;
        public string w56 { get => w056; set => w056 = string.Intern(value ?? ""); }
        private string w057;
        public string w57 { get => w057; set => w057 = string.Intern(value ?? ""); }
        private string w058;
        public string w58 { get => w058; set => w058 = string.Intern(value ?? ""); }
        private string w059;
        public string w59 { get => w059; set => w059 = string.Intern(value ?? ""); }
        private string w060;
        public string w60 { get => w060; set => w060 = string.Intern(value ?? ""); }
        private string w061;
        public string w61 { get => w061; set => w061 = string.Intern(value ?? ""); }
        private string w062;
        public string w62 { get => w062; set => w062 = string.Intern(value ?? ""); }
        private string w063;
        public string w63 { get => w063; set => w063 = string.Intern(value ?? ""); }
        private string w064;
        public string w64 { get => w064; set => w064 = string.Intern(value ?? ""); }
        private string w065;
        public string w65 { get => w065; set => w065 = string.Intern(value ?? ""); }
        private string w066;
        public string w66 { get => w066; set => w066 = string.Intern(value ?? ""); }
        private string w067;
        public string w67 { get => w067; set => w067 = string.Intern(value ?? ""); }
        private string w068;
        public string w68 { get => w068; set => w068 = string.Intern(value ?? ""); }
        private string w069;
        public string w69 { get => w069; set => w069 = string.Intern(value ?? ""); }
        private string w070;
        public string w70 { get => w070; set => w070 = string.Intern(value ?? ""); }
        private string w071;
        public string w71 { get => w071; set => w071 = string.Intern(value ?? ""); }
        private string w072;
        public string w72 { get => w072; set => w072 = string.Intern(value ?? ""); }
        private string w073;
        public string w73 { get => w073; set => w073 = string.Intern(value ?? ""); }
        private string w074;
        public string w74 { get => w074; set => w074 = string.Intern(value ?? ""); }
        private string w075;
        public string w75 { get => w075; set => w075 = string.Intern(value ?? ""); }
        private string w076;
        public string w76 { get => w076; set => w076 = string.Intern(value ?? ""); }
        private string w077;
        public string w77 { get => w077; set => w077 = string.Intern(value ?? ""); }
        private string w078;
        public string w78 { get => w078; set => w078 = string.Intern(value ?? ""); }
        private string w079;
        public string w79 { get => w079; set => w079 = string.Intern(value ?? ""); }
        private string w080;
        public string w80 { get => w080; set => w080 = string.Intern(value ?? ""); }
        private string w081;
        public string w81 { get => w081; set => w081 = string.Intern(value ?? ""); }
        private string w082;
        public string w82 { get => w082; set => w082 = string.Intern(value ?? ""); }
        private string w083;
        public string w83 { get => w083; set => w083 = string.Intern(value ?? ""); }
        private string w084;
        public string w84 { get => w084; set => w084 = string.Intern(value ?? ""); }
        private string w085;
        public string w85 { get => w085; set => w085 = string.Intern(value ?? ""); }
        private string w086;
        public string w86 { get => w086; set => w086 = string.Intern(value ?? ""); }
        private string w087;
        public string w87 { get => w087; set => w087 = string.Intern(value ?? ""); }
        private string w088;
        public string w88 { get => w088; set => w088 = string.Intern(value ?? ""); }
        private string w089;
        public string w89 { get => w089; set => w089 = string.Intern(value ?? ""); }
        private string w090;
        public string w90 { get => w090; set => w090 = string.Intern(value ?? ""); }
        private string w091;
        public string w91 { get => w091; set => w091 = string.Intern(value ?? ""); }
        private string w092;
        public string w92 { get => w092; set => w092 = string.Intern(value ?? ""); }
        private string w093;
        public string w93 { get => w093; set => w093 = string.Intern(value ?? ""); }
        private string w094;
        public string w94 { get => w094; set => w094 = string.Intern(value ?? ""); }
        private string w095;
        public string w95 { get => w095; set => w095 = string.Intern(value ?? ""); }
        private string w096;
        public string w96 { get => w096; set => w096 = string.Intern(value ?? ""); }
        private string w097;
        public string w97 { get => w097; set => w097 = string.Intern(value ?? ""); }
        private string w098;
        public string w98 { get => w098; set => w098 = string.Intern(value ?? ""); }
        private string w099;
        public string w99 { get => w099; set => w099 = string.Intern(value ?? ""); }
        private string w0100;
        public string w100 { get => w0100; set => w0100 = string.Intern(value ?? ""); }
        private string w0101;
        public string w101 { get => w0101; set => w0101 = string.Intern(value ?? ""); }
        private string w0102;
        public string w102 { get => w0102; set => w0102 = string.Intern(value ?? ""); }
        private string w0103;
        public string w103 { get => w0103; set => w0103 = string.Intern(value ?? ""); }
        private string w0104;
        public string w104 { get => w0104; set => w0104 = string.Intern(value ?? ""); }
        private string w0105;
        public string w105 { get => w0105; set => w0105 = string.Intern(value ?? ""); }
        private string w0106;
        public string w106 { get => w0106; set => w0106 = string.Intern(value ?? ""); }
        private string w0107;
        public string w107 { get => w0107; set => w0107 = string.Intern(value ?? ""); }
        private string w0108;
        public string w108 { get => w0108; set => w0108 = string.Intern(value ?? ""); }
        private string w0109;
        public string w109 { get => w0109; set => w0109 = string.Intern(value ?? ""); }
        private string w0110;
        public string w110 { get => w0110; set => w0110 = string.Intern(value ?? ""); }
        private string w0111;
        public string w111 { get => w0111; set => w0111 = string.Intern(value ?? ""); }
        private string w0112;
        public string w112 { get => w0112; set => w0112 = string.Intern(value ?? ""); }
        private string w0113;
        public string w113 { get => w0113; set => w0113 = string.Intern(value ?? ""); }
        private string w0114;
        public string w114 { get => w0114; set => w0114 = string.Intern(value ?? ""); }
        private string w0115;
        public string w115 { get => w0115; set => w0115 = string.Intern(value ?? ""); }
        private string w0116;
        public string w116 { get => w0116; set => w0116 = string.Intern(value ?? ""); }
        private string w0117;
        public string w117 { get => w0117; set => w0117 = string.Intern(value ?? ""); }
        private string w0118;
        public string w118 { get => w0118; set => w0118 = string.Intern(value ?? ""); }
        private string w0119;
        public string w119 { get => w0119; set => w0119 = string.Intern(value ?? ""); }
        private string w0120;
        public string w120 { get => w0120; set => w0120 = string.Intern(value ?? ""); }
        private string w0121;
        public string w121 { get => w0121; set => w0121 = string.Intern(value ?? ""); }
        private string w0122;
        public string w122 { get => w0122; set => w0122 = string.Intern(value ?? ""); }
        private string w0123;
        public string w123 { get => w0123; set => w0123 = string.Intern(value ?? ""); }
        private string w0124;
        public string w124 { get => w0124; set => w0124 = string.Intern(value ?? ""); }
        private string w0125;
        public string w125 { get => w0125; set => w0125 = string.Intern(value ?? ""); }
        private string w0126;
        public string w126 { get => w0126; set => w0126 = string.Intern(value ?? ""); }
        private string w0127;
        public string w127 { get => w0127; set => w0127 = string.Intern(value ?? ""); }
        private string w0128;
        public string w128 { get => w0128; set => w0128 = string.Intern(value ?? ""); }
        private string w0129;
        public string w129 { get => w0129; set => w0129 = string.Intern(value ?? ""); }
        private string w0130;
        public string w130 { get => w0130; set => w0130 = string.Intern(value ?? ""); }
        private string w0131;
        public string w131 { get => w0131; set => w0131 = string.Intern(value ?? ""); }
        private string w0132;
        public string w132 { get => w0132; set => w0132 = string.Intern(value ?? ""); }
        private string w0133;
        public string w133 { get => w0133; set => w0133 = string.Intern(value ?? ""); }
        private string w0134;
        public string w134 { get => w0134; set => w0134 = string.Intern(value ?? ""); }
        private string w0135;
        public string w135 { get => w0135; set => w0135 = string.Intern(value ?? ""); }
        private string w0136;
        public string w136 { get => w0136; set => w0136 = string.Intern(value ?? ""); }
        private string w0137;
        public string w137 { get => w0137; set => w0137 = string.Intern(value ?? ""); }
        private string w0138;
        public string w138 { get => w0138; set => w0138 = string.Intern(value ?? ""); }
        private string w0139;
        public string w139 { get => w0139; set => w0139 = string.Intern(value ?? ""); }
        private string w0140;
        public string w140 { get => w0140; set => w0140 = string.Intern(value ?? ""); }
        private string w0141;
        public string w141 { get => w0141; set => w0141 = string.Intern(value ?? ""); }
        private string w0142;
        public string w142 { get => w0142; set => w0142 = string.Intern(value ?? ""); }
        private string w0143;
        public string w143 { get => w0143; set => w0143 = string.Intern(value ?? ""); }
        private string w0144;
        public string w144 { get => w0144; set => w0144 = string.Intern(value ?? ""); }
        private string w0145;
        public string w145 { get => w0145; set => w0145 = string.Intern(value ?? ""); }
        private string w0146;
        public string w146 { get => w0146; set => w0146 = string.Intern(value ?? ""); }
        private string w0147;
        public string w147 { get => w0147; set => w0147 = string.Intern(value ?? ""); }
        private string w0148;
        public string w148 { get => w0148; set => w0148 = string.Intern(value ?? ""); }
        private string w0149;
        public string w149 { get => w0149; set => w0149 = string.Intern(value ?? ""); }
        private string w0150;
        public string w150 { get => w0150; set => w0150 = string.Intern(value ?? ""); }
        private string w0151;
        public string w151 { get => w0151; set => w0151 = string.Intern(value ?? ""); }
        private string w0152;
        public string w152 { get => w0152; set => w0152 = string.Intern(value ?? ""); }
        private string w0153;
        public string w153 { get => w0153; set => w0153 = string.Intern(value ?? ""); }
        private string w0154;
        public string w154 { get => w0154; set => w0154 = string.Intern(value ?? ""); }
        private string w0155;
        public string w155 { get => w0155; set => w0155 = string.Intern(value ?? ""); }
        private string w0156;
        public string w156 { get => w0156; set => w0156 = string.Intern(value ?? ""); }
        private string w0157;
        public string w157 { get => w0157; set => w0157 = string.Intern(value ?? ""); }
        private string w0158;
        public string w158 { get => w0158; set => w0158 = string.Intern(value ?? ""); }
        private string w0159;
        public string w159 { get => w0159; set => w0159 = string.Intern(value ?? ""); }
        private string w0160;
        public string w160 { get => w0160; set => w0160 = string.Intern(value ?? ""); }
        private string w0161;
        public string w161 { get => w0161; set => w0161 = string.Intern(value ?? ""); }
        private string w0162;
        public string w162 { get => w0162; set => w0162 = string.Intern(value ?? ""); }
        private string w0163;
        public string w163 { get => w0163; set => w0163 = string.Intern(value ?? ""); }
        private string w0164;
        public string w164 { get => w0164; set => w0164 = string.Intern(value ?? ""); }
        private string w0165;
        public string w165 { get => w0165; set => w0165 = string.Intern(value ?? ""); }
        private string w0166;
        public string w166 { get => w0166; set => w0166 = string.Intern(value ?? ""); }
        private string w0167;
        public string w167 { get => w0167; set => w0167 = string.Intern(value ?? ""); }
        private string w0168;
        public string w168 { get => w0168; set => w0168 = string.Intern(value ?? ""); }
        private string w0169;
        public string w169 { get => w0169; set => w0169 = string.Intern(value ?? ""); }
        private string w0170;
        public string w170 { get => w0170; set => w0170 = string.Intern(value ?? ""); }
        private string w0171;
        public string w171 { get => w0171; set => w0171 = string.Intern(value ?? ""); }
        private string w0172;
        public string w172 { get => w0172; set => w0172 = string.Intern(value ?? ""); }
        private string w0173;
        public string w173 { get => w0173; set => w0173 = string.Intern(value ?? ""); }
        private string w0174;
        public string w174 { get => w0174; set => w0174 = string.Intern(value ?? ""); }
        private string w0175;
        public string w175 { get => w0175; set => w0175 = string.Intern(value ?? ""); }
        private string w0176;
        public string w176 { get => w0176; set => w0176 = string.Intern(value ?? ""); }
        private string w0177;
        public string w177 { get => w0177; set => w0177 = string.Intern(value ?? ""); }
        private string w0178;
        public string w178 { get => w0178; set => w0178 = string.Intern(value ?? ""); }
        private string w0179;
        public string w179 { get => w0179; set => w0179 = string.Intern(value ?? ""); }
        private string w0180;
        public string w180 { get => w0180; set => w0180 = string.Intern(value ?? ""); }
        private string w0181;
        public string w181 { get => w0181; set => w0181 = string.Intern(value ?? ""); }
        private string w0182;
        public string w182 { get => w0182; set => w0182 = string.Intern(value ?? ""); }
        private string w0183;
        public string w183 { get => w0183; set => w0183 = string.Intern(value ?? ""); }
        private string w0184;
        public string w184 { get => w0184; set => w0184 = string.Intern(value ?? ""); }
        private string w0185;
        public string w185 { get => w0185; set => w0185 = string.Intern(value ?? ""); }
        private string w0186;
        public string w186 { get => w0186; set => w0186 = string.Intern(value ?? ""); }
        private string w0187;
        public string w187 { get => w0187; set => w0187 = string.Intern(value ?? ""); }
        private string w0188;
        public string w188 { get => w0188; set => w0188 = string.Intern(value ?? ""); }
        private string w0189;
        public string w189 { get => w0189; set => w0189 = string.Intern(value ?? ""); }
        private string w0190;
        public string w190 { get => w0190; set => w0190 = string.Intern(value ?? ""); }
        private string w0191;
        public string w191 { get => w0191; set => w0191 = string.Intern(value ?? ""); }
        private string w0192;
        public string w192 { get => w0192; set => w0192 = string.Intern(value ?? ""); }
        private string w0193;
        public string w193 { get => w0193; set => w0193 = string.Intern(value ?? ""); }
        private string w0194;
        public string w194 { get => w0194; set => w0194 = string.Intern(value ?? ""); }
        private string w0195;
        public string w195 { get => w0195; set => w0195 = string.Intern(value ?? ""); }
        private string w0196;
        public string w196 { get => w0196; set => w0196 = string.Intern(value ?? ""); }
        private string w0197;
        public string w197 { get => w0197; set => w0197 = string.Intern(value ?? ""); }
        private string w0198;
        public string w198 { get => w0198; set => w0198 = string.Intern(value ?? ""); }
        private string w0199;
        public string w199 { get => w0199; set => w0199 = string.Intern(value ?? ""); }
    }
}
