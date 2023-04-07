/*
 * App Store Connect API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 2.3
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using FileParameter = AppStoreConnect.Client.FileParameter;
using OpenAPIDateConverter = AppStoreConnect.Client.OpenAPIDateConverter;

namespace AppStoreConnect.Model
{
    /// <summary>
    /// Defines TerritoryCode
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TerritoryCode
    {
        /// <summary>
        /// Enum ABW for value: ABW
        /// </summary>
        [EnumMember(Value = "ABW")]
        ABW = 1,

        /// <summary>
        /// Enum AFG for value: AFG
        /// </summary>
        [EnumMember(Value = "AFG")]
        AFG = 2,

        /// <summary>
        /// Enum AGO for value: AGO
        /// </summary>
        [EnumMember(Value = "AGO")]
        AGO = 3,

        /// <summary>
        /// Enum AIA for value: AIA
        /// </summary>
        [EnumMember(Value = "AIA")]
        AIA = 4,

        /// <summary>
        /// Enum ALB for value: ALB
        /// </summary>
        [EnumMember(Value = "ALB")]
        ALB = 5,

        /// <summary>
        /// Enum AND for value: AND
        /// </summary>
        [EnumMember(Value = "AND")]
        AND = 6,

        /// <summary>
        /// Enum ANT for value: ANT
        /// </summary>
        [EnumMember(Value = "ANT")]
        ANT = 7,

        /// <summary>
        /// Enum ARE for value: ARE
        /// </summary>
        [EnumMember(Value = "ARE")]
        ARE = 8,

        /// <summary>
        /// Enum ARG for value: ARG
        /// </summary>
        [EnumMember(Value = "ARG")]
        ARG = 9,

        /// <summary>
        /// Enum ARM for value: ARM
        /// </summary>
        [EnumMember(Value = "ARM")]
        ARM = 10,

        /// <summary>
        /// Enum ASM for value: ASM
        /// </summary>
        [EnumMember(Value = "ASM")]
        ASM = 11,

        /// <summary>
        /// Enum ATG for value: ATG
        /// </summary>
        [EnumMember(Value = "ATG")]
        ATG = 12,

        /// <summary>
        /// Enum AUS for value: AUS
        /// </summary>
        [EnumMember(Value = "AUS")]
        AUS = 13,

        /// <summary>
        /// Enum AUT for value: AUT
        /// </summary>
        [EnumMember(Value = "AUT")]
        AUT = 14,

        /// <summary>
        /// Enum AZE for value: AZE
        /// </summary>
        [EnumMember(Value = "AZE")]
        AZE = 15,

        /// <summary>
        /// Enum BDI for value: BDI
        /// </summary>
        [EnumMember(Value = "BDI")]
        BDI = 16,

        /// <summary>
        /// Enum BEL for value: BEL
        /// </summary>
        [EnumMember(Value = "BEL")]
        BEL = 17,

        /// <summary>
        /// Enum BEN for value: BEN
        /// </summary>
        [EnumMember(Value = "BEN")]
        BEN = 18,

        /// <summary>
        /// Enum BES for value: BES
        /// </summary>
        [EnumMember(Value = "BES")]
        BES = 19,

        /// <summary>
        /// Enum BFA for value: BFA
        /// </summary>
        [EnumMember(Value = "BFA")]
        BFA = 20,

        /// <summary>
        /// Enum BGD for value: BGD
        /// </summary>
        [EnumMember(Value = "BGD")]
        BGD = 21,

        /// <summary>
        /// Enum BGR for value: BGR
        /// </summary>
        [EnumMember(Value = "BGR")]
        BGR = 22,

        /// <summary>
        /// Enum BHR for value: BHR
        /// </summary>
        [EnumMember(Value = "BHR")]
        BHR = 23,

        /// <summary>
        /// Enum BHS for value: BHS
        /// </summary>
        [EnumMember(Value = "BHS")]
        BHS = 24,

        /// <summary>
        /// Enum BIH for value: BIH
        /// </summary>
        [EnumMember(Value = "BIH")]
        BIH = 25,

        /// <summary>
        /// Enum BLR for value: BLR
        /// </summary>
        [EnumMember(Value = "BLR")]
        BLR = 26,

        /// <summary>
        /// Enum BLZ for value: BLZ
        /// </summary>
        [EnumMember(Value = "BLZ")]
        BLZ = 27,

        /// <summary>
        /// Enum BMU for value: BMU
        /// </summary>
        [EnumMember(Value = "BMU")]
        BMU = 28,

        /// <summary>
        /// Enum BOL for value: BOL
        /// </summary>
        [EnumMember(Value = "BOL")]
        BOL = 29,

        /// <summary>
        /// Enum BRA for value: BRA
        /// </summary>
        [EnumMember(Value = "BRA")]
        BRA = 30,

        /// <summary>
        /// Enum BRB for value: BRB
        /// </summary>
        [EnumMember(Value = "BRB")]
        BRB = 31,

        /// <summary>
        /// Enum BRN for value: BRN
        /// </summary>
        [EnumMember(Value = "BRN")]
        BRN = 32,

        /// <summary>
        /// Enum BTN for value: BTN
        /// </summary>
        [EnumMember(Value = "BTN")]
        BTN = 33,

        /// <summary>
        /// Enum BWA for value: BWA
        /// </summary>
        [EnumMember(Value = "BWA")]
        BWA = 34,

        /// <summary>
        /// Enum CAF for value: CAF
        /// </summary>
        [EnumMember(Value = "CAF")]
        CAF = 35,

        /// <summary>
        /// Enum CAN for value: CAN
        /// </summary>
        [EnumMember(Value = "CAN")]
        CAN = 36,

        /// <summary>
        /// Enum CHE for value: CHE
        /// </summary>
        [EnumMember(Value = "CHE")]
        CHE = 37,

        /// <summary>
        /// Enum CHL for value: CHL
        /// </summary>
        [EnumMember(Value = "CHL")]
        CHL = 38,

        /// <summary>
        /// Enum CHN for value: CHN
        /// </summary>
        [EnumMember(Value = "CHN")]
        CHN = 39,

        /// <summary>
        /// Enum CIV for value: CIV
        /// </summary>
        [EnumMember(Value = "CIV")]
        CIV = 40,

        /// <summary>
        /// Enum CMR for value: CMR
        /// </summary>
        [EnumMember(Value = "CMR")]
        CMR = 41,

        /// <summary>
        /// Enum COD for value: COD
        /// </summary>
        [EnumMember(Value = "COD")]
        COD = 42,

        /// <summary>
        /// Enum COG for value: COG
        /// </summary>
        [EnumMember(Value = "COG")]
        COG = 43,

        /// <summary>
        /// Enum COK for value: COK
        /// </summary>
        [EnumMember(Value = "COK")]
        COK = 44,

        /// <summary>
        /// Enum COL for value: COL
        /// </summary>
        [EnumMember(Value = "COL")]
        COL = 45,

        /// <summary>
        /// Enum COM for value: COM
        /// </summary>
        [EnumMember(Value = "COM")]
        COM = 46,

        /// <summary>
        /// Enum CPV for value: CPV
        /// </summary>
        [EnumMember(Value = "CPV")]
        CPV = 47,

        /// <summary>
        /// Enum CRI for value: CRI
        /// </summary>
        [EnumMember(Value = "CRI")]
        CRI = 48,

        /// <summary>
        /// Enum CUB for value: CUB
        /// </summary>
        [EnumMember(Value = "CUB")]
        CUB = 49,

        /// <summary>
        /// Enum CUW for value: CUW
        /// </summary>
        [EnumMember(Value = "CUW")]
        CUW = 50,

        /// <summary>
        /// Enum CXR for value: CXR
        /// </summary>
        [EnumMember(Value = "CXR")]
        CXR = 51,

        /// <summary>
        /// Enum CYM for value: CYM
        /// </summary>
        [EnumMember(Value = "CYM")]
        CYM = 52,

        /// <summary>
        /// Enum CYP for value: CYP
        /// </summary>
        [EnumMember(Value = "CYP")]
        CYP = 53,

        /// <summary>
        /// Enum CZE for value: CZE
        /// </summary>
        [EnumMember(Value = "CZE")]
        CZE = 54,

        /// <summary>
        /// Enum DEU for value: DEU
        /// </summary>
        [EnumMember(Value = "DEU")]
        DEU = 55,

        /// <summary>
        /// Enum DJI for value: DJI
        /// </summary>
        [EnumMember(Value = "DJI")]
        DJI = 56,

        /// <summary>
        /// Enum DMA for value: DMA
        /// </summary>
        [EnumMember(Value = "DMA")]
        DMA = 57,

        /// <summary>
        /// Enum DNK for value: DNK
        /// </summary>
        [EnumMember(Value = "DNK")]
        DNK = 58,

        /// <summary>
        /// Enum DOM for value: DOM
        /// </summary>
        [EnumMember(Value = "DOM")]
        DOM = 59,

        /// <summary>
        /// Enum DZA for value: DZA
        /// </summary>
        [EnumMember(Value = "DZA")]
        DZA = 60,

        /// <summary>
        /// Enum ECU for value: ECU
        /// </summary>
        [EnumMember(Value = "ECU")]
        ECU = 61,

        /// <summary>
        /// Enum EGY for value: EGY
        /// </summary>
        [EnumMember(Value = "EGY")]
        EGY = 62,

        /// <summary>
        /// Enum ERI for value: ERI
        /// </summary>
        [EnumMember(Value = "ERI")]
        ERI = 63,

        /// <summary>
        /// Enum ESP for value: ESP
        /// </summary>
        [EnumMember(Value = "ESP")]
        ESP = 64,

        /// <summary>
        /// Enum EST for value: EST
        /// </summary>
        [EnumMember(Value = "EST")]
        EST = 65,

        /// <summary>
        /// Enum ETH for value: ETH
        /// </summary>
        [EnumMember(Value = "ETH")]
        ETH = 66,

        /// <summary>
        /// Enum FIN for value: FIN
        /// </summary>
        [EnumMember(Value = "FIN")]
        FIN = 67,

        /// <summary>
        /// Enum FJI for value: FJI
        /// </summary>
        [EnumMember(Value = "FJI")]
        FJI = 68,

        /// <summary>
        /// Enum FLK for value: FLK
        /// </summary>
        [EnumMember(Value = "FLK")]
        FLK = 69,

        /// <summary>
        /// Enum FRA for value: FRA
        /// </summary>
        [EnumMember(Value = "FRA")]
        FRA = 70,

        /// <summary>
        /// Enum FRO for value: FRO
        /// </summary>
        [EnumMember(Value = "FRO")]
        FRO = 71,

        /// <summary>
        /// Enum FSM for value: FSM
        /// </summary>
        [EnumMember(Value = "FSM")]
        FSM = 72,

        /// <summary>
        /// Enum GAB for value: GAB
        /// </summary>
        [EnumMember(Value = "GAB")]
        GAB = 73,

        /// <summary>
        /// Enum GBR for value: GBR
        /// </summary>
        [EnumMember(Value = "GBR")]
        GBR = 74,

        /// <summary>
        /// Enum GEO for value: GEO
        /// </summary>
        [EnumMember(Value = "GEO")]
        GEO = 75,

        /// <summary>
        /// Enum GGY for value: GGY
        /// </summary>
        [EnumMember(Value = "GGY")]
        GGY = 76,

        /// <summary>
        /// Enum GHA for value: GHA
        /// </summary>
        [EnumMember(Value = "GHA")]
        GHA = 77,

        /// <summary>
        /// Enum GIB for value: GIB
        /// </summary>
        [EnumMember(Value = "GIB")]
        GIB = 78,

        /// <summary>
        /// Enum GIN for value: GIN
        /// </summary>
        [EnumMember(Value = "GIN")]
        GIN = 79,

        /// <summary>
        /// Enum GLP for value: GLP
        /// </summary>
        [EnumMember(Value = "GLP")]
        GLP = 80,

        /// <summary>
        /// Enum GMB for value: GMB
        /// </summary>
        [EnumMember(Value = "GMB")]
        GMB = 81,

        /// <summary>
        /// Enum GNB for value: GNB
        /// </summary>
        [EnumMember(Value = "GNB")]
        GNB = 82,

        /// <summary>
        /// Enum GNQ for value: GNQ
        /// </summary>
        [EnumMember(Value = "GNQ")]
        GNQ = 83,

        /// <summary>
        /// Enum GRC for value: GRC
        /// </summary>
        [EnumMember(Value = "GRC")]
        GRC = 84,

        /// <summary>
        /// Enum GRD for value: GRD
        /// </summary>
        [EnumMember(Value = "GRD")]
        GRD = 85,

        /// <summary>
        /// Enum GRL for value: GRL
        /// </summary>
        [EnumMember(Value = "GRL")]
        GRL = 86,

        /// <summary>
        /// Enum GTM for value: GTM
        /// </summary>
        [EnumMember(Value = "GTM")]
        GTM = 87,

        /// <summary>
        /// Enum GUF for value: GUF
        /// </summary>
        [EnumMember(Value = "GUF")]
        GUF = 88,

        /// <summary>
        /// Enum GUM for value: GUM
        /// </summary>
        [EnumMember(Value = "GUM")]
        GUM = 89,

        /// <summary>
        /// Enum GUY for value: GUY
        /// </summary>
        [EnumMember(Value = "GUY")]
        GUY = 90,

        /// <summary>
        /// Enum HKG for value: HKG
        /// </summary>
        [EnumMember(Value = "HKG")]
        HKG = 91,

        /// <summary>
        /// Enum HND for value: HND
        /// </summary>
        [EnumMember(Value = "HND")]
        HND = 92,

        /// <summary>
        /// Enum HRV for value: HRV
        /// </summary>
        [EnumMember(Value = "HRV")]
        HRV = 93,

        /// <summary>
        /// Enum HTI for value: HTI
        /// </summary>
        [EnumMember(Value = "HTI")]
        HTI = 94,

        /// <summary>
        /// Enum HUN for value: HUN
        /// </summary>
        [EnumMember(Value = "HUN")]
        HUN = 95,

        /// <summary>
        /// Enum IDN for value: IDN
        /// </summary>
        [EnumMember(Value = "IDN")]
        IDN = 96,

        /// <summary>
        /// Enum IMN for value: IMN
        /// </summary>
        [EnumMember(Value = "IMN")]
        IMN = 97,

        /// <summary>
        /// Enum IND for value: IND
        /// </summary>
        [EnumMember(Value = "IND")]
        IND = 98,

        /// <summary>
        /// Enum IRL for value: IRL
        /// </summary>
        [EnumMember(Value = "IRL")]
        IRL = 99,

        /// <summary>
        /// Enum IRQ for value: IRQ
        /// </summary>
        [EnumMember(Value = "IRQ")]
        IRQ = 100,

        /// <summary>
        /// Enum ISL for value: ISL
        /// </summary>
        [EnumMember(Value = "ISL")]
        ISL = 101,

        /// <summary>
        /// Enum ISR for value: ISR
        /// </summary>
        [EnumMember(Value = "ISR")]
        ISR = 102,

        /// <summary>
        /// Enum ITA for value: ITA
        /// </summary>
        [EnumMember(Value = "ITA")]
        ITA = 103,

        /// <summary>
        /// Enum JAM for value: JAM
        /// </summary>
        [EnumMember(Value = "JAM")]
        JAM = 104,

        /// <summary>
        /// Enum JEY for value: JEY
        /// </summary>
        [EnumMember(Value = "JEY")]
        JEY = 105,

        /// <summary>
        /// Enum JOR for value: JOR
        /// </summary>
        [EnumMember(Value = "JOR")]
        JOR = 106,

        /// <summary>
        /// Enum JPN for value: JPN
        /// </summary>
        [EnumMember(Value = "JPN")]
        JPN = 107,

        /// <summary>
        /// Enum KAZ for value: KAZ
        /// </summary>
        [EnumMember(Value = "KAZ")]
        KAZ = 108,

        /// <summary>
        /// Enum KEN for value: KEN
        /// </summary>
        [EnumMember(Value = "KEN")]
        KEN = 109,

        /// <summary>
        /// Enum KGZ for value: KGZ
        /// </summary>
        [EnumMember(Value = "KGZ")]
        KGZ = 110,

        /// <summary>
        /// Enum KHM for value: KHM
        /// </summary>
        [EnumMember(Value = "KHM")]
        KHM = 111,

        /// <summary>
        /// Enum KIR for value: KIR
        /// </summary>
        [EnumMember(Value = "KIR")]
        KIR = 112,

        /// <summary>
        /// Enum KNA for value: KNA
        /// </summary>
        [EnumMember(Value = "KNA")]
        KNA = 113,

        /// <summary>
        /// Enum KOR for value: KOR
        /// </summary>
        [EnumMember(Value = "KOR")]
        KOR = 114,

        /// <summary>
        /// Enum KWT for value: KWT
        /// </summary>
        [EnumMember(Value = "KWT")]
        KWT = 115,

        /// <summary>
        /// Enum LAO for value: LAO
        /// </summary>
        [EnumMember(Value = "LAO")]
        LAO = 116,

        /// <summary>
        /// Enum LBN for value: LBN
        /// </summary>
        [EnumMember(Value = "LBN")]
        LBN = 117,

        /// <summary>
        /// Enum LBR for value: LBR
        /// </summary>
        [EnumMember(Value = "LBR")]
        LBR = 118,

        /// <summary>
        /// Enum LBY for value: LBY
        /// </summary>
        [EnumMember(Value = "LBY")]
        LBY = 119,

        /// <summary>
        /// Enum LCA for value: LCA
        /// </summary>
        [EnumMember(Value = "LCA")]
        LCA = 120,

        /// <summary>
        /// Enum LIE for value: LIE
        /// </summary>
        [EnumMember(Value = "LIE")]
        LIE = 121,

        /// <summary>
        /// Enum LKA for value: LKA
        /// </summary>
        [EnumMember(Value = "LKA")]
        LKA = 122,

        /// <summary>
        /// Enum LSO for value: LSO
        /// </summary>
        [EnumMember(Value = "LSO")]
        LSO = 123,

        /// <summary>
        /// Enum LTU for value: LTU
        /// </summary>
        [EnumMember(Value = "LTU")]
        LTU = 124,

        /// <summary>
        /// Enum LUX for value: LUX
        /// </summary>
        [EnumMember(Value = "LUX")]
        LUX = 125,

        /// <summary>
        /// Enum LVA for value: LVA
        /// </summary>
        [EnumMember(Value = "LVA")]
        LVA = 126,

        /// <summary>
        /// Enum MAC for value: MAC
        /// </summary>
        [EnumMember(Value = "MAC")]
        MAC = 127,

        /// <summary>
        /// Enum MAR for value: MAR
        /// </summary>
        [EnumMember(Value = "MAR")]
        MAR = 128,

        /// <summary>
        /// Enum MCO for value: MCO
        /// </summary>
        [EnumMember(Value = "MCO")]
        MCO = 129,

        /// <summary>
        /// Enum MDA for value: MDA
        /// </summary>
        [EnumMember(Value = "MDA")]
        MDA = 130,

        /// <summary>
        /// Enum MDG for value: MDG
        /// </summary>
        [EnumMember(Value = "MDG")]
        MDG = 131,

        /// <summary>
        /// Enum MDV for value: MDV
        /// </summary>
        [EnumMember(Value = "MDV")]
        MDV = 132,

        /// <summary>
        /// Enum MEX for value: MEX
        /// </summary>
        [EnumMember(Value = "MEX")]
        MEX = 133,

        /// <summary>
        /// Enum MHL for value: MHL
        /// </summary>
        [EnumMember(Value = "MHL")]
        MHL = 134,

        /// <summary>
        /// Enum MKD for value: MKD
        /// </summary>
        [EnumMember(Value = "MKD")]
        MKD = 135,

        /// <summary>
        /// Enum MLI for value: MLI
        /// </summary>
        [EnumMember(Value = "MLI")]
        MLI = 136,

        /// <summary>
        /// Enum MLT for value: MLT
        /// </summary>
        [EnumMember(Value = "MLT")]
        MLT = 137,

        /// <summary>
        /// Enum MMR for value: MMR
        /// </summary>
        [EnumMember(Value = "MMR")]
        MMR = 138,

        /// <summary>
        /// Enum MNE for value: MNE
        /// </summary>
        [EnumMember(Value = "MNE")]
        MNE = 139,

        /// <summary>
        /// Enum MNG for value: MNG
        /// </summary>
        [EnumMember(Value = "MNG")]
        MNG = 140,

        /// <summary>
        /// Enum MNP for value: MNP
        /// </summary>
        [EnumMember(Value = "MNP")]
        MNP = 141,

        /// <summary>
        /// Enum MOZ for value: MOZ
        /// </summary>
        [EnumMember(Value = "MOZ")]
        MOZ = 142,

        /// <summary>
        /// Enum MRT for value: MRT
        /// </summary>
        [EnumMember(Value = "MRT")]
        MRT = 143,

        /// <summary>
        /// Enum MSR for value: MSR
        /// </summary>
        [EnumMember(Value = "MSR")]
        MSR = 144,

        /// <summary>
        /// Enum MTQ for value: MTQ
        /// </summary>
        [EnumMember(Value = "MTQ")]
        MTQ = 145,

        /// <summary>
        /// Enum MUS for value: MUS
        /// </summary>
        [EnumMember(Value = "MUS")]
        MUS = 146,

        /// <summary>
        /// Enum MWI for value: MWI
        /// </summary>
        [EnumMember(Value = "MWI")]
        MWI = 147,

        /// <summary>
        /// Enum MYS for value: MYS
        /// </summary>
        [EnumMember(Value = "MYS")]
        MYS = 148,

        /// <summary>
        /// Enum MYT for value: MYT
        /// </summary>
        [EnumMember(Value = "MYT")]
        MYT = 149,

        /// <summary>
        /// Enum NAM for value: NAM
        /// </summary>
        [EnumMember(Value = "NAM")]
        NAM = 150,

        /// <summary>
        /// Enum NCL for value: NCL
        /// </summary>
        [EnumMember(Value = "NCL")]
        NCL = 151,

        /// <summary>
        /// Enum NER for value: NER
        /// </summary>
        [EnumMember(Value = "NER")]
        NER = 152,

        /// <summary>
        /// Enum NFK for value: NFK
        /// </summary>
        [EnumMember(Value = "NFK")]
        NFK = 153,

        /// <summary>
        /// Enum NGA for value: NGA
        /// </summary>
        [EnumMember(Value = "NGA")]
        NGA = 154,

        /// <summary>
        /// Enum NIC for value: NIC
        /// </summary>
        [EnumMember(Value = "NIC")]
        NIC = 155,

        /// <summary>
        /// Enum NIU for value: NIU
        /// </summary>
        [EnumMember(Value = "NIU")]
        NIU = 156,

        /// <summary>
        /// Enum NLD for value: NLD
        /// </summary>
        [EnumMember(Value = "NLD")]
        NLD = 157,

        /// <summary>
        /// Enum NOR for value: NOR
        /// </summary>
        [EnumMember(Value = "NOR")]
        NOR = 158,

        /// <summary>
        /// Enum NPL for value: NPL
        /// </summary>
        [EnumMember(Value = "NPL")]
        NPL = 159,

        /// <summary>
        /// Enum NRU for value: NRU
        /// </summary>
        [EnumMember(Value = "NRU")]
        NRU = 160,

        /// <summary>
        /// Enum NZL for value: NZL
        /// </summary>
        [EnumMember(Value = "NZL")]
        NZL = 161,

        /// <summary>
        /// Enum OMN for value: OMN
        /// </summary>
        [EnumMember(Value = "OMN")]
        OMN = 162,

        /// <summary>
        /// Enum PAK for value: PAK
        /// </summary>
        [EnumMember(Value = "PAK")]
        PAK = 163,

        /// <summary>
        /// Enum PAN for value: PAN
        /// </summary>
        [EnumMember(Value = "PAN")]
        PAN = 164,

        /// <summary>
        /// Enum PER for value: PER
        /// </summary>
        [EnumMember(Value = "PER")]
        PER = 165,

        /// <summary>
        /// Enum PHL for value: PHL
        /// </summary>
        [EnumMember(Value = "PHL")]
        PHL = 166,

        /// <summary>
        /// Enum PLW for value: PLW
        /// </summary>
        [EnumMember(Value = "PLW")]
        PLW = 167,

        /// <summary>
        /// Enum PNG for value: PNG
        /// </summary>
        [EnumMember(Value = "PNG")]
        PNG = 168,

        /// <summary>
        /// Enum POL for value: POL
        /// </summary>
        [EnumMember(Value = "POL")]
        POL = 169,

        /// <summary>
        /// Enum PRI for value: PRI
        /// </summary>
        [EnumMember(Value = "PRI")]
        PRI = 170,

        /// <summary>
        /// Enum PRT for value: PRT
        /// </summary>
        [EnumMember(Value = "PRT")]
        PRT = 171,

        /// <summary>
        /// Enum PRY for value: PRY
        /// </summary>
        [EnumMember(Value = "PRY")]
        PRY = 172,

        /// <summary>
        /// Enum PSE for value: PSE
        /// </summary>
        [EnumMember(Value = "PSE")]
        PSE = 173,

        /// <summary>
        /// Enum PYF for value: PYF
        /// </summary>
        [EnumMember(Value = "PYF")]
        PYF = 174,

        /// <summary>
        /// Enum QAT for value: QAT
        /// </summary>
        [EnumMember(Value = "QAT")]
        QAT = 175,

        /// <summary>
        /// Enum REU for value: REU
        /// </summary>
        [EnumMember(Value = "REU")]
        REU = 176,

        /// <summary>
        /// Enum ROU for value: ROU
        /// </summary>
        [EnumMember(Value = "ROU")]
        ROU = 177,

        /// <summary>
        /// Enum RUS for value: RUS
        /// </summary>
        [EnumMember(Value = "RUS")]
        RUS = 178,

        /// <summary>
        /// Enum RWA for value: RWA
        /// </summary>
        [EnumMember(Value = "RWA")]
        RWA = 179,

        /// <summary>
        /// Enum SAU for value: SAU
        /// </summary>
        [EnumMember(Value = "SAU")]
        SAU = 180,

        /// <summary>
        /// Enum SEN for value: SEN
        /// </summary>
        [EnumMember(Value = "SEN")]
        SEN = 181,

        /// <summary>
        /// Enum SGP for value: SGP
        /// </summary>
        [EnumMember(Value = "SGP")]
        SGP = 182,

        /// <summary>
        /// Enum SHN for value: SHN
        /// </summary>
        [EnumMember(Value = "SHN")]
        SHN = 183,

        /// <summary>
        /// Enum SLB for value: SLB
        /// </summary>
        [EnumMember(Value = "SLB")]
        SLB = 184,

        /// <summary>
        /// Enum SLE for value: SLE
        /// </summary>
        [EnumMember(Value = "SLE")]
        SLE = 185,

        /// <summary>
        /// Enum SLV for value: SLV
        /// </summary>
        [EnumMember(Value = "SLV")]
        SLV = 186,

        /// <summary>
        /// Enum SMR for value: SMR
        /// </summary>
        [EnumMember(Value = "SMR")]
        SMR = 187,

        /// <summary>
        /// Enum SOM for value: SOM
        /// </summary>
        [EnumMember(Value = "SOM")]
        SOM = 188,

        /// <summary>
        /// Enum SPM for value: SPM
        /// </summary>
        [EnumMember(Value = "SPM")]
        SPM = 189,

        /// <summary>
        /// Enum SRB for value: SRB
        /// </summary>
        [EnumMember(Value = "SRB")]
        SRB = 190,

        /// <summary>
        /// Enum SSD for value: SSD
        /// </summary>
        [EnumMember(Value = "SSD")]
        SSD = 191,

        /// <summary>
        /// Enum STP for value: STP
        /// </summary>
        [EnumMember(Value = "STP")]
        STP = 192,

        /// <summary>
        /// Enum SUR for value: SUR
        /// </summary>
        [EnumMember(Value = "SUR")]
        SUR = 193,

        /// <summary>
        /// Enum SVK for value: SVK
        /// </summary>
        [EnumMember(Value = "SVK")]
        SVK = 194,

        /// <summary>
        /// Enum SVN for value: SVN
        /// </summary>
        [EnumMember(Value = "SVN")]
        SVN = 195,

        /// <summary>
        /// Enum SWE for value: SWE
        /// </summary>
        [EnumMember(Value = "SWE")]
        SWE = 196,

        /// <summary>
        /// Enum SWZ for value: SWZ
        /// </summary>
        [EnumMember(Value = "SWZ")]
        SWZ = 197,

        /// <summary>
        /// Enum SXM for value: SXM
        /// </summary>
        [EnumMember(Value = "SXM")]
        SXM = 198,

        /// <summary>
        /// Enum SYC for value: SYC
        /// </summary>
        [EnumMember(Value = "SYC")]
        SYC = 199,

        /// <summary>
        /// Enum TCA for value: TCA
        /// </summary>
        [EnumMember(Value = "TCA")]
        TCA = 200,

        /// <summary>
        /// Enum TCD for value: TCD
        /// </summary>
        [EnumMember(Value = "TCD")]
        TCD = 201,

        /// <summary>
        /// Enum TGO for value: TGO
        /// </summary>
        [EnumMember(Value = "TGO")]
        TGO = 202,

        /// <summary>
        /// Enum THA for value: THA
        /// </summary>
        [EnumMember(Value = "THA")]
        THA = 203,

        /// <summary>
        /// Enum TJK for value: TJK
        /// </summary>
        [EnumMember(Value = "TJK")]
        TJK = 204,

        /// <summary>
        /// Enum TKM for value: TKM
        /// </summary>
        [EnumMember(Value = "TKM")]
        TKM = 205,

        /// <summary>
        /// Enum TLS for value: TLS
        /// </summary>
        [EnumMember(Value = "TLS")]
        TLS = 206,

        /// <summary>
        /// Enum TON for value: TON
        /// </summary>
        [EnumMember(Value = "TON")]
        TON = 207,

        /// <summary>
        /// Enum TTO for value: TTO
        /// </summary>
        [EnumMember(Value = "TTO")]
        TTO = 208,

        /// <summary>
        /// Enum TUN for value: TUN
        /// </summary>
        [EnumMember(Value = "TUN")]
        TUN = 209,

        /// <summary>
        /// Enum TUR for value: TUR
        /// </summary>
        [EnumMember(Value = "TUR")]
        TUR = 210,

        /// <summary>
        /// Enum TUV for value: TUV
        /// </summary>
        [EnumMember(Value = "TUV")]
        TUV = 211,

        /// <summary>
        /// Enum TWN for value: TWN
        /// </summary>
        [EnumMember(Value = "TWN")]
        TWN = 212,

        /// <summary>
        /// Enum TZA for value: TZA
        /// </summary>
        [EnumMember(Value = "TZA")]
        TZA = 213,

        /// <summary>
        /// Enum UGA for value: UGA
        /// </summary>
        [EnumMember(Value = "UGA")]
        UGA = 214,

        /// <summary>
        /// Enum UKR for value: UKR
        /// </summary>
        [EnumMember(Value = "UKR")]
        UKR = 215,

        /// <summary>
        /// Enum UMI for value: UMI
        /// </summary>
        [EnumMember(Value = "UMI")]
        UMI = 216,

        /// <summary>
        /// Enum URY for value: URY
        /// </summary>
        [EnumMember(Value = "URY")]
        URY = 217,

        /// <summary>
        /// Enum USA for value: USA
        /// </summary>
        [EnumMember(Value = "USA")]
        USA = 218,

        /// <summary>
        /// Enum UZB for value: UZB
        /// </summary>
        [EnumMember(Value = "UZB")]
        UZB = 219,

        /// <summary>
        /// Enum VAT for value: VAT
        /// </summary>
        [EnumMember(Value = "VAT")]
        VAT = 220,

        /// <summary>
        /// Enum VCT for value: VCT
        /// </summary>
        [EnumMember(Value = "VCT")]
        VCT = 221,

        /// <summary>
        /// Enum VEN for value: VEN
        /// </summary>
        [EnumMember(Value = "VEN")]
        VEN = 222,

        /// <summary>
        /// Enum VGB for value: VGB
        /// </summary>
        [EnumMember(Value = "VGB")]
        VGB = 223,

        /// <summary>
        /// Enum VIR for value: VIR
        /// </summary>
        [EnumMember(Value = "VIR")]
        VIR = 224,

        /// <summary>
        /// Enum VNM for value: VNM
        /// </summary>
        [EnumMember(Value = "VNM")]
        VNM = 225,

        /// <summary>
        /// Enum VUT for value: VUT
        /// </summary>
        [EnumMember(Value = "VUT")]
        VUT = 226,

        /// <summary>
        /// Enum WLF for value: WLF
        /// </summary>
        [EnumMember(Value = "WLF")]
        WLF = 227,

        /// <summary>
        /// Enum WSM for value: WSM
        /// </summary>
        [EnumMember(Value = "WSM")]
        WSM = 228,

        /// <summary>
        /// Enum YEM for value: YEM
        /// </summary>
        [EnumMember(Value = "YEM")]
        YEM = 229,

        /// <summary>
        /// Enum ZAF for value: ZAF
        /// </summary>
        [EnumMember(Value = "ZAF")]
        ZAF = 230,

        /// <summary>
        /// Enum ZMB for value: ZMB
        /// </summary>
        [EnumMember(Value = "ZMB")]
        ZMB = 231,

        /// <summary>
        /// Enum ZWE for value: ZWE
        /// </summary>
        [EnumMember(Value = "ZWE")]
        ZWE = 232

    }

}