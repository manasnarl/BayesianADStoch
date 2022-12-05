using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ILNumerics;
using MSTClass;

namespace BayesianADStoch
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double[] S_sig = null;
        public MainWindow()
        {
            InitializeComponent();
            S_sig = new double[] {1242468520996.05,
                1269816048064.46,
                1302207662770.71,
                1359907246667.25,
                1446412086495.54 ,
                1397227946753.68 ,
                1256702306254.11,
                1704586708438.86,
                1277543316500.51,
                1326710071928.44,
                1273804211465.86,
                1195553367456.82,
                1126466830293.19,
                1164208008033.12,
                1276137237978.93,
                1349674131811.46,
                1360721897699.97,
                1516434574441.50,
                1292296632657.95,
                1251597594195.73,
                1183050848414.20,
                1134297966574.24,
                1104356412041.27,
                1090862081385.96,
                1122423328780.03,
                1221198315273.88,
                1352157062477.46,
                1486157460314.65,
                1570426046864.24,
                1538967199935.06,
                1456139065074.32,
                1397454355298.06,
                1344979195985.73,
                1380766033913.80,
                1473313356961.07,
                1298019319659.95,
                1201248888384.67,
                2006885583500.30,
                2885359805002.96,
                2245227607541.88,
                1536151139780.84,
                1442611903048.86,
                1778938984834.44,
                1781999464387.46,
                1646356813637.55,
                1737349030669.75,
                1702933143456.28,
                1742238974606.79,
                1783121720324.65,
                1910436872763.09,
                2087885285019.32,
                2140740364468.66,
                2244666437595.19,
                2239689425542.40,
                1939253644379.86,
                1664983275279.66,
                1447967769452.88,
                1594181727893.75,
                1867427853276.53,
                1805551749922.41,
                1759907175048.08,
                1753842616217.51,
                1792747299210.17,
                1747683518694.68,
                1672641535554.80,
                1634649017407.70,
                1618420029637.35,
                1597023079542.79,
                1594520776437.69,
                1631811330483.36,
                1689312095843.24,
                1751085019264.61,
                1780681554559.10,
                1738193741373.79,
                1657393577620.64,
                1578952492481.44,
                1523613142966.58,
                1547157193017.38,
                1627831627381.94,
                1649229808535.66,
                1703128948120.28,
                2055287874644.94,
                2068434483949.90,
                2434560660250.00,
                1667071633094.56,
                2131546245122.76,
                2903934278291.29,
                1373574399074.90,
                2874836079720.74,
                2405385919573.87,
                2199472397694.20,
                2058378281857.00,
                2083763311316.80,
                2175742823337.57,
                2340507117438.76,
                2621147580945.58,
                2873357959265.74,
                2911713378977.78,
                2813176076018.61,
                2698063647002.49,
                2605797799169.67,
                2591346051182.35,
                2679180381183.55,
                2693799650327.71 ,
                2556427408253.62 ,
                2864241514405.84 ,
                4045435518595.92 ,
                1386608653624.56 ,
                3861905624471.82 ,
                3166915680843.29 ,
                2937281518241.18 ,
                2819618515966.75 ,
                2904215187122.96 ,
                2932557383823.57 ,
                2913691050160.13 ,
                3145970874998.75 ,
                3331007893849.28 ,
                2915107269739.33 ,
                3643396334637.06 ,
                3062804711925.62 ,
                3388983807286.83 ,
                3233945819043.53 ,
                3036942084090.45 ,
                3019557851616.32 ,
                3110023459978.49 ,
                3001783505542.92 ,
                2721352145233.32 ,
                3550816108301.61 ,
                2783269918755.02 ,
                3185972369878.16 ,
                5101222685685.30 ,
                4034128307616.39 ,
                1916997380379.35 ,
                4853386100014.88 ,
                1857741358332.32 ,
                2171671181387.96 ,
                2132476486448.01 ,
                2875626808047.88 ,
                3768616419887.49 ,
                5525195313350.93 ,
                6912813462454.87 ,
                5198963735608.29 ,
                2415799667753.17 ,
                4364796944806.22 ,
                3831330538984.24 ,
                3599195098378.96 ,
                2808542408327.45 ,
                3070816278218.41 ,
                3135290090137.12 ,
                4125395646351.56 ,
                5611736245598.96 ,
                6423938123585.55 ,
                6839747834295.37 ,
                6726378137573.73 ,
                6117723394613.67 ,
                6236674745162.53 ,
                4375960858804.30 ,
                3398958961036.93 ,
                2614143161853.23 ,
                1402177846945.47 ,
                936759704179.109 ,
                6567701544345.27 ,
                13001599858863.7 ,
                14427276917663.1 ,
                9306883751424.36 ,
                31830756787309.7 ,
                12835729309872.0 ,
                2131186414045.19 ,
                2848598603785.04 ,
                2270661245254.69 ,
                2896369405088.26 ,
                4399610254792.06 ,
                4872730739969.86 ,
                14035713934799.8 ,
                8207436270699.01 ,
                10728174272091.6 ,
                10565784928762.0 ,
                8599517693029.09 ,
                5338991374533.33 ,
                2009790771336.95 ,
                1348587006386.86 ,
                2505460206284.74 ,
                4243204109839.80 ,
                15815598957720.3 ,
                12609778626661.1 ,
                18050332570684.8 ,
                18466171196306.2 ,
                24512815539754.8 ,
                7634271358265.62 ,
                4803874856577.63 ,
                2549064224251.10 ,
                2163683972765.67 ,
                3982952637819.53 ,
                4938109013257.81 ,
                14888427567992.2 ,
                16693634189895.9 ,
                16857764905251.4 ,
                23977647377846.7 ,
                8146105719733.35 ,
                7712720295037.65 ,
                6457506166172.76 ,
                2922837368585.43 ,
                1166834285565.65 ,
                3564083528233.14 ,
                9515688373474.50 ,
                28844392429581.5 ,
                26677665750883.0 ,
                38326731995013.3 ,
                16213844557543.1 ,
                29890006417378.9 ,
                25282690106822.3 ,
                31138252930657.0 ,
                5049888532337.24 ,
                7470897418188.69 ,
                9276430494431.56 ,
                5573756633574.88 ,
                59369261189211.2 ,
                71541295489798.0 ,
                81662814381612.3 ,
                35923383047974.8 ,
                24406305914288.5 ,
                71009942105895.4 ,
                50224997011579.5 ,
                28394409022331.1 ,
                27324595575363.5 ,
                37300960087823.3 ,
                35775128653188.7 ,
                75180350137911.3 ,
                70843419388543.1 ,
                153153033009635  ,
                91516702877517.8 ,
                214500883802626  ,
                286954016429900  ,
                76156681937345.9 ,
                1.10331112043396e+15,
                52998576608734.3 ,
                374063659286789  ,
                160629299806627  ,
                682101579962977  ,
                899816831034760 ,
                161357901136806 ,
                39680888451483.8,
                455121937408809 ,
                302923386970406 ,
                371784213506550 ,
                86077449726686.2,
                248315569276660 ,
                65569222590695.7,
                27061550380288.6,
                666867945841197 ,
                432680984788820 ,
                6.28083176100516e+15,
                5.67745438718748e+15,
                1.41822768291587e+16,
                9.45502437444441e+15,
                4.72777503268516e+15,
                2.49579283559317e+15,
                263822234197736     ,
                527087235752355     ,
                790383065424764     ,
                24556642665378.2    ,
                670928601447870     ,
                862470977889818     ,
                1.32660107396050e+15,
                1.84193329636306e+15,
                2.20203071710260e+15,
                2.42811707576953e+15,
                105582007743395     ,
                2.85537142726213e+15,
                568948829504876     ,
                1.75989342813870e+15,
                310277457905704     ,
                982609850152281     ,
                4275242617724.13    ,
                931308550996285     ,
                1.01196031223354e+15,
                52893397524101.2    ,
                267222359270746     ,
                255701250640546     ,
                301790628629.000    ,
                62709004996113.4    ,
                12343692150604.0    ,
                26454068969492.4    ,
                2511462650066.43    ,
                4023993395932.92    ,
                157094254976556,
                34742938995468.6,
                129172502604666 ,
                21882876856772.3,
                90564897189637.2,
                64823871476721.5,
                9294213431608.81,
                142070401901458 ,
                3896042455703.13,
                43021445875496.6,
                6428254423759.14,
                4185567056479.76,
                31476457795075.0,
                42048324634855.0,
                7177768655277.24,
                20590194320616.1,
                24738302838831.9,
                15971827487898.2,
                3251249221202.87,
                9600409240351.82,
                5829811325839.42,
                10365528727856.0,
                995663834971.836,
                19218215385657.2,
                35202346527612.3,
                4027596928942.55,
                15541534543616.3,
                5705570664353.34,
                6186128587607.05,
                2067158559266.20,
                17551759715878.8,
                2425930223705.11,
                6913067675008.55,
                8472068823659.35,
                6232983834119.09,
                3255351501576.21,
                2365664367715.25,
                7495727365741.36,
                7522732314035.63,
                2654773754180.51,
                2453234400263.58,
                3537671332490.33,
                3842290912813.06,
                3139730035391.13,
                4871418590227.70,
                8307493085618.88,
                309180868043.969,
                5135947460551.98,
                8879837252340.04 ,
                1856825492785.91 ,
                2145973488109.53 ,
                2466085600107.73 ,
                2113917145055.18 ,
                1861720973286.66 ,
                1927019923045.34 ,
                2184194203201.30 ,
                2582372872243.74 ,
                3159136351492.52 ,
                2144467708818.75 ,
                2858957809153.86 ,
                3250760546336.65 ,
                4286676250125.63 ,
                854636530474.472 ,
                4704310067115.57 ,
                2916398457757.08 ,
                840149560632.895 ,
                6286710942520.96 ,
                1508083431391.73 ,
                2549164121321.19 ,
                2833509018126.39 ,
                2350228288173.70 ,
                1725238227879.43 ,
                2228442920038.78 ,
                3105973331695.47 ,
                2905075425416.88 ,
                2196668814908.79 ,
                2506749658691.56 ,
                2827282544354.46 ,
                2196438557228.75 ,
                1449219164647.73 ,
                4528249193999.28 ,
                8018803214548.75 ,
                6102478946089.81 ,
                2132312133590.94 ,
                3948618186548.71 ,
                3552856862823.49 ,
                3672662323764.68 ,
                2741595421882.13 ,
                2283862720042.95 ,
                1962777089374.11 ,
                1502903771551.75 ,
                1077504903899.91 ,
                1090888570663.89 ,
                1003354765685.00 ,
                950708539248.720 ,
                1248845514878.02 ,
                1314802358228.73 ,
                1390319306952.55 ,
                1466872975683.98 ,
                1559911672972.51 ,
                1734665435546.22 ,
                1812397985110.15 ,
                1924491645775.35 ,
                1973410807503.12 ,
                1958954634944.34 ,
                1895827432935.56 ,
                1735142517354.90 ,
                1723743545366.65 ,
                1606277930289.60 ,
                1632792443506.76 ,
                1621558244168.46 ,
                1641929894105.63 ,
                1679168167308.54 ,
                1721928356481.46 ,
                1758752048868.48 ,
                1772901316187.68 ,
                1745013748846.43 ,
                1685761668169.52 ,
                1619996880091.05 ,
                1545882657138.80 ,
                1449993851268.48 ,
                1380895351048.42 ,
                1314320552013.00 ,
                1293612404902.53 ,
                1352772269719.26 ,
                1484411983089.23 ,
                1635174213694.70 ,
                1398429258376.99 ,
                2026898017037.59 ,
                1420223381511.96 ,
                1476076719184.95 ,
                1399099623750.10 ,
                1300016505873.43 ,
                1188857296446.80 ,
                1107476511987.90 ,
                1032227639768.49 ,
                1138449796144.99 ,
                1496436598292.20 ,
                1254542188329.42 ,
                549844127583.094 ,
                3107204335461.74 ,
                647469468312.212 ,
                1156854256314.50 ,
                1231751072577.49 ,
                1225860423103.60 ,
                1097414641229.10,
                1268515663103.11,
                1201280997072.14,
                1234459842920.05,
                1207394034905.63,
                1180837558918.44,
                1139089933780.46,
                1111041072179.29,
                1091074296654.97,
                1001545273675.52,
                938709003342.479,
                1101287601662.29,
                1283595435990.55,
                1154739741857.63,
                920010348248.119,
                898345484791.194,
                974022330812.669,
                968562330683.034,
                923057584358.584,
                894673929526.864,
                870412392514.680,
                838313546869.550,
                813370570983.347,
                808887429906.268,
                817705549800.511,
                831677875104.987,
                837499848599.537,
                821392793994.417,
                791771415922.527,
                761036091896.768,
                741828625690.953,
                746879836532.203,
                772024065949.668,
                808525548456.728,
                846460936837.975,
                876701446180.906,
                899037708428.073,
                913908688286.150,
                932852699375.580,
                964846078587.336,
                1000864695050.27,
                1034116996671.41,
                1035738551498.11,
                979894915913.900,
                888458635441.749,
                785712337554.863,
                717647731862.242,
                729790470318.841,
                795425911760.958,
                877421690084.039,
                929725981144.909,
                904409778611.161,
                824213697573.086,
                726555226912.631,
                646034973616.361,
                619290015054.859,
                634546702421.185,
                668297086437.043,
                699814831526.587,
                707938889184.300,
                701716075207.553,
                693662368037.511,
                700857561832.346,
                754680142510.003,
                845310726918.758,
                898506973660.797,
                902668712260.979,
                1081731667761.16,
                911562592469.356,
                927083714755.172,
                934382708919.594,
                988549626346.435,
                1068872887854.05,
                1162451621097.10,
                1244830438420.55,
                1285313589406.15,
                1293382803743.41,
                1289151745558.29,
                1276159292353.43,
                1260503914892.62,
                1247692154124.12,
                1237711220080.46,
 };
            for (int i = 0; i < S_sig.Length; i++)
                lstInput.Items.Add(S_sig[i]);
        }
        private static void Decompsh(double[] X_Sig, double L, double[] qmf, double LMax, int show, out double[] Y_Sig, out double[] yd, out double[] ystoch, out double[] ns, out double[] eta)
        {
            Class1 clsADS = new Class1();
            int len = X_Sig.Length;
            Y_Sig = new double[len];
            yd = new double[len];
            ystoch = new double[len];
            ns = new double[len];
            double[] beta = new double[len];

            int n = 0; double j;

            n = X_Sig.Length;
            j = Math.Ceiling(Math.Log(n) / Math.Log(2));

            // Step 11.1: Calculate Forward wavelet Transform W_coef using 11.1.1 to 11.1.5 using Eq.1
            double[] wcoef = FWT_PO(X_Sig, L, qmf);


            int[] dyadj = dyad(j - 1);
            //% Step 11.2:  Estimate the noise variance estimation with high resolution wavelet coefficients -wfine
            double[] wfine = new double[dyadj.Length];
            for (int i = 0; i < dyadj.Length; i++)
                wfine[i] = wcoef[dyadj[i] - 1];
            //% Step 11.3: Estimate noise variance sigmasquare using modified donoho method - 11.3.1 to 11.3.2 
            //% Step 11.3.1: 11.3.1.	Calculate median absolute deviation estimation function -MAD using Eq.3
            //% Step 11.3.2: MAD(wfine)^2 - noisevariance 
            double noisevar = Math.Pow(clsADS.mad2(wfine), 2);  //% estimate with donoho method,

            //% Step 11.4: Estimate Deterministic Mean parameter structure mu computation using 11.4.1 to 11.4.3
            //% Step 11.4.1:
            double[] mu = new double[wcoef.Length];
            for (int i = 0; i < wcoef.Length; i++)
                mu[i] = wcoef[i];
            //% Step 11.4.2:
            for (int k = (int)j - 1; k > (LMax + 1); k--)
            {
                dyadj = dyad(k - 1);
                for (int i = 0; i < dyadj.Length; i++)
                    mu[dyadj[i]] = 0;
            }
            double[] wj = null;
            //% Step 11.4.3:
            for (int k = (int)LMax; k >= L; k--)//% loop through scales
            { //% Step 11.4.3.1:
                dyadj = dyad(k);
                //% Step 11.4.3.2:
                wj = new double[dyadj.Length];

                for (int i = 0; i < dyadj.Length; i++)
                    wj[i] = wcoef[dyadj[i] - 1];

                int nj = wj.Length;
                var sorted = wj.Select((xx, i) => new KeyValuePair<double, double>(xx, i)).OrderBy(xx => xx.Key).ToArray();

                double[] wjs = sorted.Select(xx => xx.Key).ToArray();
                double[] l = sorted.Select(xx => xx.Value).ToArray();

                double[] njs = new double[nj];
                for (int i = 0; i < nj; i++)
                    njs[i] = (i + 1.0) / (nj + 1.0);
                //% Step 11.4.3.3:
                double[] qj = clsADS.norminv(njs, 0, 1);
                double[] abswj = ILMath.abs((ILArray<double>)wj).ToArray();

                double Tj = (double)ILMath.median((ILArray<double>)abswj) / 0.6745;// %slope of quantiles-normalquantiles plot


                double[] qwj = new double[nj];
                for (int i = 0; i < nj; i++)
                    qwj[(int)l[i]] = qj[i];

                //% Step 11.4.3.6:
                double[] resj = new double[nj];
                for (int i = 0; i < nj; i++)
                    resj[i] = wj[i] - (Tj * qwj[i]);

                for (int i = 0; i < nj; i++)
                    if (Math.Abs(wj[i]) > Math.Abs(Tj * qwj[i]))
                        qwj[i] = 0;
                //% Step 11.4.3.7:
                
                double lambdaj = Tj * (double)ILMath.max(ILMath.abs((ILArray<double>)qwj));

                double[] muj = new double[nj];
                for (int i = 0; i < nj; i++)
                    muj[i] = (Math.Pow(resj[i], 2) / (Math.Pow(Tj, 2) + Math.Pow(resj[i], 2))) * wj[i];
                //% Step 11.4.3.8:
                for (int kk = 0; kk < (int)Math.Pow(2, k); kk++)
                    if (Math.Abs(wj[kk]) <= lambdaj)
                        muj[kk] = 0;
                //% Step 11.4.3.9:
                dyadj = dyad(k);
                for (int i = 0; i < nj; i++)
                    mu[dyadj[i] - 1] = muj[i];
            }
            //% Step 11.5 Calculate the Deterministic structure estimate yd using Inverse wavelet Transform

            yd = IWT_PO(mu, L, qmf);
           
            //% Step 11.5.t store x_sig = yd

            //% Step 11.6. Estimation of Determine the stochastic  component eta...
            eta = new double[mu.Length];
            //% Step 11.6.1.
            eta = mu;
            //% Step 11.6.2
            for (int k = (int)LMax; k >= L; k--)
            {
                dyadj = dyad(k);
                //% Step 11.6.2.1.
                double[] muj = new double[dyadj.Length];
                for (int i = 0; i < dyadj.Length; i++)
                    muj[i] = mu[dyadj[i] - 1];
                //% Step 11.6.2.2.
                int nj = muj.Length;

                //% Step 11.6.2.3.

                double[] Dj = new double[nj];
                for (int i = 0; i < nj; i++)
                    Dj[i] = wcoef[dyadj[i] - 1] - muj[i];
                //% Step 11.6.2.4.
                double Dj2 = (double)ILMath.multiply(((ILArray<double>)Dj).T, ((ILArray<double>)Dj));
                
                
                //% Step 11.6.2.5.substract noisevar from  (Dj2 / (2^k))
                double Dvar = (Dj2 / Math.Pow(2, k)) - noisevar;
                //% Step 11.6.2.6.store the Maximum of DVar and 0 in Sigma2j using Eq.12
                double sigma2j = Math.Max(Dvar, 0);

                //% Step 11.6.2.7. To determine the Bayesian shrinkage , multiply DJ with (sigma2j / (sigma2j + noisevar)) - dbj
                double[] dbj = new double[nj];
                for (int i = 0; i < nj; i++)
                    dbj[i] = (sigma2j / (sigma2j + noisevar)) * Dj[i];

                //% Step 11.6.2.8. sum of muj and dbj (2*j +1 : 2^(j+1)) = eta.
                //% Step 11.6.3. Substitute the data from muj to eta.
                for (int i = 0; i < nj; i++)
                    eta[dyadj[i] - 1] = muj[i] + dbj[i];


            }
            //%step 11.7. Calculate Deterministic and stochastic denoised Estimate Y_Sig, using Inverse Wavelet Transform and eta, nlvl5, QMF as per the procedure depicted in 11.5.1. to 11.5.5. while storing results in Y_Sig using Eq.w.
            Y_Sig = IWT_PO(eta, L, qmf);
            //% step 11.8.Calculate stochastic component estimate ystoch i.e.  [yd - Y_Sig] → ystoch
            //% step 11.9. Evaluate the Noise component ns, i.e.[X_Sig - Y_Sig] → ns.
            for (int i = 0; i < len; i++)
            {
                ystoch[i] = Y_Sig[i] - yd[i];
                ns[i] = Y_Sig[i] - X_Sig[i];
            }

        }

        private static double[] IWT_PO(double[] wc, double L, double[] qmf)
        {
            Class1 clsADS = new Class1();


            int n = wc.Length;

            double[] wcoef = new double[n];
            for (int i = 0; i < n; i++)
                wcoef[i] = wc[i];
            //% Step 11.5.1 
            double[] x = new double[(int)Math.Pow(2, L)];
            for (int i = 0; i < (int)Math.Pow(2, L); i++)
                x[i] = wcoef[i];
            int nn = 0; double j = 0;
            //% Step 11.5.2 
            nn = wcoef.Length;
            //% Step 11.5.3 
            j = Math.Ceiling(Math.Log(nn) / Math.Log(2));
            //% Step 11.5.4 
            for (int jj = (int)L; jj < j; jj++)
            {
                int[] dyadj = dyad(jj);
                double[] wcoefdyadjlen = new double[dyadj.Length];
                for (int i = 0; i < dyadj.Length; i++)
                    wcoefdyadjlen[i] = wcoef[dyadj[i] - 1];
                //% Step 11.5.4.1 
                double[] updyadLo = clsADS.UpDyadLo(x, qmf);
                //% Step 11.5.4.2 
                double[] updyadHi = clsADS.UpDyadHi(wcoefdyadjlen, qmf);

                x = new double[updyadLo.Length];
                //% Step 11.5.4.3 
                for (int i = 0; i < updyadLo.Length; i++)
                    x[i] = updyadLo[i] + updyadHi[i];

            }

            return x;


        }
        private static int[] dyad(double j)
        {

            List<int> i = new List<int>();
            int a = (int)Math.Pow(2, (j)) + 1;
            int b = (int)Math.Pow(2, (j + 1)) + 1;
            for (int k = a; k < b; k++)
                i.Add(k);

            return i.ToArray();
        }
        private static double[] FWT_PO(double[] x, double nlvl_5, double[] QMF)
        {
            Class1 clsADS = new Class1();

            int nfft = 0; double j_sig = 0;
            // Step 11.1.1: Intialize length S_Sig
            nfft = x.Length;
            // Step 11.1.2: Intialize Dyadic Length
            j_sig = Math.Ceiling(Math.Log(nfft) / Math.Log(2));
            // Step 11.1.3: Intialize array W_Coef with nfft samples - All zeros
            double[] W_Coef = new double[nfft];
            // Step 11.1.4: Calculate beta repead 11.1.4.1. to 11.1.4.3 for j = j_sig - 1 : nlvl_5
            double[] beta = x;
            for (int j = (int)j_sig - 1; j >= nlvl_5; j--)
            {
                // Step 11.1.4.1: Evaluate periodized Hi-Pass down sampling operator alpha using beta and QMF
                double[] alpha = clsADS.DownDyadHi(beta, QMF);
                int[] dyadjj = dyad(j);
                // Step 11.1.4.2: Replace the data from 2^j +1 : 2^(j+1) in wcoef = alpha
                for (int k = 0; k < dyadjj.Length; k++)
                    W_Coef[dyadjj[k] - 1] = alpha[k];
                // Step 11.1.4.3: Using Beta,QMF evaluate the Low Pass Down sampling operator (periodized) and replace Beta.
                beta = clsADS.DownDyadLo(beta, QMF);
            }
            int len = (int)Math.Pow(2, nlvl_5);
            // Step 11.1.5: substitute Beta- Wcoef 1:2^nlvl5
            for (int i = 0; i < len; i++)
                W_Coef[i] = beta[i];

            return W_Coef;
        }
        

        private void btnProcess_Click(object sender, RoutedEventArgs e)
        {
            // Step 11:	Calculate Deterministic Stochastic.
            
            //Algorithm Step 9. Initialize coefficients with modified 〖Sym〗_8 coefficients for a 3  level filtering → 〖nlvl〗_3
            String WavelettName = "Modified Sym 8"; int lev = 3, J = 9;


            //Algorithm Step 10. Calculate the Orthogonal wavelet filter set.
            double[] QMF = null;
            if (WavelettName == "Modified Sym 8")
            {
                QMF = new double[16] { .002672793393, -.000428394300, -.021145686528, .005386388754, .069490465911, -.038493521263, -.073462508761, .515398670374, 1.099106630537, .680745347190, -.086653615406, -.202648655286, .010758611751, .044823623042, -.000766690896, -.004783458512 };
                double sumorthloFit = (double)ILMath.norm((ILArray<double>)QMF);
                for (int i = 0; i < QMF.Length; i++)
                    QMF[i] = QMF[i] / sumorthloFit;
            }
            int n = S_sig.Length;
            double[] Y_Sig = new double[n];
            double[] yd = new double[n];
            double[] ys = new double[n];
            double[] ns = new double[n];
            double[] eta = new double[n];


            Decompsh(S_sig, lev, QMF, J - 1, 0, out Y_Sig, out yd, out ys, out ns, out eta);

            for (int i = 0; i < Y_Sig.Length; i++)
                lstOutput.Items.Add(Y_Sig[i]);
        }
    }
}
