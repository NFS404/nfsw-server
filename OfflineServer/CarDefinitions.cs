﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OfflineServer
{
    public static class CarDefinitions
    {
        // Compiled with the extra list supplied by 379Felipe, cheers buddy!
        public static readonly Dictionary<Int64, String> PhysicsProfileHashDefinitions = new Dictionary<Int64, String>()
        {
            {226126488, "ALFA ROMEO 8C COMPETIZIONE"},
            {-4068840808, "ALFA ROMEO 8C COMPETIZIONE"},
            {738983158, "ASTON MARTIN DBS"},
            {-3555984138, "ASTON MARTIN DBS"},
            {1606403377, "ASTON MARTIN DBS VOLANTE"},
            {-2688563919, "ASTON MARTIN DBS VOLANTE"},
            {3020568755, "ASTON MARTIN VANTAGE V12"},
            {-1274398541, "ASTON MARTIN VANTAGE V12"},
            {2483550265, "AUDI A1 CLUBSPORT QUATTRO CONCEPT"},
            {-1811417031, "AUDI A1 CLUBSPORT QUATTRO CONCEPT"},
            {1447950598, "AUDI A3 3.2 QUATTRO"},
            {-2847016698, "AUDI A3 3.2 QUATTRO"},
            {2215218184, "AUDI QUATTRO 20V"},
            {-2079749112, "AUDI QUATTRO 20V"},
            {96940328, "AUDI R8 4.2 FSI QUATTRO"},
            {-4198026968, "AUDI R8 4.2 FSI QUATTRO"},
            {1692883589, "AUDI R8 COUPE 5.2 FSI QUATTRO"},
            {-2602083707, "AUDI R8 COUPE 5.2 FSI QUATTRO"},
            {3838204992, "AUDI R8 LMS ULTRA"},
            {-456762304, "AUDI R8 LMS ULTRA"},
            {1198628936, "AUDI RS4"},
            {-3096338360, "AUDI RS4"},
            {616754006, "AUDI S5"},
            {-3678213290, "AUDI S5"},
            {3760350532, "AUDI TT RS COUPE"},
            {-534616764, "AUDI TT RS COUPE"},
            {1747671174, "BENTLEY CONTINENTAL SUPERSPORTS CONVERTIBLE"},
            {-2547296122, "BENTLEY CONTINENTAL SUPERSPORTS CONVERTIBLE"},
            {3048674933, "BENTLEY CONTINENTAL SUPERSPORTS COUPE"},
            {-1246292363, "BENTLEY CONTINENTAL SUPERSPORTS COUPE"},
            {1362045085, "BMW 1 SERIES M COUPE"},
            {-2932922211, "BMW 1 SERIES M COUPE"},
            {4048551937, "BMW 135I COUPE"},
            {-246415359, "BMW 135I COUPE"},
            {2830421725, "BMW 3.0 CSL GR.5"},
            {-1464545571, "BMW 3.0 CSL GR.5"},
            {2122419239, "BMW M1 PROCAR"},
            {-2172548057, "BMW M1 PROCAR"},
            {700802152, "BMW M3 (E92)"},
            {-3594165144, "BMW M3 (E92)"},
            {3448244287, "BMW M3 GTR (E46)"},
            {-846723009, "BMW M3 GTR (E46)"},
            {3771450869, "BMW M3 GTS (E92)"},
            {-523516427, "BMW M3 GTS (E92)"},
            {2208974420, "BMW M3 SPORT EVOLUTION (E30)"},
            {-2085992876, "BMW M3 SPORT EVOLUTION (E30)"},
            {3106200836, "BMW M6 CABRIOLET"},
            {-1188766460, "BMW M6 CABRIOLET"},
            {3424833218, "BMW M6 COUPE"},
            {-870134078, "BMW M6 COUPE"},
            {391691160, "BMW Z4 GT3"},
            {-3903276136, "BMW Z4 GT3"},
            {4232410043, "BMW Z4 M COUPE"},
            {-62557253, "BMW Z4 M COUPE"},
            {3729224832, "BUGATTI VEYRON 16.4"},
            {-565742464, "BUGATTI VEYRON 16.4"},
            {2651207871, "CADILLAC CTS-V"},
            {-1643759425, "CADILLAC CTS-V"},
            {2064453805, "CATERHAM SUPERLIGHT R500"},
            {-2230513491, "CATERHAM SUPERLIGHT R500"},
            {2425636121, "CHEVROLET CAMARO SS"},
            {-1869331175, "CHEVROLET CAMARO SS"},
            {4097872176, "CHEVROLET CAMARO ZL1"},
            {-197095120, "CHEVROLET CAMARO ZL1"},
            {3492999886, "CHEVROLET CAMARO ZL1 ELITE EDITION"},
            {-801967410, "CHEVROLET CAMARO ZL1 ELITE EDITION"},
            {65044046, "CHEVROLET CHEVELLE SS"},
            {-4229923250, "CHEVROLET CHEVELLE SS"},
            {1841343282, "CHEVROLET COBALT SS"},
            {-2453624014, "CHEVROLET COBALT SS"},
            {3045084254, "CHEVROLET CORVETTE STING RAY (C2)"},
            {-1249883042, "CHEVROLET CORVETTE STING RAY (C2)"},
            {1853505843, "CHEVROLET CORVETTE Z06"},
            {-2441461453, "CHEVROLET CORVETTE Z06"},
            {1683048341, "CHEVROLET CORVETTE Z06 CARBON LIMITED EDITION"},
            {-2611918955, "CHEVROLET CORVETTE Z06 CARBON LIMITED EDITION"},
            {2072093248, "CHEVROLET CORVETTE ZR1"},
            {-2222874048, "CHEVROLET CORVETTE ZR1"},
            {2015802169, "CHEVROLET EL CAMINO SS"},
            {-2279165127, "CHEVROLET EL CAMINO SS"},
            {1746378961, "CHRYSLER 300C HEMI V8"},
            {-2548588335, "CHRYSLER 300C HEMI V8"},
            {2744149874, "DODGE CHALLENGER R/T"},
            {-1550817422, "DODGE CHALLENGER R/T"},
            {3111694136, "DODGE CHALLENGER R/T CONCEPT"},
            {-1183273160, "DODGE CHALLENGER R/T CONCEPT"},
            {2257416053, "DODGE CHARGER R/T"},
            {-2037551243, "DODGE CHARGER R/T"},
            {2210168336, "DODGE CHARGER SRT-8 SUPER BEE"},
            {-2084798960, "DODGE CHARGER SRT-8 SUPER BEE"},
            {2434282173, "DODGE CHARGER SRT-8 (2012)"},
            {-1860685123, "DODGE CHARGER SRT-8 (2012)"},
            {2222864237, "DODGE VIPER ELITE SRT-10 ACR"},
            {-2072103059, "DODGE VIPER ELITE SRT-10 ACR"},
            {3660768406, "DODGE VIPER SRT-10"},
            {-634198890, "DODGE VIPER SRT-10"},
            {1528001747, "FORD CAPRI RS 3100"},
            {-2766965549, "FORD CAPRI RS 3100"},
            {1849927410, "FORD CROWN VICTORIA POLICE INTERCEPTOR"},
            {-2445039886, "FORD CROWN VICTORIA POLICE INTERCEPTOR"},
            {558351072, "FORD ESCORT MK1 RS1600 FIA GROUP 2"},
            {-3736616224, "FORD ESCORT MK1 RS1600 FIA GROUP 2"},
            {3780028278, "FORD ESCORT RS COSWORTH"},
            {-514939018, "FORD ESCORT RS COSWORTH"},
            {2848084960, "FORD F-150 RAPTOR SVT"},
            {-1446882336, "FORD F-150 RAPTOR SVT"},
            {3593046329, "FORD FOCUS RS"},
            {-701920967, "FORD FOCUS RS"},
            {1119921642, "FORD GT"},
            {-3175045654, "FORD GT"},
            {2743845698, "FORD GT40"},
            {-1551121598, "FORD GT40"},
            {3174564404, "FORD LOTUS CORTINA"},
            {-1120402892, "FORD LOTUS CORTINA"},
            {1213953721, "FORD POLICE INTERCEPTOR"},
            {-3081013575, "FORD POLICE INTERCEPTOR"},
            {4239617268, "FORD MUSTANG BOSS 302"},
            {-55350028, "FORD MUSTANG BOSS 302"},
            {1379198987, "FORD MUSTANG BOSS 302 '69"},
            {-2915768309, "FORD MUSTANG BOSS 302 '69"},
            {2180899715, "FORD MUSTANG RTR-X"},
            {-2114067581, "FORD MUSTANG RTR-X"},
            {2812191053, "FORD SHELBY GT500 SUPER SNAKE"},
            {-1482776243, "FORD SHELBY GT500 SUPER SNAKE"},
            {3299184535, "FORD SHELBY TERLINGUA MUSTANG"},
            {-995782761, "FORD SHELBY TERLINGUA MUSTANG"},
            {3743758759, "HUMMER H1"},
            {-551208537, "HUMMER H1"},
            {1101501558, "HUMMER H1 SNOWFLAKE"},
            {-3193465738, "HUMMER H1 SNOWFLAKE"},
            {3879636592, "INFINITI G35"},
            {-415330704, "INFINITI G35"},
            {2929107554, "JAGUAR E-TYPE LIGHTWEIGHT"},
            {-1365859742, "JAGUAR E-TYPE LIGHTWEIGHT"},
            {3256903572, "JAGUAR XKR"},
            {-1038063724, "JAGUAR XKR"},
            {49262384, "JEEP GRAND CHEROKEE SRT"},
            {-4245704912, "JEEP GRAND CHEROKEE SRT"},
            {2885108237, "KOENIGSEGG AGERA"},
            {-1409859059, "KOENIGSEGG AGERA"},
            {851565734, "KOENIGSEGG CCX"},
            {-3443401562, "KOENIGSEGG CCX"},
            {2849243667, "KOENIGSEGG CCX ELITE EDITION"},
            {-1445723629, "KOENIGSEGG CCX ELITE EDITION"},
            {3791206397, "KOENIGSEGG CCXR EDITION"},
            {-503760899, "KOENIGSEGG CCXR EDITION"},
            {782340389, "LAMBORGHINI AVENTADOR LP 700-4"},
            {-3512626907, "LAMBORGHINI AVENTADOR LP 700-4"},
            {753694961, "LAMBORGHINI COUNTACH 5000 QUATTROVALVOLE"},
            {-3541272335, "LAMBORGHINI COUNTACH 5000 QUATTROVALVOLE"},
            {1501719908, "LAMBORGHINI DIABLO SV"},
            {-2793247388, "LAMBORGHINI DIABLO SV"},
            {305284749, "LAMBORGHINI ESTOQUE"},
            {-3989682547, "LAMBORGHINI ESTOQUE"},
            {2295513436, "LAMBORGHINI GALLARDO LP 550-2 VALENTINO BALBONI"},
            {-1999453860, "LAMBORGHINI GALLARDO LP 550-2 VALENTINO BALBONI"},
            {3652740394, "LAMBORGHINI GALLARDO LP 560-4"},
            {-642226902, "LAMBORGHINI GALLARDO LP 560-4"},
            {1946692043, "LAMBORGHINI GALLARDO LP 560-4 SPYDER"},
            {-2348275253, "LAMBORGHINI GALLARDO LP 560-4 SPYDER"},
            {2881853762, "LAMBORGHINI MIURA SV"},
            {-1413113534, "LAMBORGHINI MIURA SV"},
            {1715410532, "LAMBORGHINI MIURA CONCEPT"},
            {-2579556764, "LAMBORGHINI MIURA CONCEPT"},
            {3839584179, "LAMBORGHINI MURCIELAGO LP 640"},
            {-455383117, "LAMBORGHINI MURCIELAGO LP 640"},
            {116888911, "LAMBORGHINI MURCIELAGO LP 650-4 ROADSTER"},
            {-4178078385, "LAMBORGHINI MURCIELAGO LP 650-4 ROADSTER"},
            {3424950933, "LAMBORGHINI MURCIELAGO LP 670-4 SUPERVELOCE"},
            {-870016363, "LAMBORGHINI MURCIELAGO LP 670-4 SUPERVELOCE"},
            {2502510567, "LAMBORGHINI REVENTON"},
            {-1792456729, "LAMBORGHINI REVENTON"},
            {1914316466, "LAMBORGHINI SESTO ELEMENTO"},
            {-2380650830, "LAMBORGHINI SESTO ELEMENTO"},
            {4140664939, "LANCIA DELTA HF"},
            {-154302357, "LANCIA DELTA HF"},
            {1543450544, "LEXUS IS 300"},
            {-2751516752, "LEXUS IS 300"},
            {3967172679, "LEXUS IS 350"},
            {-327794617, "LEXUS IS 350"},
            {608899747, "LEXUS IS F"},
            {-3686067549, "LEXUS IS F"},
            {3404495997, "LEXUS LFA"},
            {-890471299, "LEXUS LFA"},
            {826100022, "LOTUS ELISE 111R"},
            {-3468867274, "LOTUS ELISE 111R"},
            {2443315892, "LOTUS EUROPA S"},
            {-1851651404, "LOTUS EUROPA S"},
            {3652242210, "LOTUS EVORA"},
            {-642725086, "LOTUS EVORA"},
            {2400736834, "LOTUS EXIGE CUP 260"},
            {-1894230462, "LOTUS EXIGE CUP 260"},
            {3598578092, "MARUSSIA B2"},
            {-696389204, "MARUSSIA B2"},
            {2278634376, "MAZDA MX-5 MIATA"},
            {-2016332920, "MAZDA MX-5 MIATA"},
            {4243400612, "MAZDA RX-7"},
            {-51566684, "MAZDA RX-7"},
            {2233053554, "MAZDA RX-7 2ND"},
            {-2061913742, "MAZDA RX-7 2ND"},
            {1106440273, "MAZDA RX-7 RZ"},
            {-3188527023, "MAZDA RX-7 RZ"},
            {3593684023, "MAZDA RX-8"},
            {-701283273, "MAZDA RX-8"},
            {913728625, "MAZDA RX-8 '09"},
            {-3381238671, "MAZDA RX-8 '09"},
            {1886825490, "MAZDASPEED 3 '08"},
            {-2408141806, "MAZDASPEED 3 '08"},
            {2752968912, "MCLAREN F1 ELITE"},
            {-1541998384, "MCLAREN F1 ELITE"},
            {170263900, "MCLAREN MP4-12C"},
            {-4124703396, "MCLAREN MP4-12C"},
            {396212969, "MCLAREN MP4-12C 'BRAAAIIIINS' EDITION"},
            {-3898754327, "MCLAREN MP4-12C 'BRAAAIIIINS' EDITION"},
            {3523829773, "MERCEDES-BENZ SLR MCLAREN 722 EDITION"},
            {-771137523, "MERCEDES-BENZ SLR MCLAREN 722 EDITION"},
            {1524705036, "MITSUBISHI ECLIPSE GS-T"},
            {-2770262260, "MITSUBISHI ECLIPSE GS-T"},
            {1861278489, "MITSUBISHI ECLIPSE GS-T ELITE EDITION"},
            {-2433688807, "MITSUBISHI ECLIPSE GS-T ELITE EDITION"},
            {166450190, "MITSUBISHI ECLIPSE GT"},
            {-4128517106, "MITSUBISHI ECLIPSE GT"},
            {3438214070, "MITSUBISHI LANCER EVOLUTION VIII"},
            {-856753226, "MITSUBISHI LANCER EVOLUTION VIII"},
            {2101449805, "MITSUBISHI LANCER EVOLUTION IX MR-EDITION"},
            {-2193517491, "MITSUBISHI LANCER EVOLUTION IX MR-EDITION"},
            {1804573216, "MITSUBISHI LANCER EVOLUTION X"},
            {-2490394080, "MITSUBISHI LANCER EVOLUTION X"},
            {3038909480, "NFS WORLD BATTLEFIELD SUV #1"},
            {-1256057816, "NFS WORLD BATTLEFIELD SUV #1"},
            {342953166, "NFS WORLD BATTLEFIELD SUV #2"},
            {-3952014130, "NFS WORLD BATTLEFIELD SUV #2"},
            {813924329, "NFS WORLD RABBIT SUV"},
            {-3481042967, "NFS WORLD RABBIT SUV"},
            {3593096112, "NISSAN 200SX (S14)"},
            {-701871184, "NISSAN 200SX (S14)"},
            {2825858044, "NISSAN 240SX (S13)"},
            {-1469109252, "NISSAN 240SX (S13)"},
            {890471737, "NISSAN 350Z (Z33)"},
            {-3404495559, "NISSAN 350Z (Z33)"},
            {1965030943, "NISSAN 370Z (Z34)"},
            {-2329936353, "NISSAN 370Z (Z34)"},
            {3519223149, "NISSAN 370Z ROADSTER (Z34)"},
            {-775744147, "NISSAN 370Z ROADSTER (Z34)"},
            {1684160862, "NISSAN FAIRLADY 240ZG"},
            {-2610806434, "NISSAN FAIRLADY 240ZG"},
            {4217318880, "NISSAN GT-R (R35)"},
            {-77648416, "NISSAN GT-R (R35)"},
            {3981355351, "NISSAN GT-R SPECV (R35)"},
            {-313611945, "NISSAN GT-R SPECV (R35)"},
            {2903547464, "NISSAN R34 GT-R NISMO Z-TUNE"},
            {-1391419832, "NISSAN R34 GT-R NISMO Z-TUNE"},
            {3703742235, "NISSAN SILVIA S15"},
            {-591225061, "NISSAN SILVIA S15"},
            {2559752336, "NISSAN SKYLINE 2000GT-R (C10)"},
            {-1735214960, "NISSAN SKYLINE 2000GT-R (C10)"},
            {1454444272, "NISSAN SKYLINE GT-R (R32)"},
            {-2840523024, "NISSAN SKYLINE GT-R (R32)"},
            {3685220761, "NISSAN SKYLINE GT-R V-SPEC (R34)"},
            {-609746535, "NISSAN SKYLINE GT-R V-SPEC (R34)"},
            {2521436549, "PAGANI ZONDA CINQUE"},
            {-1773530747, "PAGANI ZONDA CINQUE"},
            {2908026505, "PAGANI ZONDA F"},
            {-1386940791, "PAGANI ZONDA F"},
            {3313383302, "PAGANI ZONDA F ROADSTER"},
            {-981583994, "PAGANI ZONDA F ROADSTER"},
            {1601041606, "PLYMOUTH HEMI CUDA"},
            {-2693925690, "PLYMOUTH HEMI CUDA"},
            {459783596, "PLYMOUTH ROAD RUNNER"},
            {-3835183700, "PLYMOUTH ROAD RUNNER"},
            {335414303, "PONTIAC FIREBIRD FORMULA"},
            {-3959552993, "PONTIAC FIREBIRD FORMULA"},
            {3873582052, "PONTIAC GTO"},
            {-421385244, "PONTIAC GTO"},
            {926809415, "PONTIAC SOLSTICE GXP"},
            {-3368157881, "PONTIAC SOLSTICE GXP"},
            {1170411476, "PORSCHE 911 CARRERA RSR 3.0"},
            {-3124555820, "PORSCHE 911 CARRERA RSR 3.0"},
            {1433115429, "PORSCHE 911 CARRERA S"},
            {-2861851867, "PORSCHE 911 CARRERA S"},
            {2604594287, "PORSCHE 911 GT2"},
            {-1690373009, "PORSCHE 911 GT2"},
            {3566516144, "PORSCHE 911 GT2 (997)"},
            {-728451152, "PORSCHE 911 GT2 (997)"},
            {1092157913, "PORSCHE 911 GT3 RS"},
            {-3202809383, "PORSCHE 911 GT3 RS"},
            {554050898, "PORSCHE 911 GT3 RS 4.0"},
            {-3740916398, "PORSCHE 911 GT3 RS 4.0"},
            {1518310457, "PORSCHE 911 TURBO"},
            {-2776656839, "PORSCHE 911 TURBO"},
            {2357465487, "PORSCHE 914-6 GT"},
            {-1937501809, "PORSCHE 914-6 GT"},
            {579778535, "PORSCHE 959"},
            {-3715188761, "PORSCHE 959"},
            {2975052995, "PORSCHE BOXSTER SPYDER"},
            {-1319914301, "PORSCHE BOXSTER SPYDER"},
            {1728462292, "PORSCHE CARRERA GT"},
            {-2566505004, "PORSCHE CARRERA GT"},
            {1096113131, "PORSCHE CAYMAN S"},
            {-3198854165, "PORSCHE CAYMAN S"},
            {1712914169, "PORSCHE CONCEPT 918 RSR"},
            {-2582053127, "PORSCHE CONCEPT 918 RSR"},
            {1851620885, "PORSCHE PANAMERA TURBO"},
            {-2443346411, "PORSCHE PANAMERA TURBO"},
            {3000637927, "RENAULT SPORT CLIO V6"},
            {-1294329369, "RENAULT SPORT CLIO V6"},
            {4285991974, "RENAULT SPORT MEGANE RS"},
            {-8975322, "RENAULT SPORT MEGANE RS"},
            {2753606463, "SCION TC"},
            {-1541360833, "SCION TC"},
            {3967174710, "SHELBY AC COBRA 427"},
            {-327792586, "SHELBY AC COBRA 427"},
            {1386210131, "SHELBY COBRA DAYTONA COUPE"},
            {-2908757165, "SHELBY COBRA DAYTONA COUPE"},
            {117677212, "SLR MCLAREN STIRLING MOSS"},
            {-4177290084, "SLR MCLAREN STIRLING MOSS"},
            {3098117036, "SUBARU IMPREZA WRX STI"},
            {-1196850260, "SUBARU IMPREZA WRX STI"},
            {1306578585, "SUBARU IMPREZA WRX STI (HATCHBACK)"},
            {-2988388711, "SUBARU IMPREZA WRX STI (HATCHBACK)"},
            {890389270, "TOYOTA COROLLA GT-S (AE86)"},
            {-3404578026, "TOYOTA COROLLA GT-S (AE86)"},
            {814288006, "TOYOTA MR2"},
            {-3480679290, "TOYOTA MR2"},
            {1727083572, "TOYOTA SUPRA"},
            {-2567883724, "TOYOTA SUPRA"},
            {2734558288, "VAUXHALL MONARO VXR"},
            {-1560409008, "VAUXHALL MONARO VXR"},
            {3794739586, "VOLKSWAGEN GOLF GTI"},
            {-500227710, "VOLKSWAGEN GOLF GTI"},
            {2485894945, "VOLKSWAGEN R32"},
            {-1809072351, "VOLKSWAGEN R32"},
            {2329071357, "VOLKSWAGEN SCIROCCO"},
            {-1965895939, "VOLKSWAGEN SCIROCCO"},
            {1998148470, "Dumptruck (player_dumptruck)"},
            {-2296818826, "Dumptruck (player_dumptruck)"},
            {2899963559, "Firetruck (player_firetruck)"},
            {-1395003737, "Firetruck (player_firetruck)"},
            {880729926, "Semi truck (cs_semi)"},
            {-3414237370, "Semi truck (cs_semi)"},
            {2503453879, "Police Cruiser (copmidsize_nis)"},
            {-1791513417, "Police Cruiser (copmidsize_nis)"},
            {3147508024, "Police Dodge Charger SRT-8 #1 (copmidsize)"},
            {-1147459272, "Police Dodge Charger SRT-8 #1 (copmidsize)"},
            {2893222352, "Police Dodge Charger SRT-8 #2 (copmidsize_ce)"},
            {-1401744944, "Police Dodge Charger SRT-8 #2 (copmidsize_ce)"},
            {1567506004, "Police Dodge Charger SRT-8 #3 (copmidsize_nis_ld)"},
            {-2727461292, "Police Dodge Charger SRT-8 #3 (copmidsize_nis_ld)"},
            {2758051216, "Police Dodge Charger SRT-8 #4 (copmidsize_weak)"},
            {-1536916080, "Police Dodge Charger SRT-8 #4 (copmidsize_weak)"},
            {670270267, "Police Dodge Charger SRT-8 #5 (copmidsize_escape)"},
            {-3624697029, "Police Dodge Charger SRT-8 #5 (copmidsize_escape)"},
            {4118654313, "Police Dodge Charger SRT-8 #6 (player_cop)"},
            {-176312983, "Police Dodge Charger SRT-8 #6 (player_cop)"},
            {2745291138, "Undercover Police Dodge Charger SRT-8 (copghost)"},
            {-1549676158, "Undercover Police Dodge Charger SRT-8 (copghost)"},
            {3432534870, "Police Pontiac GTO #1 (copgto)"},
            {-862432426, "Police Pontiac GTO #1 (copgto)"},
            {415375992, "Police Pontiac GTO #2 (copgto_escape)"},
            {-3879591304, "Police Pontiac GTO #2 (copgto_escape)"},
            {3924565494, "Undercover Police Pontiac GTO (copgtoghost)"},
            {-370401802, "Undercover Police Pontiac GTO (copgtoghost)"},
            {3446082958, "Police Muscle Car #1 (copcarmus08)"},
            {-848884338, "Police Muscle Car #1 (copcarmus08)"},
            {567053233, "Police Muscle Car #2 (copcarmus08_escape)"},
            {-3727914063, "Police Muscle Car #2 (copcarmus08_escape)"},
            {4167086461, "Undercover Police Muscle Car #1 (copcarmus08gh)"},
            {-127880835, "Undercover Police Muscle Car #1 (copcarmus08gh)"},
            {2263868110, "Undercover Police Muscle Car #2 (copcarmus08gh_escape)"},
            {-2031099186, "Undercover Police Muscle Car #2 (copcarmus08gh_escape)"},
            {3002281954, "Police Corvette #1 (copsporthench)"},
            {-1292685342, "Police Corvette #1 (copsporthench)"},
            {3560312949, "Police Corvette #2 (copsport_escape)"},
            {-734654347, "Police Corvette #2 (copsport_escape)"},
            {3006666286, "Police Corvette #3 (player_cop_corvette)"},
            {-1288301010, "Police Corvette #3 (player_cop_corvette)"},
            {2500824978, "Police Corvette #4 (player_cop_gto)"},
            {-1794142318, "Police Corvette #4 (player_cop_gto)"},
            {2766890632, "Undercover Police Corvette (copsportghost)"},
            {-1528076664, "Undercover Police Corvette (copsportghost)"},
            {2051656907, "Police Cross Corvette #1 (copsport)"},
            {-2243310389, "Police Cross Corvette #1 (copsport)"},
            {3548151917, "Police Cross Corvette #1 (copcross)"},
            {-746815379, "Police Cross Corvette #1 (copcross)"},
            {1420889656, "Police Light Rhino SUV (copsuvl)"},
            {-2874077640, "Police Light Rhino SUV (copsuvl)"},
            {951288358, "Police Heavy Rhino SUV #1 (copsuv)"},
            {-3343678938, "Police Heavy Rhino SUV #1 (copsuv)"},
            {773103276, "Police Heavy Rhino SUV #2 (copsuvpatrol)"},
            {-3521864020, "Police Heavy Rhino SUV #2 (copsuvpatrol)"},
            {1615846148, "Police Heavy Rhino SUV #3 (copsuv_escape)"},
            {-2679121148, "Police Heavy Rhino SUV #3 (copsuv_escape)"},
            {3500317914, "Police Heavy Rhino SUV #4 (player_cop_suv)"},
            {-794649382, "Police Heavy Rhino SUV #4 (player_cop_suv)"},
            {2705562036, "Police Heavy Rhino SUV #5 (cop_copsuv)"},
            {-1589405260, "Police Heavy Rhino SUV #5 (cop_copsuv)"},
            {105275058, "Police Helicopter #1 (copheli)"},
            {-4189692238, "Police Helicopter #1 (copheli)"},
            {2485624493, "Police Helicopter #2 (copter)"},
            {-1809342803, "Police Helicopter #2 (copter)"},
            {2697444185, "TRAFHA (Hatchback)"},
            {-1597523111, "TRAFHA (Hatchback)"},
            {3751483097, "TRAF4DSEDA (Sedan #1/\"Civillian\" Taxi)"},
            {-543484199, "TRAF4DSEDA (Sedan #1/\"Civillian\" Taxi)"},
            {3590420638, "TRAFTAXI (Taxi)"},
            {-704546658, "TRAFTAXI (Taxi)"},
            {1714104611, "TRAF4DSEDB (Sedan #2/\"Civillian\" Courtesy Car)"},
            {-2580862685, "TRAF4DSEDB (Sedan #2/\"Civillian\" Courtesy Car)"},
            {3866921014, "TRAFCOURT (Courtesy Car)"},
            {-428046282, "TRAFCOURT (Courtesy Car)"},
            {1394226312, "TRAFFICCOUP (Coupe)"},
            {-2900740984, "TRAFFICCOUP (Coupe)"},
            {1590265686, "TRAF4DSEDC (Sedan #3/Classic Sedan)"},
            {-2704701610, "TRAF4DSEDC (Sedan #3/Classic Sedan)"},
            {1137593283, "TRAFSTWAG (Station Wagon)"},
            {-3157374013, "TRAFSTWAG (Station Wagon)"},
            {2109639133, "TRAFPICKUPA (Pickup)"},
            {-2185328163, "TRAFPICKUPA (Pickup)"},
            {3872702185, "TRAFMINIVAN (Minivan)"},
            {-422265111, "TRAFMINIVAN (Minivan)"},
            {1049534608, "TRAFSUVA (SUV)"},
            {-3245432688, "TRAFSUVA (SUV)"},
            {1407692666, "TRAFVANB (Van)"},
            {-2887274630, "TRAFVANB (Van)"},
            {3686349938, "TRAFNEWS (News Van)"},
            {-608617358, "TRAFNEWS (News Van)"},
            {1869084661, "TRAFAMB (Ambulance)"},
            {-2425882635, "TRAFAMB (Ambulance)"},
            {3312194361, "TRAFDMPTR (Dumptruck)"},
            {-982772935, "TRAFDMPTR (Dumptruck)"},
            {3426097812, "TRAFGARB (Garbage Truck)"},
            {-868869484, "TRAFGARB (Garbage Truck)"},
            {1177767274, "TRAFCMTR (Cement Truck)"},
            {-3117200022, "TRAFCMTR (Cement Truck)"},
            {147320032, "TRAFFIRE (Firetruck)"},
            {-4147647264, "TRAFFIRE (Firetruck)"},
            {1749358113, "TRAFCAMPER (Camper)"},
            {-2545609183, "TRAFCAMPER (Camper)"},
            {3574286522, "SEMI (Truck with no trailer)"},
            {-720680774, "SEMI (Truck with no trailer)"},
            {3712834604, "SEMIA (Truck with Tanker)"},
            {-582132692, "SEMIA (Truck with Tanker)"},
            {14167946, "TRAILERA (Tank Trailer)"},
            {-4280799350, "TRAILERA (Tank Trailer)"},
            {2847214020, "SEMIB (Truck with Cars)"},
            {-1447753276, "SEMIB (Truck with Cars)"},
            {480926608, "TRAILERB (Trailer with Cars)"},
            {-3814040688, "TRAILERB (Trailer with Cars)"},
            {2792933787, "SEMIBOX (Truck with Autozone Trailer)"},
            {-1502033509, "SEMIBOX (Truck with Autozone Trailer)"},
            {2782182566, "TRAILERBOX (Autozone Trailer)"},
            {-1512784730, "TRAILERBOX (Autozone Trailer)"},
            {3223840706, "SEMICMT (Truck with Pipes)"},
            {-1071126590, "SEMICMT (Truck with Pipes)"},
            {923662918, "TRAILERCMT (Trailer with Pipes)"},
            {-3371304378, "TRAILERCMT (Trailer with Pipes)"},
            {621673210, "SEMICON (Truck with Containers)"},
            {-3673294086, "SEMICON (Truck with Containers)"},
            {1170647601, "TRAILERCON (Trailer Containers)"},
            {-3124319695, "TRAILERCON (Trailer Containers)"},
            {3908647713, "SEMICRATE (Truck with Boxes)"},
            {-386319583, "SEMICRATE (Truck with Boxes)"},
            {2699977158, "TRAILERCRATE (Trailer with Boxes)"},
            {-1594990138, "TRAILERCRATE (Trailer with Boxes)"},
            {177392743, "SEMILOG (Trailer with Logs)"},
            {-4117574553, "SEMILOG (Trailer with Logs)"},
            {3707500446, "TRAILERLOG (Trailer with Logs)"},
            {-587466850, "TRAILERLOG (Trailer with Logs)"},
            {4123572107, "AAA (Test Car)"},
            {-171395189, "AAA (Test Car)"},
            {3718574377, "BMW M3 E46"},
            {-576392919, "BMW M3 E46"},
            {1309171635, "BMW M3 GTR E46 RACE"},
            {-2985795661, "BMW M3 GTR E46 RACE"},
            {3531430797, "PORSCHE 911 TURBO S (996)"},
            {-763536499, "PORSCHE 911 TURBO S (996)"},
            {3239158528, "LOTUS EXIGE (2008)"},
            {-1055808768, "LOTUS EXIGE (2008)"},
            {1340781260, "RENAULT MÉGANE COUPÉ"},
            {-2954186036, "RENAULT MÉGANE COUPÉ"}
        };

        public static readonly Dictionary<Int64, String> BaseCarIdDefinitions = new Dictionary<Int64, String>()
        {
            {461323600, "ALFA ROMEO 8C COMPETIZIONE"},
            {40376, "ASTON MARTIN DBS"},
            {1153363998, "ASTON MARTIN VANTAGE V12"},
            {56149, "AUDI A1 CLUBSPORT QUATTRO"},
            {-691868261, "AUDI A3 3.2 QUATTRO"},
            {2090374038, "AUDI QUATTRO 20 V"},
            {1673, "AUDI R8 4.2 FSI QUATTRO"},
            {60217920, "AUDI R8 COUPE 5.2 FSI QUATTRO"},
            {-691868389, "AUDI R8 LMS ULTRA"},
            {56152, "AUDI RS 4"},
            {1703, "AUDI S5"},
            {2098561293, "AUDI TT RS COUPE"},
            {334671939, "BENTLEY CONTINENTAL SUPERSPORTS CONVERTIBLE"},
            {-147456602, "BENTLEY CONTINENTAL SUPERSPORTS COUPE"},
            {-1293405201, "BMW 135i COUPE"},
            {41998979, "BMW 1M"},
            {-1507688326, "BMW 3.0 CSL"},
            {-1967974518, "BMW M1 PROCAR (1979)"},
            {1816135925, "BMW M3 E92"},
            {1816139026, "BMW M3 GTR E46"},
            {1816139027, "BMW M3 GTS"},
            {1816135725, "BMW M3 SPORT EVOLUTION"},
            {-193545762, "BMW M6 CONVERTIBLE"},
            {41999880, "BMW M6 COUPE"},
            {1831591905, "BMW Z4 GT3"},
            {1933, "BMW Z4 M COUPE"},
            {-691868228, "BUGATTI VEYRON 16.4"},
            {1316159, "CADILLAC CTS-V"},
            {1443310131, "CAR_MANU_GENERIC CAR_MDL_TRAFVANB"},
            {-691868226, "CATERHAM R500 SUPERLIGHT"},
            {1410528946, "CHEVROLET CAMARO SS"},
            {974805577, "CHEVROLET CAMARO ZL1"},
            {16618735, "CHEVROLET CAMARO ZL1 ELITE"},
            {-1370575257, "CHEVROLET CHEVELLE SS"},
            {-691868325, "CHEVROLET COBALT"},
            {-1408763688, "CHEVROLET CORVETTE STINGRAY"},
            {755477579, "CHEVROLET CORVETTE Z06"},
            {434493780, "CHEVROLET CORVETTE Z06 CARBON LIMITED EDITION"},
            {755478696, "CHEVROLET CORVETTE ZR1"},
            {-1265021465, "CHEVROLET EL CAMINO SS"},
            {700789, "CHRYSLER 300C"},
            {290872130, "DODGE CHALLENGER CONCEPT"},
            {1008844988, "DODGE CHALLENGER R/T"},
            {990337002, "DODGE CHARGER R/T"},
            {1634713038, "DODGE CHARGER SRT8 SUPER BEE"},
            {-1666705986, "DODGE VIPER SRT10"},
            {1711519800, "DODGE VIPER SRT10 ACR ELITE"},
            {-691868288, "FORD CAPRI RS3100"},
            {-947943862, "FORD CROWN VICTORIA COP"},
            {-370786472, "FORD ESCORT RS COSWORTH"},
            {-691868358, "FORD Escort MK1 RS1600 FIA Group 2"},
            {-691868360, "FORD F-150 SVT RAPTOR"},
            {-1340228859, "FORD FOCUS RS"},
            {1544720613, "FORD GT"},
            {-1426430711, "FORD GT40 MK.I"},
            {-691868290, "FORD INTERCEPTOR"},
            {-691868255, "FORD LOTUS CORTINA"},
            {-26123784, "FORD MUSTANG BOSS 302 '12"},
            {-26123612, "FORD MUSTANG BOSS 302 '69"},
            {2020296126, "FORD MUSTANG RTR-X"},
            {529336918, "FORD SHELBY GT500 SUPER SNAKE"},
            {1095591178, "FORD SHELBY TERLINGUA"},
            {-691868352, "HUMMER H1"},
            {-691868257, "HUMMER H1 ALPHA"},
            {43118, "INFINITI G35"},
            {1925678880, "JAGUAR E-TYPE LIGHTWEIGHT"},
            {-921096850, "JAGUAR XKR"},
            {-691868222, "JEEP GRAND CHEROKEE SRT"},
            {-691868319, "KOENIGSEGG AGERA"},
            {39325, "KOENIGSEGG CCX"},
            {-1606457066, "KOENIGSEGG CCX ELITE"},
            {-691868327, "KOENIGSEGG CCXR EDITION"},
            {-691868323, "LAMBORGHINI AVENTADOR LP700-4"},
            {-303028364, "LAMBORGHINI COUNTACH 5000 QUATTROVALVOLE"},
            {1458721354, "LAMBORGHINI DIABLO SV"},
            {-691868259, "LAMBORGHINI ESTOQUE"},
            {837621662, "LAMBORGHINI GALLARDO LP 550-2 VALENTINO BALBONI"},
            {1913185783, "LAMBORGHINI GALLARDO LP 560-4 SPYDER"},
            {-930004306, "LAMBORGHINI GALLARDO LP560-4"},
            {-691868220, "LAMBORGHINI MIURA CONCEPT"},
            {-344244090, "LAMBORGHINI MIURA SV"},
            {133082177, "LAMBORGHINI MURCIELAGO LP 640"},
            {133082210, "LAMBORGHINI MURCIELAGO LP 650-4 ROADSTER"},
            {1305539024, "LAMBORGHINI MURCIELAGO SV"},
            {-691868420, "LAMBORGHINI REVENTON"},
            {-402882280, "LAMBORGHINI SESTO ELEMENTO"},
            {44072489, "LANCIA DELTA HF INTEGRALE EVOLUZIONE"},
            {46369, "LEXUS IS-F"},
            {50476782, "LEXUS IS300"},
            {50476947, "LEXUS IS350"},
            {1106775043, "LEXUS LFA"},
            {45506673, "LOTUS ELISE"},
            {1512713003, "LOTUS EUROPA S"},
            {45872540, "LOTUS EVORA"},
            {1146389329, "LOTUS EXIGE CUP 260"},
            {-691868387, "MARUSSIA B2"},
            {-87126832, "MAZDA MAZDASPEED 3"},
            {55402337, "MAZDA MX-5"},
            {56320, "MAZDA RX-7"},
            {-691868354, "MAZDA RX-7 FC3S"},
            {61335276, "MAZDA RX-7 RZ"},
            {56321, "MAZDA RX-8"},
            {-1925369332, "MAZDA RX-8 '09"},
            {-691868418, "MCLAREN F1 ELITE"},
            {-1580541262, "MCLAREN MP4-12C"},
            {-691868385, "MCLAREN MP4-12C HALOWEEN"},
            {-691868224, "MERCEDES MCLAREN STIRLING MOSS"},
            {2049908075, "MERCEDES-BENZ SLR 722 McLaren 722 Edition"},
            {-691868391, "MITSUBISHI ECLIPSE"},
            {-1546676681, "MITSUBISHI ECLIPSE ELITE"},
            {-1054632705, "MITSUBISHI ECLIPSE GT"},
            {164818934, "MITSUBISHI LANCER EVO VIII"},
            {164818935, "MITSUBISHI LANCER EVOLUTION IX MR-EDITION"},
            {164818966, "MITSUBISHI LANCER EVOLUTION X"},
            {1137479728, "NFS BATTLEFIELD 1"},
            {1137479729, "NFS BATTLEFIELD 2"},
            {-323834537, "NISSAN 2000 GT-R"},
            {21940732, "NISSAN 200SX (S14)"},
            {22084480, "NISSAN 240SX (S13)"},
            {706257, "NISSAN 350Z (Z33)"},
            {708435, "NISSAN 370Z (Z34)"},
            {-659675369, "NISSAN 370Z ROADSTER"},
            {-1719570146, "NISSAN FAIRLADY 240ZG"},
            {-1750743496, "NISSAN GT-R (R35)"},
            {-1939960434, "NISSAN GT-R SpecV (R35)"},
            {-691868393, "NISSAN NISMO R34GT-R Z-Tune"},
            {-951615808, "NISSAN SILVIA (S15)"},
            {-1750743499, "NISSAN SKYLINE GT-R (R32)"},
            {-1102563490, "NISSAN SKYLINE R34 V-SPEC"},
            {-691868422, "PAGANI ZONDA CINQUE"},
            {70523771, "PAGANI ZONDA F"},
            {450173759, "PAGANI ZONDA F ROADSTER"},
            {1316732, "PLYMOUTH HEMI CUDA"},
            {-317646849, "PLYMOUTH ROAD RUNNER"},
            {-656975595, "PONTIAC FIREBIRD FORMULA"},
            {48171572, "PONTIAC GTO '65"},
            {1794097140, "PONTIAC SOLSTICE GXP"},
            {1515789756, "PORSCHE 911 CARRERA RSR 3.0"},
            {926261, "PORSCHE 911 CARRERA S"},
            {999200615, "PORSCHE 911 GT2 (996)"},
            {1502747725, "PORSCHE 911 GT3 RS"},
            {-691868424, "PORSCHE 911 GT3 RS 4.0"},
            {30573264, "PORSCHE 911 TURBO"},
            {-691868294, "PORSCHE 914-6 GT"},
            {27942, "PORSCHE 959"},
            {-740942307, "PORSCHE BOXSTER SPYDER"},
            {-507824006, "PORSCHE CARRERA GT"},
            {-682541205, "PORSCHE CAYMAN S"},
            {1008903605, "PORSCHE GT2 (997)"},
            {-1848802011, "PORSCHE PANAMERA TURBO"},
            {-467126062, "RENAULT MEGANE RS 10"},
            {1423445682, "RENAULT SPORT CLIO V6"},
            {-1434507918, "SCION tC"},
            {661194635, "SHELBY COBRA DAYTONA COUPE"},
            {-691868286, "SHELBY COBRA 427 S/C"},
            {-376520152, "SUBARU IMPREZA WRX STI"},
            {-1317604272, "SUBARU IMPREZA WRX STI (HATCHBACK)"},
            {-142863381, "TOYOTA COROLLA GT-S (AE86)"},
            {50672, "TOYOTA MR2"},
            {62440586, "TOYOTA SUPRA"},
            {1589472076, "VOLKSWAGEN GOLF MK1 GTI"},
            {55094, "VOLKSWAGEN R32"},
            {-90545772, "VOLKSWAGEN SCIROCCO"}
        };

        /// <summary>
        /// Converts the given car data to its equivalent car make and model string if definition is present.
        /// </summary>
        /// <param name="PhysicsProfileHash">Car's PhysicsProfileHash entry</param>
        /// <param name="checkForBaseCarId">Whether to search in BaseCarIdDefinitions too</param>
        /// <param name="BaseCarId">Car's BaseCar entry. MUST BE GIVEN IF checkForBaseCarId IS TRUE.</param>
        /// <returns>If found, car make and model. If not found, Hash + [NO DEF]</returns>
        public static String Define(Int64 PhysicsProfileHash, Boolean checkForBaseCarId = false, Int64 BaseCarId = 0)
        {
            String CarMakeModel;
            if (!PhysicsProfileHashDefinitions.TryGetValue(PhysicsProfileHash, out CarMakeModel))
            {
                CarMakeModel = PhysicsProfileHash.ToString() + " [NO DEF]";
                if (checkForBaseCarId)
                {
                    if (!BaseCarIdDefinitions.TryGetValue(BaseCarId, out CarMakeModel))
                    {
                        CarMakeModel = PhysicsProfileHash.ToString() + " [NO DEF]";
                    }
                }
            }
            return CarMakeModel;
        }

        /// <summary>
        /// Converts the given BaseCarId to its equivalent car make and model string if definition is present.
        /// </summary>
        /// <param name="BaseCarId">Car's BaseCar entry</param>
        /// <returns>If found, car make and model. If not found, 'Definition isn't present.'</returns>
        public static String DefineFromBaseCarId(Int64 BaseCarId)
        {
            String CarMakeModel;
            if (!BaseCarIdDefinitions.TryGetValue(BaseCarId, out CarMakeModel)) CarMakeModel = "Definition isn't present.";
            return CarMakeModel;
        }
    }
}