using StreamingTools;
using System.Collections.Concurrent;

namespace Tests;

public class FFmpegTests
{
    [Fact]
    public void CanParseSilence()
    {
        string input = """
            [silencedetect @ 0000019aa74aae80] silence_start: 0
            [silencedetect @ 0000019aa74aae80] silence_end: 138.814146 | silence_duration: 138.814146
            [silencedetect @ 0000019aa74aae80] silence_start: 453.008812e=N/A speed=28.1x
            [silencedetect @ 0000019aa74aae80] silence_end: 455.160146 | silence_duration: 2.151333
            [silencedetect @ 0000019aa74aae80] silence_start: 483.448458e=N/A speed=  28x
            [silencedetect @ 0000019aa74aae80] silence_end: 486.739062 | silence_duration: 3.290604
            [silencedetect @ 0000019aa74aae80] silence_start: 542.435583e=N/A speed=  28x
            [silencedetect @ 0000019aa74aae80] silence_end: 544.562 | silence_duration: 2.126417
            [silencedetect @ 0000019aa74aae80] silence_start: 560.190125e=N/A speed=27.9x
            [silencedetect @ 0000019aa74aae80] silence_end: 563.632667 | silence_duration: 3.442542
            [silencedetect @ 0000019aa74aae80] silence_start: 565.103792e=N/A speed=  28x
            [silencedetect @ 0000019aa74aae80] silence_end: 568.470333 | silence_duration: 3.366542
            [silencedetect @ 0000019aa74aae80] silence_start: 573.439813
            [silencedetect @ 0000019aa74aae80] silence_end: 576.223854 | silence_duration: 2.784042
            [silencedetect @ 0000019aa74aae80] silence_start: 584.187812e=N/A speed=  28x
            [silencedetect @ 0000019aa74aae80] silence_end: 589.040687 | silence_duration: 4.852875
            [silencedetect @ 0000019aa74aae80] silence_start: 655.495312e=N/A speed=28.1x
            [silencedetect @ 0000019aa74aae80] silence_end: 658.169521 | silence_duration: 2.674208
            [silencedetect @ 0000019aa74aae80] silence_start: 674.438917e=N/A speed=28.1x
            [silencedetect @ 0000019aa74aae80] silence_end: 677.103104 | silence_duration: 2.664187
            [silencedetect @ 0000019aa74aae80] silence_start: 740.502458e=N/A speed=28.2x
            [silencedetect @ 0000019aa74aae80] silence_end: 743.105417 | silence_duration: 2.602958
            [silencedetect @ 0000019aa74aae80] silence_start: 766.84125te=N/A speed=28.2x
            [silencedetect @ 0000019aa74aae80] silence_end: 769.253375 | silence_duration: 2.412125
            [silencedetect @ 0000019aa74aae80] silence_start: 776.633708e=N/A speed=28.2x
            [silencedetect @ 0000019aa74aae80] silence_end: 778.674667 | silence_duration: 2.040958
            [silencedetect @ 0000019aa74aae80] silence_start: 781.598333
            [silencedetect @ 0000019aa74aae80] silence_end: 785.9065 | silence_duration: 4.308167
            [silencedetect @ 0000019aa74aae80] silence_start: 804.409rate=N/A speed=28.2x
            [silencedetect @ 0000019aa74aae80] silence_end: 809.415125 | silence_duration: 5.006125
            [silencedetect @ 0000019aa74aae80] silence_start: 855.646375e=N/A speed=28.3x
            [silencedetect @ 0000019aa74aae80] silence_end: 858.095042 | silence_duration: 2.448667
            [silencedetect @ 0000019aa74aae80] silence_start: 880.371417e=N/A speed=28.3x
            [silencedetect @ 0000019aa74aae80] silence_end: 883.885854 | silence_duration: 3.514438
            [silencedetect @ 0000019aa74aae80] silence_start: 902.92025te=N/A speed=28.3x
            [silencedetect @ 0000019aa74aae80] silence_end: 905.546771 | silence_duration: 2.626521
            [silencedetect @ 0000019aa74aae80] silence_start: 912.548729e=N/A speed=28.3x
            [silencedetect @ 0000019aa74aae80] silence_end: 915.630063 | silence_duration: 3.081333
            [silencedetect @ 0000019aa74aae80] silence_start: 917.676104
            [silencedetect @ 0000019aa74aae80] silence_end: 919.964083 | silence_duration: 2.287979
            [silencedetect @ 0000019aa74aae80] silence_start: 997.612562e=N/A speed=28.3x
            [silencedetect @ 0000019aa74aae80] silence_end: 1000.079 | silence_duration: 2.466438
            [silencedetect @ 0000019aa74aae80] silence_start: 1053.460979=N/A speed=28.4x
            [silencedetect @ 0000019aa74aae80] silence_end: 1057.704625 | silence_duration: 4.243646
            [silencedetect @ 0000019aa74aae80] silence_start: 1075.548875=N/A speed=28.3x
            [silencedetect @ 0000019aa74aae80] silence_end: 1081.242479 | silence_duration: 5.693604
            [silencedetect @ 0000019aa74aae80] silence_start: 1082.188417=N/A speed=28.4x
            [silencedetect @ 0000019aa74aae80] silence_end: 1085.040604 | silence_duration: 2.852187
            [silencedetect @ 0000019aa74aae80] silence_start: 1089.817958
            [silencedetect @ 0000019aa74aae80] silence_end: 1092.568104 | silence_duration: 2.750146
            [silencedetect @ 0000019aa74aae80] silence_start: 1113.727542=N/A speed=28.4x
            [silencedetect @ 0000019aa74aae80] silence_end: 1116.078354 | silence_duration: 2.350812
            [silencedetect @ 0000019aa74aae80] silence_start: 1211.229125=N/A speed=28.3x
            [silencedetect @ 0000019aa74aae80] silence_end: 1213.399583 | silence_duration: 2.170458
            [silencedetect @ 0000019aa74aae80] silence_start: 1229.198938=N/A speed=28.3x
            [silencedetect @ 0000019aa74aae80] silence_end: 1233.110229 | silence_duration: 3.911292
            [silencedetect @ 0000019aa74aae80] silence_start: 1240.7785te=N/A speed=28.2x
            [silencedetect @ 0000019aa74aae80] silence_end: 1244.390437 | silence_duration: 3.611937
            [silencedetect @ 0000019aa74aae80] silence_start: 1303.712146=N/A speed=28.1x
            [silencedetect @ 0000019aa74aae80] silence_end: 1308.727667 | silence_duration: 5.015521
            [silencedetect @ 0000019aa74aae80] silence_start: 1319.755604=N/A speed=  28x
            [silencedetect @ 0000019aa74aae80] silence_end: 1322.571958 | silence_duration: 2.816354
            [silencedetect @ 0000019aa74aae80] silence_start: 1340.130146=N/A speed=  28x
            [silencedetect @ 0000019aa74aae80] silence_end: 1342.159854 | silence_duration: 2.029708
            [silencedetect @ 0000019aa74aae80] silence_start: 1345.767979=N/A speed=  28x
            [silencedetect @ 0000019aa74aae80] silence_end: 1349.743438 | silence_duration: 3.975458
            [silencedetect @ 0000019aa74aae80] silence_start: 1372.287562=N/A speed=  28x
            [silencedetect @ 0000019aa74aae80] silence_end: 1374.295729 | silence_duration: 2.008167
            [silencedetect @ 0000019aa74aae80] silence_start: 1381.869062=N/A speed=  28x
            [silencedetect @ 0000019aa74aae80] silence_end: 1386.835938 | silence_duration: 4.966875
            [silencedetect @ 0000019aa74aae80] silence_start: 1391.972583=N/A speed=  28x
            [silencedetect @ 0000019aa74aae80] silence_end: 1397.954208 | silence_duration: 5.981625
            [silencedetect @ 0000019aa74aae80] silence_start: 1434.313729=N/A speed=  28x
            [silencedetect @ 0000019aa74aae80] silence_end: 1437.411292 | silence_duration: 3.097562
            [silencedetect @ 0000019aa74aae80] silence_start: 1478.747542=N/A speed=  28x
            [silencedetect @ 0000019aa74aae80] silence_end: 1482.663125 | silence_duration: 3.915583
            [silencedetect @ 0000019aa74aae80] silence_start: 1497.862542=N/A speed=  28x
            [silencedetect @ 0000019aa74aae80] silence_end: 1500.603479 | silence_duration: 2.740937
            [silencedetect @ 0000019aa74aae80] silence_start: 1501.343729
            [silencedetect @ 0000019aa74aae80] silence_end: 1503.602771 | silence_duration: 2.259042
            [silencedetect @ 0000019aa74aae80] silence_start: 1507.558854=N/A speed=  28x
            [silencedetect @ 0000019aa74aae80] silence_end: 1509.596646 | silence_duration: 2.037792
            [silencedetect @ 0000019aa74aae80] silence_start: 1544.583479=N/A speed=  28x
            [silencedetect @ 0000019aa74aae80] silence_end: 1546.699896 | silence_duration: 2.116417
            [silencedetect @ 0000019aa74aae80] silence_start: 1555.659604
            [silencedetect @ 0000019aa74aae80] silence_end: 1559.458375 | silence_duration: 3.798771
            [silencedetect @ 0000019aa74aae80] silence_start: 1563.070875
            [silencedetect @ 0000019aa74aae80] silence_end: 1565.672875 | silence_duration: 2.602
            [silencedetect @ 0000019aa74aae80] silence_start: 1566.874312
            [silencedetect @ 0000019aa74aae80] silence_end: 1571.525333 | silence_duration: 4.651021
            [silencedetect @ 0000019aa74aae80] silence_start: 1577.728625=N/A speed=  28x
            [silencedetect @ 0000019aa74aae80] silence_end: 1580.023937 | silence_duration: 2.295313
            [silencedetect @ 0000019aa74aae80] silence_start: 1585.936937
            [silencedetect @ 0000019aa74aae80] silence_end: 1589.518854 | silence_duration: 3.581917
            [silencedetect @ 0000019aa74aae80] silence_start: 1592.8845te=N/A speed=  28x
            [silencedetect @ 0000019aa74aae80] silence_end: 1594.912646 | silence_duration: 2.028146
            [silencedetect @ 0000019aa74aae80] silence_start: 1598.746604
            [silencedetect @ 0000019aa74aae80] silence_end: 1601.659375 | silence_duration: 2.912771
            [silencedetect @ 0000019aa74aae80] silence_start: 1644.824708=N/A speed=  28x
            [silencedetect @ 0000019aa74aae80] silence_end: 1647.282438 | silence_duration: 2.457729
            [silencedetect @ 0000019aa74aae80] silence_start: 1695.343979e=N/A speed=  28x
            [silencedetect @ 0000019aa74aae80] silence_end: 1700.365042 | silence_duration: 5.021063
            [silencedetect @ 0000019aa74aae80] silence_start: 1717.660354e=N/A speed=  28x
            [silencedetect @ 0000019aa74aae80] silence_end: 1721.116542 | silence_duration: 3.456187
            [silencedetect @ 0000019aa74aae80] silence_start: 1736.443375e=N/A speed=  28x
            [silencedetect @ 0000019aa74aae80] silence_end: 1739.070062 | silence_duration: 2.626688
            [silencedetect @ 0000019aa74aae80] silence_start: 1765.307833e=N/A speed=  28x
            [silencedetect @ 0000019aa74aae80] silence_end: 1769.315354 | silence_duration: 4.007521
            [silencedetect @ 0000019aa74aae80] silence_start: 1788.443083e=N/A speed=  28x
            [silencedetect @ 0000019aa74aae80] silence_end: 1790.766208 | silence_duration: 2.323125
            [silencedetect @ 0000019aa74aae80] silence_start: 1819.744312e=N/A speed=  28x
            [silencedetect @ 0000019aa74aae80] silence_end: 1822.712958 | silence_duration: 2.968646
            [silencedetect @ 0000019aa74aae80] silence_start: 1829.128563
            [silencedetect @ 0000019aa74aae80] silence_end: 1833.295813 | silence_duration: 4.16725
            [silencedetect @ 0000019aa74aae80] silence_start: 1835.19625
            [silencedetect @ 0000019aa74aae80] silence_end: 1837.523688 | silence_duration: 2.327437
            [silencedetect @ 0000019aa74aae80] silence_start: 1848.376562e=N/A speed=27.9x
            [silencedetect @ 0000019aa74aae80] silence_end: 1853.458583 | silence_duration: 5.082021
            [silencedetect @ 0000019aa74aae80] silence_start: 1862.223562e=N/A speed=27.9x
            [silencedetect @ 0000019aa74aae80] silence_end: 1864.255 | silence_duration: 2.031438
            [silencedetect @ 0000019aa74aae80] silence_start: 1882.694604e=N/A speed=27.9x
            [silencedetect @ 0000019aa74aae80] silence_end: 1885.990146 | silence_duration: 3.295542
            [silencedetect @ 0000019aa74aae80] silence_start: 1890.175333e=N/A speed=27.9x
            [silencedetect @ 0000019aa74aae80] silence_end: 1893.554937 | silence_duration: 3.379604
            [silencedetect @ 0000019aa74aae80] silence_start: 1951.960417e=N/A speed=  28x
            [silencedetect @ 0000019aa74aae80] silence_end: 1955.287229 | silence_duration: 3.326812
            [silencedetect @ 0000019aa74aae80] silence_start: 1956.964583
            [silencedetect @ 0000019aa74aae80] silence_end: 1962.450708 | silence_duration: 5.486125
            [silencedetect @ 0000019aa74aae80] silence_start: 1991.974333e=N/A speed=  28x
            [silencedetect @ 0000019aa74aae80] silence_end: 1995.537729 | silence_duration: 3.563396
            [silencedetect @ 0000019aa74aae80] silence_start: 1996.639333
            [silencedetect @ 0000019aa74aae80] silence_end: 1999.244937 | silence_duration: 2.605604
            [silencedetect @ 0000019aa74aae80] silence_start: 2020.677396e=N/A speed=  28x
            [silencedetect @ 0000019aa74aae80] silence_end: 2024.185625 | silence_duration: 3.508229
            [silencedetect @ 0000019aa74aae80] silence_start: 2054.189917e=N/A speed=  28x
            [silencedetect @ 0000019aa74aae80] silence_end: 2056.344021 | silence_duration: 2.154104
            [silencedetect @ 0000019aa74aae80] silence_start: 2117.125583e=N/A speed=  28x
            [silencedetect @ 0000019aa74aae80] silence_end: 2119.567542 | silence_duration: 2.441958
            [silencedetect @ 0000019aa74aae80] silence_start: 2146.667521e=N/A speed=28.1x
            [silencedetect @ 0000019aa74aae80] silence_end: 2151.115521 | silence_duration: 4.448
            [silencedetect @ 0000019aa74aae80] silence_start: 2155.824896
            [silencedetect @ 0000019aa74aae80] silence_end: 2158.252896 | silence_duration: 2.428
            [silencedetect @ 0000019aa74aae80] silence_start: 2164.562979e=N/A speed=28.1x
            [silencedetect @ 0000019aa74aae80] silence_end: 2166.652375 | silence_duration: 2.089396
            [silencedetect @ 0000019aa74aae80] silence_start: 2170.897854
            [silencedetect @ 0000019aa74aae80] silence_end: 2175.01375 | silence_duration: 4.115896
            [silencedetect @ 0000019aa74aae80] silence_start: 2191.445104e=N/A speed=28.1x
            [silencedetect @ 0000019aa74aae80] silence_end: 2193.482792 | silence_duration: 2.037688
            [silencedetect @ 0000019aa74aae80] silence_start: 2219.259958e=N/A speed=28.1x
            [silencedetect @ 0000019aa74aae80] silence_end: 2221.902354 | silence_duration: 2.642396
            [silencedetect @ 0000019aa74aae80] silence_start: 2236.028729e=N/A speed=28.1x
            [silencedetect @ 0000019aa74aae80] silence_end: 2238.773229 | silence_duration: 2.7445
            [silencedetect @ 0000019aa74aae80] silence_start: 2265.42975te=N/A speed=28.1x
            [silencedetect @ 0000019aa74aae80] silence_end: 2267.538521 | silence_duration: 2.108771
            [silencedetect @ 0000019aa74aae80] silence_start: 2274.884229
            [silencedetect @ 0000019aa74aae80] silence_end: 2277.605917 | silence_duration: 2.721687
            [silencedetect @ 0000019aa74aae80] silence_start: 2291.573188e=N/A speed=28.1x
            [silencedetect @ 0000019aa74aae80] silence_end: 2296.192917 | silence_duration: 4.619729
            [silencedetect @ 0000019aa74aae80] silence_start: 2316.352833e=N/A speed=28.1x
            [silencedetect @ 0000019aa74aae80] silence_end: 2326.430042 | silence_duration: 10.077208
            [silencedetect @ 0000019aa74aae80] silence_start: 2445.904292e=N/A speed=28.1x
            [silencedetect @ 0000019aa74aae80] silence_end: 2450.505646 | silence_duration: 4.601354
            [silencedetect @ 0000019aa74aae80] silence_start: 2558.509187e=N/A speed=28.1x
            [silencedetect @ 0000019aa74aae80] silence_end: 2560.623479 | silence_duration: 2.114292
            [silencedetect @ 0000019aa74aae80] silence_start: 2597.699896e=N/A speed=28.2x
            [silencedetect @ 0000019aa74aae80] silence_end: 2599.746375 | silence_duration: 2.046479
            [silencedetect @ 0000019aa74aae80] silence_start: 2623.928875e=N/A speed=28.2x
            [silencedetect @ 0000019aa74aae80] silence_end: 2626.071729 | silence_duration: 2.142854
            [silencedetect @ 0000019aa74aae80] silence_start: 2663.003479e=N/A speed=28.2x
            [silencedetect @ 0000019aa74aae80] silence_end: 2665.535812 | silence_duration: 2.532333
            [silencedetect @ 0000019aa74aae80] silence_start: 2668.576167e=N/A speed=28.2x
            [silencedetect @ 0000019aa74aae80] silence_end: 2671.280625 | silence_duration: 2.704458
            [silencedetect @ 0000019aa74aae80] silence_start: 2688.962937e=N/A speed=28.2x
            [silencedetect @ 0000019aa74aae80] silence_end: 2692.042375 | silence_duration: 3.079438
            [silencedetect @ 0000019aa74aae80] silence_start: 2709.963375e=N/A speed=28.2x
            [silencedetect @ 0000019aa74aae80] silence_end: 2715.724917 | silence_duration: 5.761542
            [silencedetect @ 0000019aa74aae80] silence_start: 2731.088708e=N/A speed=28.2x
            [silencedetect @ 0000019aa74aae80] silence_end: 2735.744625 | silence_duration: 4.655917
            [silencedetect @ 0000019aa74aae80] silence_start: 2738.381812e=N/A speed=28.2x
            [silencedetect @ 0000019aa74aae80] silence_end: 2741.2525 | silence_duration: 2.870687
            [silencedetect @ 0000019aa74aae80] silence_start: 2767.659333e=N/A speed=28.2x
            [silencedetect @ 0000019aa74aae80] silence_end: 2770.313021 | silence_duration: 2.653687
            [silencedetect @ 0000019aa74aae80] silence_start: 2770.329271
            [silencedetect @ 0000019aa74aae80] silence_end: 2776.982479 | silence_duration: 6.653208
            [silencedetect @ 0000019aa74aae80] silence_start: 2790.915875e=N/A speed=28.2x
            [silencedetect @ 0000019aa74aae80] silence_end: 2793.42025 | silence_duration: 2.504375
            [silencedetect @ 0000019aa74aae80] silence_start: 2795.540833e=N/A speed=28.2x
            [silencedetect @ 0000019aa74aae80] silence_end: 2800.71375 | silence_duration: 5.172917
            [silencedetect @ 0000019aa74aae80] silence_start: 2822.708083e=N/A speed=28.2x
            [silencedetect @ 0000019aa74aae80] silence_end: 2825.349229 | silence_duration: 2.641146
            [silencedetect @ 0000019aa74aae80] silence_start: 2829.976354e=N/A speed=28.2x
            [silencedetect @ 0000019aa74aae80] silence_end: 2832.201625 | silence_duration: 2.225271
            [silencedetect @ 0000019aa74aae80] silence_start: 2836.568146
            [silencedetect @ 0000019aa74aae80] silence_end: 2840.193521 | silence_duration: 3.625375
            [silencedetect @ 0000019aa74aae80] silence_start: 2865.145312e=N/A speed=28.2x
            [silencedetect @ 0000019aa74aae80] silence_end: 2868.558583 | silence_duration: 3.413271
            [silencedetect @ 0000019aa74aae80] silence_start: 2906.354375e=N/A speed=28.1x
            [silencedetect @ 0000019aa74aae80] silence_end: 2908.906958 | silence_duration: 2.552583
            [silencedetect @ 0000019aa74aae80] silence_start: 2934.619021e=N/A speed=28.1x
            [silencedetect @ 0000019aa74aae80] silence_end: 2937.809146 | silence_duration: 3.190125
            [silencedetect @ 0000019aa74aae80] silence_start: 2938.419708
            [silencedetect @ 0000019aa74aae80] silence_end: 2940.955312 | silence_duration: 2.535604
            [silencedetect @ 0000019aa74aae80] silence_start: 2950.315417e=N/A speed=  28x
            [silencedetect @ 0000019aa74aae80] silence_end: 2954.155167 | silence_duration: 3.83975
            [silencedetect @ 0000019aa74aae80] silence_start: 2955.183542
            [silencedetect @ 0000019aa74aae80] silence_end: 2957.434458 | silence_duration: 2.250917
            [silencedetect @ 0000019aa74aae80] silence_start: 2990.884542e=N/A speed=  28x
            [silencedetect @ 0000019aa74aae80] silence_end: 2994.1155 | silence_duration: 3.230958
            [silencedetect @ 0000019aa74aae80] silence_start: 3316.628896e=N/A speed=27.6x
            [silencedetect @ 0000019aa74aae80] silence_end: 3319.542125 | silence_duration: 2.913229
            [silencedetect @ 0000019aa74aae80] silence_start: 3981.581167e=N/A speed=27.2x
            [silencedetect @ 0000019aa74aae80] silence_end: 3985.639312 | silence_duration: 4.058146
            [silencedetect @ 0000019aa74aae80] silence_start: 4245.1425ate=N/A speed=27.1x
            [silencedetect @ 0000019aa74aae80] silence_end: 4247.185042 | silence_duration: 2.042542
            [silencedetect @ 0000019aa74aae80] silence_start: 4254.856125e=N/A speed=27.1x
            [silencedetect @ 0000019aa74aae80] silence_end: 4259.007458 | silence_duration: 4.151333
            [silencedetect @ 0000019aa74aae80] silence_start: 4517.768625e=N/A speed=27.2x
            [silencedetect @ 0000019aa74aae80] silence_end: 4519.818104 | silence_duration: 2.049479
            [silencedetect @ 0000019aa74aae80] silence_start: 4521.862021e=N/A speed=27.2x
            [silencedetect @ 0000019aa74aae80] silence_end: 4524.419937 | silence_duration: 2.557917
            [silencedetect @ 0000019aa74aae80] silence_start: 4571.223396e=N/A speed=27.1x
            [silencedetect @ 0000019aa74aae80] silence_end: 4573.620187 | silence_duration: 2.396792
            [silencedetect @ 0000019aa74aae80] silence_start: 4705.630562e=N/A speed=  27x
            [silencedetect @ 0000019aa74aae80] silence_end: 4709.167354 | silence_duration: 3.536792
            [silencedetect @ 0000019aa74aae80] silence_start: 4750.112562e=N/A speed=  27x
            [silencedetect @ 0000019aa74aae80] silence_end: 4753.540562 | silence_duration: 3.428
            [silencedetect @ 0000019aa74aae80] silence_start: 4909.711104e=N/A speed=26.9x
            [silencedetect @ 0000019aa74aae80] silence_end: 4912.090396 | silence_duration: 2.379292
            [silencedetect @ 0000019aa74aae80] silence_start: 4912.295938e=N/A speed=26.9x
            [silencedetect @ 0000019aa74aae80] silence_end: 4932.9115 | silence_duration: 20.615562
            [silencedetect @ 0000019aa74aae80] silence_start: 4934.022833
            [silencedetect @ 0000019aa74aae80] silence_end: 4938.620854 | silence_duration: 4.598021
            [silencedetect @ 0000019aa74aae80] silence_start: 5157.759958e=N/A speed=26.3x
            [silencedetect @ 0000019aa74aae80] silence_end: 5163.002396 | silence_duration: 5.242437
            [silencedetect @ 0000019aa74aae80] silence_start: 5183.359125e=N/A speed=26.2x
            [silencedetect @ 0000019aa74aae80] silence_end: 5185.687542 | silence_duration: 2.328417
            [silencedetect @ 0000019aa74aae80] silence_start: 5198.625229e=N/A speed=26.2x
            [silencedetect @ 0000019aa74aae80] silence_end: 5200.6755 | silence_duration: 2.050271
            [silencedetect @ 0000019aa74aae80] silence_start: 5238.728833e=N/A speed=26.1x
            [silencedetect @ 0000019aa74aae80] silence_end: 5241.686792 | silence_duration: 2.957958
            [silencedetect @ 0000019aa74aae80] silence_start: 5282.808417e=N/A speed=26.1x
            [silencedetect @ 0000019aa74aae80] silence_end: 5285.633437 | silence_duration: 2.825021
            [silencedetect @ 0000019aa74aae80] silence_start: 5310.252521e=N/A speed=26.1x
            [silencedetect @ 0000019aa74aae80] silence_end: 5313.51275 | silence_duration: 3.260229
            [silencedetect @ 0000019aa74aae80] silence_start: 5330.426687e=N/A speed=26.1x
            [silencedetect @ 0000019aa74aae80] silence_end: 5333.976729 | silence_duration: 3.550042
            [silencedetect @ 0000019aa74aae80] silence_start: 5336.305625
            [silencedetect @ 0000019aa74aae80] silence_end: 5338.688437 | silence_duration: 2.382812
            [silencedetect @ 0000019aa74aae80] silence_start: 5391.783062e=N/A speed=  26x
            [silencedetect @ 0000019aa74aae80] silence_end: 5394.770312 | silence_duration: 2.98725
            [silencedetect @ 0000019aa74aae80] silence_start: 5402.027979e=N/A speed=  26x
            [silencedetect @ 0000019aa74aae80] silence_end: 5404.204021 | silence_duration: 2.176042
            [silencedetect @ 0000019aa74aae80] silence_start: 5427.384417e=N/A speed=  26x
            [silencedetect @ 0000019aa74aae80] silence_end: 5431.015 | silence_duration: 3.630583
            [silencedetect @ 0000019aa74aae80] silence_start: 5444.117688e=N/A speed=  26x
            [silencedetect @ 0000019aa74aae80] silence_end: 5448.065396 | silence_duration: 3.947708
            [silencedetect @ 0000019aa74aae80] silence_start: 5456.34475te=N/A speed=26.1x
            [silencedetect @ 0000019aa74aae80] silence_end: 5460.595479 | silence_duration: 4.250729
            [silencedetect @ 0000019aa74aae80] silence_start: 5463.452562e=N/A speed=26.1x
            [silencedetect @ 0000019aa74aae80] silence_end: 5468.970396 | silence_duration: 5.517833
            [silencedetect @ 0000019aa74aae80] silence_start: 5476.145875
            [silencedetect @ 0000019aa74aae80] silence_end: 5479.973937 | silence_duration: 3.828062
            [silencedetect @ 0000019aa74aae80] silence_start: 5503.055812e=N/A speed=26.1x
            [silencedetect @ 0000019aa74aae80] silence_end: 5508.840458 | silence_duration: 5.784646
            [silencedetect @ 0000019aa74aae80] silence_start: 5512.084646
            [silencedetect @ 0000019aa74aae80] silence_end: 5515.193875 | silence_duration: 3.109229
            [silencedetect @ 0000019aa74aae80] silence_start: 5520.089729e=N/A speed=26.1x
            [silencedetect @ 0000019aa74aae80] silence_end: 5522.673437 | silence_duration: 2.583708
            [silencedetect @ 0000019aa74aae80] silence_start: 5529.584437
            [silencedetect @ 0000019aa74aae80] silence_end: 5532.472646 | silence_duration: 2.888208
            [silencedetect @ 0000019aa74aae80] silence_start: 5567.158687e=N/A speed=  26x
            [silencedetect @ 0000019aa74aae80] silence_end: 5569.271542 | silence_duration: 2.112854
            [silencedetect @ 0000019aa74aae80] silence_start: 5593.473292e=N/A speed=  26x
            [silencedetect @ 0000019aa74aae80] silence_end: 5595.839812 | silence_duration: 2.366521
            [silencedetect @ 0000019aa74aae80] silence_start: 5603.592333e=N/A speed=  26x
            [silencedetect @ 0000019aa74aae80] silence_end: 5605.911062 | silence_duration: 2.318729
            [silencedetect @ 0000019aa74aae80] silence_start: 5657.437979e=N/A speed=  26x
            [silencedetect @ 0000019aa74aae80] silence_end: 5665.082792 | silence_duration: 7.644812
            [silencedetect @ 0000019aa74aae80] silence_start: 5667.417458
            [silencedetect @ 0000019aa74aae80] silence_end: 5676.442208 | silence_duration: 9.02475
            [silencedetect @ 0000019aa74aae80] silence_start: 5679.146917
            [silencedetect @ 0000019aa74aae80] silence_end: 5684.949729 | silence_duration: 5.802812
            [silencedetect @ 0000019aa74aae80] silence_start: 5688.533188e=N/A speed=  26x
            [silencedetect @ 0000019aa74aae80] silence_end: 5691.944687 | silence_duration: 3.4115
            [silencedetect @ 0000019aa74aae80] silence_start: 5703.873167e=N/A speed=25.9x
            [silencedetect @ 0000019aa74aae80] silence_end: 5708.661875 | silence_duration: 4.788708
            [silencedetect @ 0000019aa74aae80] silence_start: 5737.757187e=N/A speed=25.8x
            [silencedetect @ 0000019aa74aae80] silence_end: 5740.967854 | silence_duration: 3.210667
            [silencedetect @ 0000019aa74aae80] silence_start: 5744.643229
            [silencedetect @ 0000019aa74aae80] silence_end: 5747.729875 | silence_duration: 3.086646
            [silencedetect @ 0000019aa74aae80] silence_start: 5754.902437
            [silencedetect @ 0000019aa74aae80] silence_end: 5758.740833 | silence_duration: 3.838396
            [silencedetect @ 0000019aa74aae80] silence_start: 5765.683229
            [silencedetect @ 0000019aa74aae80] silence_end: 5768.086708 | silence_duration: 2.403479
            [silencedetect @ 0000019aa74aae80] silence_start: 5769.532354e=N/A speed=25.7x
            [silencedetect @ 0000019aa74aae80] silence_end: 5771.879875 | silence_duration: 2.347521
            [silencedetect @ 0000019aa74aae80] silence_start: 5783.65225te=N/A speed=25.7x
            [silencedetect @ 0000019aa74aae80] silence_end: 5786.928146 | silence_duration: 3.275896
            [silencedetect @ 0000019aa74aae80] silence_start: 5794.104167e=N/A speed=25.7x
            [silencedetect @ 0000019aa74aae80] silence_end: 5802.793437 | silence_duration: 8.689271
            [silencedetect @ 0000019aa74aae80] silence_start: 5818.591062e=N/A speed=25.7x
            [silencedetect @ 0000019aa74aae80] silence_end: 5827.704854 | silence_duration: 9.113792
            [silencedetect @ 0000019aa74aae80] silence_start: 5838.143875e=N/A speed=25.7x
            [silencedetect @ 0000019aa74aae80] silence_end: 5840.512937 | silence_duration: 2.369063
            [silencedetect @ 0000019aa74aae80] silence_start: 5841.092333
            [silencedetect @ 0000019aa74aae80] silence_end: 5843.156937 | silence_duration: 2.064604
            [silencedetect @ 0000019aa74aae80] silence_start: 5843.902667
            [silencedetect @ 0000019aa74aae80] silence_end: 5846.624167 | silence_duration: 2.7215
            [silencedetect @ 0000019aa74aae80] silence_start: 5847.491312
            [silencedetect @ 0000019aa74aae80] silence_end: 5850.416375 | silence_duration: 2.925063
            [silencedetect @ 0000019aa74aae80] silence_start: 5877.389708e=N/A speed=25.7x
            [silencedetect @ 0000019aa74aae80] silence_end: 5879.512583 | silence_duration: 2.122875
            [silencedetect @ 0000019aa74aae80] silence_start: 5879.985875
            [silencedetect @ 0000019aa74aae80] silence_end: 5882.379063 | silence_duration: 2.393187
            [silencedetect @ 0000019aa74aae80] silence_start: 5896.837333e=N/A speed=25.7x
            [silencedetect @ 0000019aa74aae80] silence_end: 5899.0895 | silence_duration: 2.252167
            [silencedetect @ 0000019aa74aae80] silence_start: 5916.808875e=N/A speed=25.7x
            [silencedetect @ 0000019aa74aae80] silence_end: 5920.446417 | silence_duration: 3.637542
            [silencedetect @ 0000019aa74aae80] silence_start: 5920.878896
            [silencedetect @ 0000019aa74aae80] silence_end: 5925.187458 | silence_duration: 4.308562
            [silencedetect @ 0000019aa74aae80] silence_start: 5934.071792e=N/A speed=25.7x
            [silencedetect @ 0000019aa74aae80] silence_end: 6211.174354 | silence_duration: 277.102562
            [silencedetect @ 0000019aa74aae80] silence_start: 6264.595604e=N/A speed=25.8x
            [silencedetect @ 0000019aa74aae80] silence_end: 6266.702833 | silence_duration: 2.107229
            [silencedetect @ 0000019aa74aae80] silence_start: 6385.408521e=N/A speed=25.8x
            [silencedetect @ 0000019aa74aae80] silence_end: 6387.540375 | silence_duration: 2.131854
            [silencedetect @ 0000019aa74aae80] silence_start: 6441.091292e=N/A speed=25.8x
            [silencedetect @ 0000019aa74aae80] silence_end: 6444.269917 | silence_duration: 3.178625
            [silencedetect @ 0000019aa74aae80] silence_start: 6507.443646e=N/A speed=25.9x
            [silencedetect @ 0000019aa74aae80] silence_end: 6509.974917 | silence_duration: 2.531271
            [silencedetect @ 0000019aa74aae80] silence_start: 6566.719208e=N/A speed=25.9x
            [silencedetect @ 0000019aa74aae80] silence_end: 6570.225604 | silence_duration: 3.506396
            [silencedetect @ 0000019aa74aae80] silence_start: 6582.868667e=N/A speed=25.9x
            [silencedetect @ 0000019aa74aae80] silence_end: 6586.395062 | silence_duration: 3.526396
            [silencedetect @ 0000019aa74aae80] silence_start: 6620.669417e=N/A speed=25.9x
            [silencedetect @ 0000019aa74aae80] silence_end: 6623.807458 | silence_duration: 3.138042
            [silencedetect @ 0000019aa74aae80] silence_start: 6628.031562e=N/A speed=25.9x
            [silencedetect @ 0000019aa74aae80] silence_end: 6633.433667 | silence_duration: 5.402104
            [silencedetect @ 0000019aa74aae80] silence_start: 6646.513896e=N/A speed=25.9x
            [silencedetect @ 0000019aa74aae80] silence_end: 6651.011292 | silence_duration: 4.497396
            [silencedetect @ 0000019aa74aae80] silence_start: 6658.461833e=N/A speed=25.9x
            [silencedetect @ 0000019aa74aae80] silence_end: 6668.491271 | silence_duration: 10.029438
            [silencedetect @ 0000019aa74aae80] silence_start: 6676.833417e=N/A speed=25.9x
            [silencedetect @ 0000019aa74aae80] silence_end: 6681.397396 | silence_duration: 4.563979
            [silencedetect @ 0000019aa74aae80] silence_start: 6723.698687e=N/A speed=25.9x
            [silencedetect @ 0000019aa74aae80] silence_end: 6725.707167 | silence_duration: 2.008479
            [silencedetect @ 0000019aa74aae80] silence_start: 6727.390771e=N/A speed=25.9x
            [silencedetect @ 0000019aa74aae80] silence_end: 6730.243646 | silence_duration: 2.852875
            [silencedetect @ 0000019aa74aae80] silence_start: 6735.807646
            [silencedetect @ 0000019aa74aae80] silence_end: 6742.823292 | silence_duration: 7.015646
            [silencedetect @ 0000019aa74aae80] silence_start: 6745.155604
            [silencedetect @ 0000019aa74aae80] silence_end: 6748.970125 | silence_duration: 3.814521
            [silencedetect @ 0000019aa74aae80] silence_start: 6767.313854e=N/A speed=25.9x
            [silencedetect @ 0000019aa74aae80] silence_end: 6770.91 | silence_duration: 3.596146
            [silencedetect @ 0000019aa74aae80] silence_start: 6841.557813e=N/A speed=  26x
            [silencedetect @ 0000019aa74aae80] silence_end: 6844.669667 | silence_duration: 3.111854
            [silencedetect @ 0000019aa74aae80] silence_start: 6911.224083e=N/A speed=  26x
            [silencedetect @ 0000019aa74aae80] silence_end: 6914.063292 | silence_duration: 2.839208
            [silencedetect @ 0000019aa74aae80] silence_start: 6920.103396
            [silencedetect @ 0000019aa74aae80] silence_end: 6922.654021 | silence_duration: 2.550625
            [silencedetect @ 0000019aa74aae80] silence_start: 6938.638208e=N/A speed=  26x
            [silencedetect @ 0000019aa74aae80] silence_end: 6942.710875 | silence_duration: 4.072667
            [silencedetect @ 0000019aa74aae80] silence_start: 6945.744833
            [silencedetect @ 0000019aa74aae80] silence_end: 6949.456729 | silence_duration: 3.711896
            [silencedetect @ 0000019aa74aae80] silence_start: 6950.671438
            [silencedetect @ 0000019aa74aae80] silence_end: 6955.590583 | silence_duration: 4.919146
            [silencedetect @ 0000019aa74aae80] silence_start: 6958.173771
            [silencedetect @ 0000019aa74aae80] silence_end: 6961.04675 | silence_duration: 2.872979
            [silencedetect @ 0000019aa74aae80] silence_start: 6964.599104
            [silencedetect @ 0000019aa74aae80] silence_end: 6966.758979 | silence_duration: 2.159875
            [silencedetect @ 0000019aa74aae80] silence_start: 6978.353417e=N/A speed=  26x
            [silencedetect @ 0000019aa74aae80] silence_end: 6981.092125 | silence_duration: 2.738708
            [silencedetect @ 0000019aa74aae80] silence_start: 6988.936792e=N/A speed=  26x
            [silencedetect @ 0000019aa74aae80] silence_end: 6991.944187 | silence_duration: 3.007396
            [silencedetect @ 0000019aa74aae80] silence_start: 7000.366917e=N/A speed=26.1x
            [silencedetect @ 0000019aa74aae80] silence_end: 7002.847646 | silence_duration: 2.480729
            [silencedetect @ 0000019aa74aae80] silence_start: 7044.555479e=N/A speed=26.1x
            [silencedetect @ 0000019aa74aae80] silence_end: 7050.399021 | silence_duration: 5.843542
            [silencedetect @ 0000019aa74aae80] silence_start: 7138.419833e=N/A speed=26.1x
            [silencedetect @ 0000019aa74aae80] silence_end: 7140.64875 | silence_duration: 2.228917
            [silencedetect @ 0000019aa74aae80] silence_start: 7169.482rate=N/A speed=26.1x
            [silencedetect @ 0000019aa74aae80] silence_end: 7171.968812 | silence_duration: 2.486813
            [silencedetect @ 0000019aa74aae80] silence_start: 7182.826521e=N/A speed=26.1x
            [silencedetect @ 0000019aa74aae80] silence_end: 7186.848708 | silence_duration: 4.022188
            [silencedetect @ 0000019aa74aae80] silence_start: 7193.929479
            [silencedetect @ 0000019aa74aae80] silence_end: 7195.948062 | silence_duration: 2.018583
            [silencedetect @ 0000019aa74aae80] silence_start: 7199.533208e=N/A speed=26.1x
            [silencedetect @ 0000019aa74aae80] silence_end: 7202.629646 | silence_duration: 3.096437
            [silencedetect @ 0000019aa74aae80] silence_start: 7208.568438
            [silencedetect @ 0000019aa74aae80] silence_end: 7210.733896 | silence_duration: 2.165458
            [silencedetect @ 0000019aa74aae80] silence_start: 7223.295458e=N/A speed=26.1x
            [silencedetect @ 0000019aa74aae80] silence_end: 7226.678063 | silence_duration: 3.382604
            [silencedetect @ 0000019aa74aae80] silence_start: 7241.712rate=N/A speed=26.1x
            [silencedetect @ 0000019aa74aae80] silence_end: 7243.793917 | silence_duration: 2.081917
            [silencedetect @ 0000019aa74aae80] silence_start: 7312.428375e=N/A speed=26.1x
            [silencedetect @ 0000019aa74aae80] silence_end: 7314.886687 | silence_duration: 2.458312
            [silencedetect @ 0000019aa74aae80] silence_start: 7387.346812e=N/A speed=26.1x
            [silencedetect @ 0000019aa74aae80] silence_end: 7390.404229 | silence_duration: 3.057417
            [silencedetect @ 0000019aa74aae80] silence_start: 7417.610625e=N/A speed=26.1x
            [silencedetect @ 0000019aa74aae80] silence_end: 7419.969104 | silence_duration: 2.358479
            [silencedetect @ 0000019aa74aae80] silence_start: 7420.225583
            [silencedetect @ 0000019aa74aae80] silence_end: 7422.925708 | silence_duration: 2.700125
            [silencedetect @ 0000019aa74aae80] silence_start: 7488.091854e=N/A speed=26.1x
            [silencedetect @ 0000019aa74aae80] silence_end: 7490.092875 | silence_duration: 2.001021
            [silencedetect @ 0000019aa74aae80] silence_start: 7527.817396e=N/A speed=26.2x
            [silencedetect @ 0000019aa74aae80] silence_end: 7530.425438 | silence_duration: 2.608042
            [silencedetect @ 0000019aa74aae80] silence_start: 7560.712458e=N/A speed=26.2x
            [silencedetect @ 0000019aa74aae80] silence_end: 7562.864667 | silence_duration: 2.152208
            [silencedetect @ 0000019aa74aae80] silence_start: 7621.047271e=N/A speed=26.2x
            [silencedetect @ 0000019aa74aae80] silence_end: 7623.299687 | silence_duration: 2.252417
            [silencedetect @ 0000019aa74aae80] silence_start: 7654.604271e=N/A speed=26.3x
            [silencedetect @ 0000019aa74aae80] silence_end: 7659.004542 | silence_duration: 4.400271
            [silencedetect @ 0000019aa74aae80] silence_start: 7696.861042e=N/A speed=26.3x
            [silencedetect @ 0000019aa74aae80] silence_end: 7699.251396 | silence_duration: 2.390354
            [silencedetect @ 0000019aa74aae80] silence_start: 7738.952146e=N/A speed=26.3x
            [silencedetect @ 0000019aa74aae80] silence_end: 7741.153146 | silence_duration: 2.201
            [silencedetect @ 0000019aa74aae80] silence_start: 7761.688396e=N/A speed=26.3x
            [silencedetect @ 0000019aa74aae80] silence_end: 7766.070208 | silence_duration: 4.381812
            [silencedetect @ 0000019aa74aae80] silence_start: 7766.3235
            [silencedetect @ 0000019aa74aae80] silence_end: 7771.707521 | silence_duration: 5.384021
            [silencedetect @ 0000019aa74aae80] silence_start: 7773.374563e=N/A speed=26.3x
            [silencedetect @ 0000019aa74aae80] silence_end: 7775.695229 | silence_duration: 2.320667
            [silencedetect @ 0000019aa74aae80] silence_start: 7828.918854e=N/A speed=26.3x
            [silencedetect @ 0000019aa74aae80] silence_end: 7831.385938 | silence_duration: 2.467083
            [silencedetect @ 0000019aa74aae80] silence_start: 7836.837
            [silencedetect @ 0000019aa74aae80] silence_end: 7838.965208 | silence_duration: 2.128208
            [silencedetect @ 0000019aa74aae80] silence_start: 7843.932271e=N/A speed=26.3x
            [silencedetect @ 0000019aa74aae80] silence_end: 7846.049375 | silence_duration: 2.117104
            [silencedetect @ 0000019aa74aae80] silence_start: 7852.154771
            [silencedetect @ 0000019aa74aae80] silence_end: 7856.439729 | silence_duration: 4.284958
            [silencedetect @ 0000019aa74aae80] silence_start: 7860.889271e=N/A speed=26.3x
            [silencedetect @ 0000019aa74aae80] silence_end: 7864.215187 | silence_duration: 3.325917
            [silencedetect @ 0000019aa74aae80] silence_start: 7898.212417e=N/A speed=26.3x
            [silencedetect @ 0000019aa74aae80] silence_end: 7900.307521 | silence_duration: 2.095104
            [silencedetect @ 0000019aa74aae80] silence_start: 7902.777708e=N/A speed=26.3x
            [silencedetect @ 0000019aa74aae80] silence_end: 7905.696521 | silence_duration: 2.918813
            [silencedetect @ 0000019aa74aae80] silence_start: 7923.909042e=N/A speed=26.3x
            [silencedetect @ 0000019aa74aae80] silence_end: 7925.933458 | silence_duration: 2.024417
            [silencedetect @ 0000019aa74aae80] silence_start: 7942.708417e=N/A speed=26.3x
            [silencedetect @ 0000019aa74aae80] silence_end: 7946.642063 | silence_duration: 3.933646
            [silencedetect @ 0000019aa74aae80] silence_start: 7951.449917e=N/A speed=26.3x
            [silencedetect @ 0000019aa74aae80] silence_end: 7954.358812 | silence_duration: 2.908896
            [silencedetect @ 0000019aa74aae80] silence_start: 7954.455687
            [silencedetect @ 0000019aa74aae80] silence_end: 7961.703875 | silence_duration: 7.248187
            [silencedetect @ 0000019aa74aae80] silence_start: 7965.740063e=N/A speed=26.3x
            [silencedetect @ 0000019aa74aae80] silence_end: 7969.586854 | silence_duration: 3.846792
            [silencedetect @ 0000019aa74aae80] silence_start: 7978.325479e=N/A speed=26.3x
            [silencedetect @ 0000019aa74aae80] silence_end: 7980.417167 | silence_duration: 2.091687
            [silencedetect @ 0000019aa74aae80] silence_start: 7995.429375e=N/A speed=26.3x
            [silencedetect @ 0000019aa74aae80] silence_end: 7998.810729 | silence_duration: 3.381354
            [silencedetect @ 0000019aa74aae80] silence_start: 8004.836542e=N/A speed=26.3x
            [silencedetect @ 0000019aa74aae80] silence_end: 8007.346021 | silence_duration: 2.509479
            [silencedetect @ 0000019aa74aae80] silence_start: 8022.971458e=N/A speed=26.4x
            [silencedetect @ 0000019aa74aae80] silence_end: 8026.978062 | silence_duration: 4.006604
            [silencedetect @ 0000019aa74aae80] silence_start: 8028.291417
            [silencedetect @ 0000019aa74aae80] silence_end: 8030.454437 | silence_duration: 2.163021
            [silencedetect @ 0000019aa74aae80] silence_start: 8039.405375e=N/A speed=26.4x
            [silencedetect @ 0000019aa74aae80] silence_end: 8042.718958 | silence_duration: 3.313583
            [silencedetect @ 0000019aa74aae80] silence_start: 8079.332021e=N/A speed=26.4x
            [silencedetect @ 0000019aa74aae80] silence_end: 8084.580104 | silence_duration: 5.248083
            [silencedetect @ 0000019aa74aae80] silence_start: 8099.088458e=N/A speed=26.4x
            [silencedetect @ 0000019aa74aae80] silence_end: 8101.953146 | silence_duration: 2.864688
            [silencedetect @ 0000019aa74aae80] silence_start: 8104.148146
            [silencedetect @ 0000019aa74aae80] silence_end: 8107.571667 | silence_duration: 3.423521
            [silencedetect @ 0000019aa74aae80] silence_start: 8116.5875ate=N/A speed=26.4x
            [silencedetect @ 0000019aa74aae80] silence_end: 8118.810208 | silence_duration: 2.222708
            [silencedetect @ 0000019aa74aae80] silence_start: 8168.439792e=N/A speed=26.4x
            [silencedetect @ 0000019aa74aae80] silence_end: 8173.101521 | silence_duration: 4.661729
            [silencedetect @ 0000019aa74aae80] silence_start: 8186.415292e=N/A speed=26.4x
            [silencedetect @ 0000019aa74aae80] silence_end: 8191.722979 | silence_duration: 5.307688
            [silencedetect @ 0000019aa74aae80] silence_start: 8201.334167e=N/A speed=26.4x
            [silencedetect @ 0000019aa74aae80] silence_end: 8207.077479 | silence_duration: 5.743313
            [silencedetect @ 0000019aa74aae80] silence_start: 8212.914563e=N/A speed=26.4x
            [silencedetect @ 0000019aa74aae80] silence_end: 8219.127 | silence_duration: 6.212438
            [silencedetect @ 0000019aa74aae80] silence_start: 8246.023208e=N/A speed=26.4x
            [silencedetect @ 0000019aa74aae80] silence_end: 8248.264708 | silence_duration: 2.2415
            [silencedetect @ 0000019aa74aae80] silence_start: 8261.579375e=N/A speed=26.4x
            [silencedetect @ 0000019aa74aae80] silence_end: 8266.987083 | silence_duration: 5.407708
            [silencedetect @ 0000019aa74aae80] silence_start: 8284.644021e=N/A speed=26.4x
            [silencedetect @ 0000019aa74aae80] silence_end: 8290.297479 | silence_duration: 5.653458
            [silencedetect @ 0000019aa74aae80] silence_start: 8291.621812e=N/A speed=26.4x
            [silencedetect @ 0000019aa74aae80] silence_end: 8294.928021 | silence_duration: 3.306208
            [silencedetect @ 0000019aa74aae80] silence_start: 8296.88625
            [silencedetect @ 0000019aa74aae80] silence_end: 8299.157896 | silence_duration: 2.271646
            [silencedetect @ 0000019aa74aae80] silence_start: 8303.500208e=N/A speed=26.4x
            [silencedetect @ 0000019aa74aae80] silence_end: 8308.656146 | silence_duration: 5.155937
            [silencedetect @ 0000019aa74aae80] silence_start: 8331.732042e=N/A speed=26.4x
            [silencedetect @ 0000019aa74aae80] silence_end: 8336.545875 | silence_duration: 4.813833
            [silencedetect @ 0000019aa74aae80] silence_start: 8343.092667
            [silencedetect @ 0000019aa74aae80] silence_end: 8346.88375 | silence_duration: 3.791083
            [silencedetect @ 0000019aa74aae80] silence_start: 8373.18475te=N/A speed=26.4x
            [silencedetect @ 0000019aa74aae80] silence_end: 8376.239687 | silence_duration: 3.054937
            [silencedetect @ 0000019aa74aae80] silence_start: 8380.374083e=N/A speed=26.4x
            [silencedetect @ 0000019aa74aae80] silence_end: 8383.396729 | silence_duration: 3.022646
            [silencedetect @ 0000019aa74aae80] silence_start: 8384.638271
            [silencedetect @ 0000019aa74aae80] silence_end: 8387.009062 | silence_duration: 2.370792
            [silencedetect @ 0000019aa74aae80] silence_start: 8403.423229e=N/A speed=26.5x
            [silencedetect @ 0000019aa74aae80] silence_end: 8406.538979 | silence_duration: 3.11575
            [silencedetect @ 0000019aa74aae80] silence_start: 8448.950583e=N/A speed=26.5x
            [silencedetect @ 0000019aa74aae80] silence_end: 8451.392021 | silence_duration: 2.441437
            [silencedetect @ 0000019aa74aae80] silence_start: 8471.912083e=N/A speed=26.5x
            [silencedetect @ 0000019aa74aae80] silence_end: 8476.48825 | silence_duration: 4.576167
            [silencedetect @ 0000019aa74aae80] silence_start: 8476.872812
            [silencedetect @ 0000019aa74aae80] silence_end: 8479.31075 | silence_duration: 2.437937
            [silencedetect @ 0000019aa74aae80] silence_start: 8480.168187
            [silencedetect @ 0000019aa74aae80] silence_end: 8485.084063 | silence_duration: 4.915875
            [silencedetect @ 0000019aa74aae80] silence_start: 8491.916312
            [silencedetect @ 0000019aa74aae80] silence_end: 8500.066958 | silence_duration: 8.150646
            [silencedetect @ 0000019aa74aae80] silence_start: 8504.486021
            [silencedetect @ 0000019aa74aae80] silence_end: 8506.989208 | silence_duration: 2.503188
            [silencedetect @ 0000019aa74aae80] silence_start: 8514.830479e=N/A speed=26.5x
            [silencedetect @ 0000019aa74aae80] silence_end: 8517.1405 | silence_duration: 2.310021
            [silencedetect @ 0000019aa74aae80] silence_start: 8519.588167
            [silencedetect @ 0000019aa74aae80] silence_end: 8521.820792 | silence_duration: 2.232625
            [silencedetect @ 0000019aa74aae80] silence_start: 8523.306104
            [silencedetect @ 0000019aa74aae80] silence_end: 8533.473729 | silence_duration: 10.167625
            [silencedetect @ 0000019aa74aae80] silence_start: 8534.459958
            [silencedetect @ 0000019aa74aae80] silence_end: 8539.094208 | silence_duration: 4.63425
            [silencedetect @ 0000019aa74aae80] silence_start: 8556.270542e=N/A speed=26.5x
            [silencedetect @ 0000019aa74aae80] silence_end: 8558.563625 | silence_duration: 2.293083
            [silencedetect @ 0000019aa74aae80] silence_start: 8589.577646e=N/A speed=26.5x
            [silencedetect @ 0000019aa74aae80] silence_end: 8594.138583 | silence_duration: 4.560937
            [silencedetect @ 0000019aa74aae80] silence_start: 8616.192812e=N/A speed=26.5x
            [silencedetect @ 0000019aa74aae80] silence_end: 8618.599375 | silence_duration: 2.406562
            [silencedetect @ 0000019aa74aae80] silence_start: 8621.475271
            [silencedetect @ 0000019aa74aae80] silence_end: 8625.082417 | silence_duration: 3.607146
            [silencedetect @ 0000019aa74aae80] silence_start: 8638.640625e=N/A speed=26.5x
            [silencedetect @ 0000019aa74aae80] silence_end: 8641.681708 | silence_duration: 3.041083
            [silencedetect @ 0000019aa74aae80] silence_start: 8675.458479e=N/A speed=26.5x
            [silencedetect @ 0000019aa74aae80] silence_end: 8680.026313 | silence_duration: 4.567833
            [silencedetect @ 0000019aa74aae80] silence_start: 8683.700771e=N/A speed=26.5x
            [silencedetect @ 0000019aa74aae80] silence_end: 8687.932125 | silence_duration: 4.231354
            [silencedetect @ 0000019aa74aae80] silence_start: 8691.210667
            [silencedetect @ 0000019aa74aae80] silence_end: 8698.4555 | silence_duration: 7.244833
            [silencedetect @ 0000019aa74aae80] silence_start: 8717.608833e=N/A speed=26.5x
            [silencedetect @ 0000019aa74aae80] silence_end: 8723.313521 | silence_duration: 5.704687
            [silencedetect @ 0000019aa74aae80] silence_start: 8754.497854e=N/A speed=26.5x
            [silencedetect @ 0000019aa74aae80] silence_end: 8756.659479 | silence_duration: 2.161625
            [silencedetect @ 0000019aa74aae80] silence_start: 8784.664729e=N/A speed=26.5x
            [silencedetect @ 0000019aa74aae80] silence_end: 8788.260708 | silence_duration: 3.595979
            [silencedetect @ 0000019aa74aae80] silence_start: 8816.072958e=N/A speed=26.5x
            [silencedetect @ 0000019aa74aae80] silence_end: 8818.22875 | silence_duration: 2.155792
            [silencedetect @ 0000019aa74aae80] silence_start: 8830.841042e=N/A speed=26.5x
            [silencedetect @ 0000019aa74aae80] silence_end: 8834.693333 | silence_duration: 3.852292
            [silencedetect @ 0000019aa74aae80] silence_start: 8835.946021e=N/A speed=26.5x
            [silencedetect @ 0000019aa74aae80] silence_end: 8845.615792 | silence_duration: 9.669771
            [silencedetect @ 0000019aa74aae80] silence_start: 8856.416333e=N/A speed=26.5x
            [silencedetect @ 0000019aa74aae80] silence_end: 8858.785375 | silence_duration: 2.369042
            [silencedetect @ 0000019aa74aae80] silence_start: 8871.233917e=N/A speed=26.5x
            [silencedetect @ 0000019aa74aae80] silence_end: 8878.592208 | silence_duration: 7.358292
            [silencedetect @ 0000019aa74aae80] silence_start: 8882.752562e=N/A speed=26.5x
            [silencedetect @ 0000019aa74aae80] silence_end: 8908.751354 | silence_duration: 25.998792
            [silencedetect @ 0000019aa74aae80] silence_start: 8925.280167e=N/A speed=26.5x
            [silencedetect @ 0000019aa74aae80] silence_end: 8928.334583 | silence_duration: 3.054417
            [silencedetect @ 0000019aa74aae80] silence_start: 8929.557229
            [silencedetect @ 0000019aa74aae80] silence_end: 8932.296896 | silence_duration: 2.739667
            [silencedetect @ 0000019aa74aae80] silence_start: 8936.480292
            [silencedetect @ 0000019aa74aae80] silence_end: 8939.531563 | silence_duration: 3.051271
            [silencedetect @ 0000019aa74aae80] silence_start: 8943.61625te=N/A speed=26.5x
            [silencedetect @ 0000019aa74aae80] silence_end: 8951.054313 | silence_duration: 7.438063
            [silencedetect @ 0000019aa74aae80] silence_start: 8969.5035ate=N/A speed=26.5x
            [silencedetect @ 0000019aa74aae80] silence_end: 8971.916771 | silence_duration: 2.413271
            [silencedetect @ 0000019aa74aae80] silence_start: 8984.272125
            [silencedetect @ 0000019aa74aae80] silence_end: 8990.552125 | silence_duration: 6.28
            [silencedetect @ 0000019aa74aae80] silence_start: 9000.656437
            [silencedetect @ 0000019aa74aae80] silence_end: 9013.526271 | silence_duration: 12.869833
            [silencedetect @ 0000019aa74aae80] silence_start: 9022.64925te=N/A speed=26.6x
            [silencedetect @ 0000019aa74aae80] silence_end: 9026.029688 | silence_duration: 3.380437
            [silencedetect @ 0000019aa74aae80] silence_start: 9037.601333e=N/A speed=26.6x
            [silencedetect @ 0000019aa74aae80] silence_end: 9040.672208 | silence_duration: 3.070875
            [silencedetect @ 0000019aa74aae80] silence_start: 9042.550354
            [silencedetect @ 0000019aa74aae80] silence_end: 9047.100125 | silence_duration: 4.549771
            [silencedetect @ 0000019aa74aae80] silence_start: 9074.833188e=N/A speed=26.6x
            [silencedetect @ 0000019aa74aae80] silence_end: 9077.51175 | silence_duration: 2.678562
            [silencedetect @ 0000019aa74aae80] silence_start: 9079.240354e=N/A speed=26.6x
            [silencedetect @ 0000019aa74aae80] silence_end: 9084.607375 | silence_duration: 5.367021
            [silencedetect @ 0000019aa74aae80] silence_start: 9091.461771
            [silencedetect @ 0000019aa74aae80] silence_end: 9096.467729 | silence_duration: 5.005958
            [silencedetect @ 0000019aa74aae80] silence_start: 9108.73075te=N/A speed=26.6x
            [silencedetect @ 0000019aa74aae80] silence_end: 9112.604687 | silence_duration: 3.873937
            [silencedetect @ 0000019aa74aae80] silence_start: 9123.262792e=N/A speed=26.6x
            [silencedetect @ 0000019aa74aae80] silence_end: 9125.636854 | silence_duration: 2.374062
            [silencedetect @ 0000019aa74aae80] silence_start: 9136.200271e=N/A speed=26.6x
            [silencedetect @ 0000019aa74aae80] silence_end: 9138.760313 | silence_duration: 2.560042
            [silencedetect @ 0000019aa74aae80] silence_start: 9139.408271
            [silencedetect @ 0000019aa74aae80] silence_end: 9141.782583 | silence_duration: 2.374312
            [silencedetect @ 0000019aa74aae80] silence_start: 9149.169208e=N/A speed=26.6x
            [silencedetect @ 0000019aa74aae80] silence_end: 9152.028875 | silence_duration: 2.859667
            [silencedetect @ 0000019aa74aae80] silence_start: 9152.430021
            [silencedetect @ 0000019aa74aae80] silence_end: 9154.6375 | silence_duration: 2.207479
            [silencedetect @ 0000019aa74aae80] silence_start: 9188.106229e=N/A speed=26.6x
            [silencedetect @ 0000019aa74aae80] silence_end: 9190.22425 | silence_duration: 2.118021
            [silencedetect @ 0000019aa74aae80] silence_start: 9190.257562e=N/A speed=26.6x
            [silencedetect @ 0000019aa74aae80] silence_end: 9192.420271 | silence_duration: 2.162708
            [silencedetect @ 0000019aa74aae80] silence_start: 9204.521917e=N/A speed=26.6x
            [silencedetect @ 0000019aa74aae80] silence_end: 9207.742271 | silence_duration: 3.220354
            [silencedetect @ 0000019aa74aae80] silence_start: 9208.317833
            [silencedetect @ 0000019aa74aae80] silence_end: 9213.330125 | silence_duration: 5.012292
            [silencedetect @ 0000019aa74aae80] silence_start: 9291.462458e=N/A speed=26.6x
            [silencedetect @ 0000019aa74aae80] silence_end: 9294.283042 | silence_duration: 2.820583
            [silencedetect @ 0000019aa74aae80] silence_start: 9298.934063e=N/A speed=26.6x
            [silencedetect @ 0000019aa74aae80] silence_end: 9302.205625 | silence_duration: 3.271562
            [silencedetect @ 0000019aa74aae80] silence_start: 9334.841083e=N/A speed=26.6x
            [silencedetect @ 0000019aa74aae80] silence_end: 9336.976917 | silence_duration: 2.135833
            [silencedetect @ 0000019aa74aae80] silence_start: 9342.303062e=N/A speed=26.6x
            [silencedetect @ 0000019aa74aae80] silence_end: 9344.528667 | silence_duration: 2.225604
            [silencedetect @ 0000019aa74aae80] silence_start: 9353.136021e=N/A speed=26.6x
            [silencedetect @ 0000019aa74aae80] silence_end: 9355.395771 | silence_duration: 2.25975
            [silencedetect @ 0000019aa74aae80] silence_start: 9363.908146
            [silencedetect @ 0000019aa74aae80] silence_end: 9366.911813 | silence_duration: 3.003667
            [silencedetect @ 0000019aa74aae80] silence_start: 9373.158521e=N/A speed=26.6x
            [silencedetect @ 0000019aa74aae80] silence_end: 9376.046958 | silence_duration: 2.888437
            [silencedetect @ 0000019aa74aae80] silence_start: 9376.097937
            [silencedetect @ 0000019aa74aae80] silence_end: 9378.900062 | silence_duration: 2.802125
            [silencedetect @ 0000019aa74aae80] silence_start: 9390.590688e=N/A speed=26.6x
            [silencedetect @ 0000019aa74aae80] silence_end: 9393.253958 | silence_duration: 2.663271
            [silencedetect @ 0000019aa74aae80] silence_start: 9395.201854
            [silencedetect @ 0000019aa74aae80] silence_end: 9398.512583 | silence_duration: 3.310729
            [silencedetect @ 0000019aa74aae80] silence_start: 9402.539062
            [silencedetect @ 0000019aa74aae80] silence_end: 9411.812208 | silence_duration: 9.273146
            [silencedetect @ 0000019aa74aae80] silence_start: 9417.790167e=N/A speed=26.6x
            [silencedetect @ 0000019aa74aae80] silence_end: 9420.454687 | silence_duration: 2.664521
            [silencedetect @ 0000019aa74aae80] silence_start: 9498.597896e=N/A speed=26.6x
            [silencedetect @ 0000019aa74aae80] silence_end: 9501.044271 | silence_duration: 2.446375
            [silencedetect @ 0000019aa74aae80] silence_start: 9524.327396e=N/A speed=26.6x
            [silencedetect @ 0000019aa74aae80] silence_end: 9527.433167 | silence_duration: 3.105771
            [silencedetect @ 0000019aa74aae80] silence_start: 9533.286333
            [silencedetect @ 0000019aa74aae80] silence_end: 9536.2285 | silence_duration: 2.942167
            [silencedetect @ 0000019aa74aae80] silence_start: 9541.722083e=N/A speed=26.6x
            [silencedetect @ 0000019aa74aae80] silence_end: 9544.586125 | silence_duration: 2.864042
            [silencedetect @ 0000019aa74aae80] silence_start: 9554.814979e=N/A speed=26.6x
            [silencedetect @ 0000019aa74aae80] silence_end: 9557.19675 | silence_duration: 2.381771
            [silencedetect @ 0000019aa74aae80] silence_start: 9557.288354
            [silencedetect @ 0000019aa74aae80] silence_end: 9567.073458 | silence_duration: 9.785104
            [silencedetect @ 0000019aa74aae80] silence_start: 9570.348333
            [silencedetect @ 0000019aa74aae80] silence_end: 9572.715083 | silence_duration: 2.36675
            [silencedetect @ 0000019aa74aae80] silence_start: 9586.57975te=N/A speed=26.6x
            [silencedetect @ 0000019aa74aae80] silence_end: 9588.95425 | silence_duration: 2.3745
            [silencedetect @ 0000019aa74aae80] silence_start: 9589.6365
            [silencedetect @ 0000019aa74aae80] silence_end: 9591.918354 | silence_duration: 2.281854
            [silencedetect @ 0000019aa74aae80] silence_start: 9595.634792e=N/A speed=26.6x
            [silencedetect @ 0000019aa74aae80] silence_end: 9599.799896 | silence_duration: 4.165104
            [silencedetect @ 0000019aa74aae80] silence_start: 9605.497979
            [silencedetect @ 0000019aa74aae80] silence_end: 9608.347583 | silence_duration: 2.849604
            [silencedetect @ 0000019aa74aae80] silence_start: 9618.494271e=N/A speed=26.6x
            [silencedetect @ 0000019aa74aae80] silence_end: 9621.396771 | silence_duration: 2.9025
            [silencedetect @ 0000019aa74aae80] silence_start: 9622.599187e=N/A speed=26.6x
            [silencedetect @ 0000019aa74aae80] silence_end: 9630.037229 | silence_duration: 7.438042
            [silencedetect @ 0000019aa74aae80] silence_start: 9669.960875e=N/A speed=26.6x
            [silencedetect @ 0000019aa74aae80] silence_end: 9672.01025 | silence_duration: 2.049375
            [silencedetect @ 0000019aa74aae80] silence_start: 9711.801458e=N/A speed=26.6x
            [silencedetect @ 0000019aa74aae80] silence_end: 9714.364 | silence_duration: 2.562542
            [silencedetect @ 0000019aa74aae80] silence_start: 9745.809792e=N/A speed=26.7x
            [silencedetect @ 0000019aa74aae80] silence_end: 9752.594167 | silence_duration: 6.784375
            [silencedetect @ 0000019aa74aae80] silence_start: 9753.266042e=N/A speed=26.7x
            [silencedetect @ 0000019aa74aae80] silence_end: 9757.070333 | silence_duration: 3.804292
            [silencedetect @ 0000019aa74aae80] silence_start: 9758.033146
            [silencedetect @ 0000019aa74aae80] silence_end: 9760.78775 | silence_duration: 2.754604
            [silencedetect @ 0000019aa74aae80] silence_start: 9765.258562
            [silencedetect @ 0000019aa74aae80] silence_end: 9770.046937 | silence_duration: 4.788375
            [silencedetect @ 0000019aa74aae80] silence_start: 9784.825125e=N/A speed=26.7x
            [silencedetect @ 0000019aa74aae80] silence_end: 9788.536625 | silence_duration: 3.7115
            [silencedetect @ 0000019aa74aae80] silence_start: 9818.965187e=N/A speed=26.7x
            [silencedetect @ 0000019aa74aae80] silence_end: 9824.267542 | silence_duration: 5.302354
            [silencedetect @ 0000019aa74aae80] silence_start: 9826.055208e=N/A speed=26.7x
            [silencedetect @ 0000019aa74aae80] silence_end: 9828.379896 | silence_duration: 2.324688
            [silencedetect @ 0000019aa74aae80] silence_start: 9837.008521e=N/A speed=26.7x
            [silencedetect @ 0000019aa74aae80] silence_end: 9839.079604 | silence_duration: 2.071083
            [silencedetect @ 0000019aa74aae80] silence_start: 9844.136125
            [silencedetect @ 0000019aa74aae80] silence_end: 9846.923188 | silence_duration: 2.787062
            [silencedetect @ 0000019aa74aae80] silence_start: 9854.512896e=N/A speed=26.7x
            [silencedetect @ 0000019aa74aae80] silence_end: 9858.244333 | silence_duration: 3.731437
            [silencedetect @ 0000019aa74aae80] silence_start: 9882.571375e=N/A speed=26.7x
            [silencedetect @ 0000019aa74aae80] silence_end: 9885.768854 | silence_duration: 3.197479
            [silencedetect @ 0000019aa74aae80] silence_start: 9891.646042
            [silencedetect @ 0000019aa74aae80] silence_end: 9895.185083 | silence_duration: 3.539042
            [silencedetect @ 0000019aa74aae80] silence_start: 9902.421833
            [silencedetect @ 0000019aa74aae80] silence_end: 9904.918333 | silence_duration: 2.4965
            [silencedetect @ 0000019aa74aae80] silence_start: 9906.591979e=N/A speed=26.7x
            [silencedetect @ 0000019aa74aae80] silence_end: 9910.1775 | silence_duration: 3.585521
            [silencedetect @ 0000019aa74aae80] silence_start: 9915.360792
            [silencedetect @ 0000019aa74aae80] silence_end: 9917.809875 | silence_duration: 2.449083
            [silencedetect @ 0000019aa74aae80] silence_start: 9917.997875
            [silencedetect @ 0000019aa74aae80] silence_end: 9922.933125 | silence_duration: 4.93525
            [silencedetect @ 0000019aa74aae80] silence_start: 9925.369458
            [silencedetect @ 0000019aa74aae80] silence_end: 9927.852875 | silence_duration: 2.483417
            [silencedetect @ 0000019aa74aae80] silence_start: 9936.583542e=N/A speed=26.7x
            [silencedetect @ 0000019aa74aae80] silence_end: 9939.170625 | silence_duration: 2.587083
            [silencedetect @ 0000019aa74aae80] silence_start: 9946.979354
            [silencedetect @ 0000019aa74aae80] silence_end: 9949.979479 | silence_duration: 3.000125
            [silencedetect @ 0000019aa74aae80] silence_start: 9953.599062e=N/A speed=26.7x
            [silencedetect @ 0000019aa74aae80] silence_end: 9958.813979 | silence_duration: 5.214917
            [silencedetect @ 0000019aa74aae80] silence_start: 9964.425021e=N/A speed=26.7x
            [silencedetect @ 0000019aa74aae80] silence_end: 9967.025938 | silence_duration: 2.600917
            [silencedetect @ 0000019aa74aae80] silence_start: 9972.751125
            [silencedetect @ 0000019aa74aae80] silence_end: 9977.730667 | silence_duration: 4.979542
            [silencedetect @ 0000019aa74aae80] silence_start: 9981.005708e=N/A speed=26.7x
            [silencedetect @ 0000019aa74aae80] silence_end: 9984.061792 | silence_duration: 3.056083
            [silencedetect @ 0000019aa74aae80] silence_start: 9993.671667
            [silencedetect @ 0000019aa74aae80] silence_end: 9996.647187 | silence_duration: 2.975521
            [silencedetect @ 0000019aa74aae80] silence_start: 10004.180562
            [silencedetect @ 0000019aa74aae80] silence_end: 10007.398979 | silence_duration: 3.218417
            [silencedetect @ 0000019aa74aae80] silence_start: 10024.152479=N/A speed=26.7x
            [silencedetect @ 0000019aa74aae80] silence_end: 10026.748583 | silence_duration: 2.596104
            [silencedetect @ 0000019aa74aae80] silence_start: 10027.923771
            [silencedetect @ 0000019aa74aae80] silence_end: 10034.905417 | silence_duration: 6.981646
            [silencedetect @ 0000019aa74aae80] silence_start: 10035.292938
            [silencedetect @ 0000019aa74aae80] silence_end: 10038.30175 | silence_duration: 3.008812
            [silencedetect @ 0000019aa74aae80] silence_start: 10041.290271=N/A speed=26.7x
            [silencedetect @ 0000019aa74aae80] silence_end: 10043.437917 | silence_duration: 2.147646
            [silencedetect @ 0000019aa74aae80] silence_start: 10044.890958
            [silencedetect @ 0000019aa74aae80] silence_end: 10050.695292 | silence_duration: 5.804333
            [silencedetect @ 0000019aa74aae80] silence_start: 10056.577396=N/A speed=26.7x
            [silencedetect @ 0000019aa74aae80] silence_end: 10062.269458 | silence_duration: 5.692062
            [silencedetect @ 0000019aa74aae80] silence_start: 10083.152687=N/A speed=26.7x
            [silencedetect @ 0000019aa74aae80] silence_end: 10086.018937 | silence_duration: 2.86625
            [silencedetect @ 0000019aa74aae80] silence_start: 10117.922167=N/A speed=26.7x
            [silencedetect @ 0000019aa74aae80] silence_end: 10120.097854 | silence_duration: 2.175687
            [silencedetect @ 0000019aa74aae80] silence_start: 10236.50025e=N/A speed=26.7x
            [silencedetect @ 0000019aa74aae80] silence_end: 10239.982146 | silence_duration: 3.481896
            [silencedetect @ 0000019aa74aae80] silence_start: 10255.807312=N/A speed=26.7x
            [silencedetect @ 0000019aa74aae80] silence_end: 10258.02025 | silence_duration: 2.212937
            [silencedetect @ 0000019aa74aae80] silence_start: 10316.161937=N/A speed=26.7x
            [silencedetect @ 0000019aa74aae80] silence_end: 10319.352792 | silence_duration: 3.190854
            [silencedetect @ 0000019aa74aae80] silence_start: 10349.353229=N/A speed=26.7x
            [silencedetect @ 0000019aa74aae80] silence_end: 10352.6035 | silence_duration: 3.250271
            [silencedetect @ 0000019aa74aae80] silence_start: 10378.289479=N/A speed=26.7x
            [silencedetect @ 0000019aa74aae80] silence_end: 10381.829062 | silence_duration: 3.539583
            [silencedetect @ 0000019aa74aae80] silence_start: 10396.342771=N/A speed=26.7x
            [silencedetect @ 0000019aa74aae80] silence_end: 10398.445979 | silence_duration: 2.103208
            [silencedetect @ 0000019aa74aae80] silence_start: 10425.763458=N/A speed=26.7x
            [silencedetect @ 0000019aa74aae80] silence_end: 10427.922521 | silence_duration: 2.159063
            [silencedetect @ 0000019aa74aae80] silence_start: 10480.884187=N/A speed=26.7x
            [silencedetect @ 0000019aa74aae80] silence_end: 10482.909083 | silence_duration: 2.024896
            [silencedetect @ 0000019aa74aae80] silence_start: 10484.119646
            [silencedetect @ 0000019aa74aae80] silence_end: 10489.841271 | silence_duration: 5.721625
            [silencedetect @ 0000019aa74aae80] silence_start: 10530.310812=N/A speed=26.7x
            [silencedetect @ 0000019aa74aae80] silence_end: 10532.769562 | silence_duration: 2.45875
            [silencedetect @ 0000019aa74aae80] silence_start: 10555.899229=N/A speed=26.7x
            [silencedetect @ 0000019aa74aae80] silence_end: 10558.153958 | silence_duration: 2.254729
            [silencedetect @ 0000019aa74aae80] silence_start: 10572.819271=N/A speed=26.7x
            [silencedetect @ 0000019aa74aae80] silence_end: 10575.236417 | silence_duration: 2.417146
            [silencedetect @ 0000019aa74aae80] silence_start: 10582.499708=N/A speed=26.8x
            [silencedetect @ 0000019aa74aae80] silence_end: 10591.692479 | silence_duration: 9.192771
            [silencedetect @ 0000019aa74aae80] silence_start: 10601.919396=N/A speed=26.8x
            [silencedetect @ 0000019aa74aae80] silence_end: 10605.024521 | silence_duration: 3.105125
            [silencedetect @ 0000019aa74aae80] silence_start: 10609.269417=N/A speed=26.8x
            [silencedetect @ 0000019aa74aae80] silence_end: 10615.855229 | silence_duration: 6.585812
            [silencedetect @ 0000019aa74aae80] silence_start: 10619.374813
            [silencedetect @ 0000019aa74aae80] silence_end: 10621.636562 | silence_duration: 2.26175
            [silencedetect @ 0000019aa74aae80] silence_start: 10645.428625=N/A speed=26.8x
            [silencedetect @ 0000019aa74aae80] silence_end: 10648.979 | silence_duration: 3.550375
            [silencedetect @ 0000019aa74aae80] silence_start: 10650.010208
            [silencedetect @ 0000019aa74aae80] silence_end: 10652.877771 | silence_duration: 2.867563
            [silencedetect @ 0000019aa74aae80] silence_start: 10673.859146=N/A speed=26.8x
            [silencedetect @ 0000019aa74aae80] silence_end: 10677.962312 | silence_duration: 4.103167
            [silencedetect @ 0000019aa74aae80] silence_start: 10695.56525e=N/A speed=26.8x
            [silencedetect @ 0000019aa74aae80] silence_end: 10697.909604 | silence_duration: 2.344354
            [silencedetect @ 0000019aa74aae80] silence_start: 10774.326833=N/A speed=26.8x
            [silencedetect @ 0000019aa74aae80] silence_end: 10776.908875 | silence_duration: 2.582042
            [silencedetect @ 0000019aa74aae80] silence_start: 10783.711083
            [silencedetect @ 0000019aa74aae80] silence_end: 10787.281208 | silence_duration: 3.570125
            [silencedetect @ 0000019aa74aae80] silence_start: 10787.281229=N/A speed=26.8x
            [silencedetect @ 0000019aa74aae80] silence_end: 10790.375458 | silence_duration: 3.094229
            [silencedetect @ 0000019aa74aae80] silence_start: 10793.089667
            [silencedetect @ 0000019aa74aae80] silence_end: 10795.453792 | silence_duration: 2.364125
            [silencedetect @ 0000019aa74aae80] silence_start: 10839.23225e=N/A speed=26.8x
            [silencedetect @ 0000019aa74aae80] silence_end: 10841.839229 | silence_duration: 2.606979
            [silencedetect @ 0000019aa74aae80] silence_start: 10875.731292=N/A speed=26.8x
            [silencedetect @ 0000019aa74aae80] silence_end: 10878.337438 | silence_duration: 2.606146
            [silencedetect @ 0000019aa74aae80] silence_start: 10891.523729=N/A speed=26.8x
            [silencedetect @ 0000019aa74aae80] silence_end: 10893.725229 | silence_duration: 2.2015
            [silencedetect @ 0000019aa74aae80] silence_start: 10897.251562
            [silencedetect @ 0000019aa74aae80] silence_end: 10901.102563 | silence_duration: 3.851
            [silencedetect @ 0000019aa74aae80] silence_start: 10902.576729
            [silencedetect @ 0000019aa74aae80] silence_end: 10907.914979 | silence_duration: 5.33825
            [silencedetect @ 0000019aa74aae80] silence_start: 10909.613271
            [silencedetect @ 0000019aa74aae80] silence_end: 10912.552 | silence_duration: 2.938729
            [silencedetect @ 0000019aa74aae80] silence_start: 10939.430208=N/A speed=26.8x
            [silencedetect @ 0000019aa74aae80] silence_end: 10942.390562 | silence_duration: 2.960354
            [silencedetect @ 0000019aa74aae80] silence_start: 10947.480604
            [silencedetect @ 0000019aa74aae80] silence_end: 10950.492042 | silence_duration: 3.011437
            [silencedetect @ 0000019aa74aae80] silence_start: 10951.201937
            [silencedetect @ 0000019aa74aae80] silence_end: 10957.320167 | silence_duration: 6.118229
            [silencedetect @ 0000019aa74aae80] silence_start: 10994.962979=N/A speed=26.8x
            [silencedetect @ 0000019aa74aae80] silence_end: 10997.660625 | silence_duration: 2.697646
            [silencedetect @ 0000019aa74aae80] silence_start: 11026.667708=N/A speed=26.8x
            [silencedetect @ 0000019aa74aae80] silence_end: 11029.413396 | silence_duration: 2.745687
            [silencedetect @ 0000019aa74aae80] silence_start: 11032.139875
            [silencedetect @ 0000019aa74aae80] silence_end: 11035.544625 | silence_duration: 3.40475
            [silencedetect @ 0000019aa74aae80] silence_start: 11056.949562=N/A speed=26.8x
            [silencedetect @ 0000019aa74aae80] silence_end: 11062.141521 | silence_duration: 5.191958
            [silencedetect @ 0000019aa74aae80] silence_start: 11067.550083
            [silencedetect @ 0000019aa74aae80] silence_end: 11069.643479 | silence_duration: 2.093396
            [silencedetect @ 0000019aa74aae80] silence_start: 11117.617271=N/A speed=26.9x
            [silencedetect @ 0000019aa74aae80] silence_end: 11119.638 | silence_duration: 2.020729
            [silencedetect @ 0000019aa74aae80] silence_start: 11144.545792=N/A speed=26.9x
            [silencedetect @ 0000019aa74aae80] silence_end: 11149.806896 | silence_duration: 5.261104
            [silencedetect @ 0000019aa74aae80] silence_start: 11155.068833
            [silencedetect @ 0000019aa74aae80] silence_end: 11160.161104 | silence_duration: 5.092271
            [silencedetect @ 0000019aa74aae80] silence_start: 11166.246667
            [silencedetect @ 0000019aa74aae80] silence_end: 11171.477812 | silence_duration: 5.231146
            [silencedetect @ 0000019aa74aae80] silence_start: 11171.780833
            [silencedetect @ 0000019aa74aae80] silence_end: 11173.990521 | silence_duration: 2.209687
            [silencedetect @ 0000019aa74aae80] silence_start: 11194.201437=N/A speed=26.8x
            [silencedetect @ 0000019aa74aae80] silence_end: 11198.530208 | silence_duration: 4.328771
            [silencedetect @ 0000019aa74aae80] silence_start: 11200.712542
            [silencedetect @ 0000019aa74aae80] silence_end: 11202.928229 | silence_duration: 2.215688
            [silencedetect @ 0000019aa74aae80] silence_start: 11207.345708
            [silencedetect @ 0000019aa74aae80] silence_end: 11209.387563 | silence_duration: 2.041854
            [silencedetect @ 0000019aa74aae80] silence_start: 11214.105833=N/A speed=26.8x
            [silencedetect @ 0000019aa74aae80] silence_end: 11216.197688 | silence_duration: 2.091854
            [silencedetect @ 0000019aa74aae80] silence_start: 11219.018583
            [silencedetect @ 0000019aa74aae80] silence_end: 11224.589333 | silence_duration: 5.57075
            [silencedetect @ 0000019aa74aae80] silence_start: 11225.217188
            [silencedetect @ 0000019aa74aae80] silence_end: 11229.562937 | silence_duration: 4.34575
            [silencedetect @ 0000019aa74aae80] silence_start: 11244.664146=N/A speed=26.8x
            [silencedetect @ 0000019aa74aae80] silence_end: 11247.354333 | silence_duration: 2.690187
            [silencedetect @ 0000019aa74aae80] silence_start: 11251.3875te=N/A speed=26.8x
            [silencedetect @ 0000019aa74aae80] silence_end: 11253.504771 | silence_duration: 2.117271
            [silencedetect @ 0000019aa74aae80] silence_start: 11255.098208
            [silencedetect @ 0000019aa74aae80] silence_end: 11257.669833 | silence_duration: 2.571625
            [silencedetect @ 0000019aa74aae80] silence_start: 11267.630812=N/A speed=26.8x
            [silencedetect @ 0000019aa74aae80] silence_end: 11269.697542 | silence_duration: 2.066729
            [silencedetect @ 0000019aa74aae80] silence_start: 11303.198937=N/A speed=26.8x
            [silencedetect @ 0000019aa74aae80] silence_end: 11306.027562 | silence_duration: 2.828625
            [silencedetect @ 0000019aa74aae80] silence_start: 11320.639ate=N/A speed=26.8x
            [silencedetect @ 0000019aa74aae80] silence_end: 11323.678771 | silence_duration: 3.039771
            [silencedetect @ 0000019aa74aae80] silence_start: 11332.895521=N/A speed=26.8x
            [silencedetect @ 0000019aa74aae80] silence_end: 11335.463958 | silence_duration: 2.568437
            [silencedetect @ 0000019aa74aae80] silence_start: 11336.661583
            [silencedetect @ 0000019aa74aae80] silence_end: 11339.599437 | silence_duration: 2.937854
            [silencedetect @ 0000019aa74aae80] silence_start: 11575.964271=N/A speed=26.9x
            [silencedetect @ 0000019aa74aae80] silence_end: 11579.028271 | silence_duration: 3.064
            [silencedetect @ 0000019aa74aae80] silence_start: 11607.064917=N/A speed=26.9x
            [silencedetect @ 0000019aa74aae80] silence_end: 11609.797021 | silence_duration: 2.732104
            [silencedetect @ 0000019aa74aae80] silence_start: 11611.477563
            [silencedetect @ 0000019aa74aae80] silence_end: 11614.341 | silence_duration: 2.863437
            [silencedetect @ 0000019aa74aae80] silence_start: 11615.74075
            [silencedetect @ 0000019aa74aae80] silence_end: 11617.991458 | silence_duration: 2.250708
            [silencedetect @ 0000019aa74aae80] silence_start: 11635.355729=N/A speed=26.9x
            [silencedetect @ 0000019aa74aae80] silence_end: 11637.656208 | silence_duration: 2.300479
            [silencedetect @ 0000019aa74aae80] silence_start: 11658.638167=N/A speed=26.9x
            [silencedetect @ 0000019aa74aae80] silence_end: 11660.741062 | silence_duration: 2.102896
            [silencedetect @ 0000019aa74aae80] silence_start: 11744.492146=N/A speed=26.9x
            [silencedetect @ 0000019aa74aae80] silence_end: 11746.543583 | silence_duration: 2.051438
            [silencedetect @ 0000019aa74aae80] silence_start: 11757.065ate=N/A speed=26.9x
            [silencedetect @ 0000019aa74aae80] silence_end: 11766.745 | silence_duration: 9.68
            [silencedetect @ 0000019aa74aae80] silence_start: 11767.27
            [silencedetect @ 0000019aa74aae80] silence_end: 11769.894 | silence_duration: 2.624
            [silencedetect @ 0000019aa74aae80] silence_start: 11777.594208
            [silencedetect @ 0000019aa74aae80] silence_end: 11781.925729 | silence_duration: 4.331521
            [silencedetect @ 0000019aa74aae80] silence_start: 11790.101771
            [silencedetect @ 0000019aa74aae80] silence_end: 11798.274979 | silence_duration: 8.173208
            [silencedetect @ 0000019aa74aae80] silence_start: 11802.292542
            [silencedetect @ 0000019aa74aae80] silence_end: 11805.568812 | silence_duration: 3.276271
            [silencedetect @ 0000019aa74aae80] silence_start: 11813.053813=N/A speed=26.9x
            [silencedetect @ 0000019aa74aae80] silence_end: 11819.759583 | silence_duration: 6.705771
            [silencedetect @ 0000019aa74aae80] silence_start: 11824.930396=N/A speed=26.9x
            [silencedetect @ 0000019aa74aae80] silence_end: 11827.107813 | silence_duration: 2.177417
            [silencedetect @ 0000019aa74aae80] silence_start: 11830.557125
            [silencedetect @ 0000019aa74aae80] silence_end: 11833.837042 | silence_duration: 3.279917
            [silencedetect @ 0000019aa74aae80] silence_start: 11834.072667
            [silencedetect @ 0000019aa74aae80] silence_end: 11837.193083 | silence_duration: 3.120417
            [silencedetect @ 0000019aa74aae80] silence_start: 11840.532729=N/A speed=26.9x
            [silencedetect @ 0000019aa74aae80] silence_end: 11847.365396 | silence_duration: 6.832667
            [silencedetect @ 0000019aa74aae80] silence_start: 11864.815458=N/A speed=26.9x
            [silencedetect @ 0000019aa74aae80] silence_end: 11867.966896 | silence_duration: 3.151438
            [silencedetect @ 0000019aa74aae80] silence_start: 11941.097937=N/A speed=26.9x
            [silencedetect @ 0000019aa74aae80] silence_end: 11943.255333 | silence_duration: 2.157396
            [silencedetect @ 0000019aa74aae80] silence_start: 11951.869396=N/A speed=26.9x
            [silencedetect @ 0000019aa74aae80] silence_end: 11955.740875 | silence_duration: 3.871479
            [silencedetect @ 0000019aa74aae80] silence_start: 11959.3535
            [silencedetect @ 0000019aa74aae80] silence_end: 11961.967396 | silence_duration: 2.613896
            [silencedetect @ 0000019aa74aae80] silence_start: 11964.062583=N/A speed=26.9x
            [silencedetect @ 0000019aa74aae80] silence_end: 11967.794437 | silence_duration: 3.731854
            [silencedetect @ 0000019aa74aae80] silence_start: 11972.264875
            [silencedetect @ 0000019aa74aae80] silence_end: 11975.265271 | silence_duration: 3.000396
            [silencedetect @ 0000019aa74aae80] silence_start: 11980.731875=N/A speed=26.9x
            [silencedetect @ 0000019aa74aae80] silence_end: 11983.866479 | silence_duration: 3.134604
            [silencedetect @ 0000019aa74aae80] silence_start: 11983.879604
            [silencedetect @ 0000019aa74aae80] silence_end: 11989.7025 | silence_duration: 5.822896
            [silencedetect @ 0000019aa74aae80] silence_start: 12003.008292=N/A speed=26.9x
            [silencedetect @ 0000019aa74aae80] silence_end: 12009.726771 | silence_duration: 6.718479
            [silencedetect @ 0000019aa74aae80] silence_start: 12072.163729=N/A speed=26.9x
            [silencedetect @ 0000019aa74aae80] silence_end: 12076.087083 | silence_duration: 3.923354
            [silencedetect @ 0000019aa74aae80] silence_start: 12082.503375=N/A speed=26.9x
            [silencedetect @ 0000019aa74aae80] silence_end: 12088.539021 | silence_duration: 6.035646
            [silencedetect @ 0000019aa74aae80] silence_start: 12089.027146=N/A speed=26.9x
            [silencedetect @ 0000019aa74aae80] silence_end: 12093.23575 | silence_duration: 4.208604
            [silencedetect @ 0000019aa74aae80] silence_start: 12135.647917=N/A speed=26.9x
            [silencedetect @ 0000019aa74aae80] silence_end: 12137.989417 | silence_duration: 2.3415
            [silencedetect @ 0000019aa74aae80] silence_start: 12139.038354
            [silencedetect @ 0000019aa74aae80] silence_end: 12143.30875 | silence_duration: 4.270396
            [silencedetect @ 0000019aa74aae80] silence_start: 12143.329958
            [silencedetect @ 0000019aa74aae80] silence_end: 12146.295813 | silence_duration: 2.965854
            [silencedetect @ 0000019aa74aae80] silence_start: 12147.528417
            [silencedetect @ 0000019aa74aae80] silence_end: 12150.083958 | silence_duration: 2.555542
            [silencedetect @ 0000019aa74aae80] silence_start: 12160.79075e=N/A speed=26.9x
            [silencedetect @ 0000019aa74aae80] silence_end: 12163.381667 | silence_duration: 2.590917
            [silencedetect @ 0000019aa74aae80] silence_start: 12172.533687
            [silencedetect @ 0000019aa74aae80] silence_end: 12175.128479 | silence_duration: 2.594792
            [silencedetect @ 0000019aa74aae80] silence_start: 12227.377042=N/A speed=26.9x
            [silencedetect @ 0000019aa74aae80] silence_end: 12230.313062 | silence_duration: 2.936021
            [silencedetect @ 0000019aa74aae80] silence_start: 12253.965125=N/A speed=26.9x
            [silencedetect @ 0000019aa74aae80] silence_end: 12284.736 | silence_duration: 30.770875
            """;
        //(12072.163729, 12284.736)
        BlockingCollection<string?> lines = new();
        foreach(var line in input.Split("\n"))
        {
            lines.Add(line);
        }
        lines.CompleteAdding();
        var silenceRegions = Ffmpeg.GetSilenceRegions(lines);
        (double start, double? end) = Ffmpeg.GetSeekRegion(silenceRegions);
    }
}
