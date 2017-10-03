// Copyright ©2017 Simonray (http://github.com/simonray). All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System.ComponentModel.DataAnnotations;

namespace ExchangeRate
{
    /// <summary>
    /// Representation of ISO 4217 currency codes. Generated - 01/01/2015.
    /// </summary>
    /// <remarks>
    /// Source - http://www.iso.org/iso/home/standards/currency_codes.htm
    /// </remarks>
    public enum Iso4217
    {
        /// <summary>UAE Dirham</summary>
        [Display(Name="UAE Dirham")] AED = 784,
        /// <summary>Afghani</summary>
        [Display(Name="Afghani")] AFN = 971,
        /// <summary>Lek</summary>
        [Display(Name="Lek")] ALL = 008,
        /// <summary>Armenian Dram</summary>
        [Display(Name="Armenian Dram")] AMD = 051,
        /// <summary>Netherlands Antillean Guilder</summary>
        [Display(Name="Netherlands Antillean Guilder")] ANG = 532,
        /// <summary>Kwanza</summary>
        [Display(Name="Kwanza")] AOA = 973,
        /// <summary>Argentine Peso</summary>
        [Display(Name="Argentine Peso")] ARS = 032,
        /// <summary>Australian Dollar</summary>
        [Display(Name="Australian Dollar")] AUD = 036,
        /// <summary>Aruban Florin</summary>
        [Display(Name="Aruban Florin")] AWG = 533,
        /// <summary>Azerbaijanian Manat</summary>
        [Display(Name="Azerbaijanian Manat")] AZN = 944,
        /// <summary>Convertible Mark</summary>
        [Display(Name="Convertible Mark")] BAM = 977,
        /// <summary>Barbados Dollar</summary>
        [Display(Name="Barbados Dollar")] BBD = 052,
        /// <summary>Taka</summary>[Display(Name="Taka")] BDT = 050,
        /// <summary>Bulgarian Lev</summary>
        [Display(Name="Bulgarian Lev")] BGN = 975,
        /// <summary>Bahraini Dinar</summary>
        [Display(Name="Bahraini Dinar")] BHD = 048,
        /// <summary>Burundi Franc</summary>
        [Display(Name="Burundi Franc")] BIF = 108,
        /// <summary>Bermudian Dollar</summary>
        [Display(Name="Bermudian Dollar")] BMD = 060,
        /// <summary>Brunei Dollar</summary>
        [Display(Name="Brunei Dollar")] BND = 096,
        /// <summary>Boliviano</summary>
        [Display(Name="Boliviano")] BOB = 068,
        /// <summary>Mvdol</summary>
        [Display(Name="Mvdol")] BOV = 984,
        /// <summary>Brazilian Real</summary>
        [Display(Name="Brazilian Real")] BRL = 986,
        /// <summary>Bahamian Dollar</summary>
        [Display(Name="Bahamian Dollar")] BSD = 044,
        /// <summary>Ngultrum</summary>
        [Display(Name="Ngultrum")] BTN = 064,
        /// <summary>Pula</summary>
        [Display(Name="Pula")] BWP = 072,
        /// <summary>Belarussian Ruble</summary>
        [Display(Name="Belarussian Ruble")] BYR = 974,
        /// <summary>Belize Dollar</summary>
        [Display(Name="Belize Dollar")] BZD = 084,
        /// <summary>Canadian Dollar</summary>
        [Display(Name="Canadian Dollar")] CAD = 124,
        /// <summary>Congolese Franc</summary>
        [Display(Name="Congolese Franc")] CDF = 976,
        /// <summary>WIR Euro</summary>
        [Display(Name="WIR Euro")] CHE = 947,
        /// <summary>Swiss Franc</summary>
        [Display(Name="Swiss Franc")] CHF = 756,
        /// <summary>WIR Franc</summary>
        [Display(Name="WIR Franc")] CHW = 948,
        /// <summary>Unidad de Fomento</summary>
        [Display(Name="Unidad de Fomento")] CLF = 990,
        /// <summary>Chilean Peso</summary>
        [Display(Name="Chilean Peso")] CLP = 152,
        /// <summary>Yuan Renminbi</summary>
        [Display(Name="Yuan Renminbi")] CNY = 156,
        /// <summary>Colombian Peso</summary>
        [Display(Name="Colombian Peso")] COP = 170,
        /// <summary>Unidad de Valor Real</summary>
        [Display(Name="Unidad de Valor Real")] COU = 970,
        /// <summary>Costa Rican Colon</summary>
        [Display(Name="Costa Rican Colon")] CRC = 188,
        /// <summary>Peso Convertible</summary>
        [Display(Name="Peso Convertible")] CUC = 931,
        /// <summary>Cuban Peso</summary>
        [Display(Name="Cuban Peso")] CUP = 192,
        /// <summary>Cabo Verde Escudo</summary>
        [Display(Name="Cabo Verde Escudo")] CVE = 132,
        /// <summary>Czech Koruna</summary>
        [Display(Name="Czech Koruna")] CZK = 203,
        /// <summary>Djibouti Franc</summary>
        [Display(Name="Djibouti Franc")] DJF = 262,
        /// <summary>Danish Krone</summary>
        [Display(Name="Danish Krone")] DKK = 208,
        /// <summary>Dominican Peso</summary>
        [Display(Name="Dominican Peso")] DOP = 214,
        /// <summary>Algerian Dinar</summary>
        [Display(Name="Algerian Dinar")] DZD = 012,
        /// <summary>Egyptian Pound</summary>
        [Display(Name="Egyptian Pound")] EGP = 818,
        /// <summary>Nakfa</summary>
        [Display(Name="Nakfa")] ERN = 232,
        /// <summary>Ethiopian Birr</summary>
        [Display(Name="Ethiopian Birr")] ETB = 230,
        /// <summary>Euro</summary>
        [Display(Name="Euro")] EUR = 978,
        /// <summary>Fiji Dollar</summary>
        [Display(Name="Fiji Dollar")] FJD = 242,
        /// <summary>Falkland Islands Pound</summary>
        [Display(Name="Falkland Islands Pound")] FKP = 238,
        /// <summary>Pound Sterling</summary>
        [Display(Name="Pound Sterling")] GBP = 826,
        /// <summary>Lari</summary>
        [Display(Name="Lari")] GEL = 981,
        /// <summary>Ghana Cedi</summary>
        [Display(Name="Ghana Cedi")] GHS = 936,
        /// <summary>Gibraltar Pound</summary>
        [Display(Name="Gibraltar Pound")] GIP = 292,
        /// <summary>Dalasi</summary>
        [Display(Name="Dalasi")] GMD = 270,
        /// <summary>Guinea Franc</summary>
        [Display(Name="Guinea Franc")] GNF = 324,
        /// <summary>Quetzal</summary>
        [Display(Name="Quetzal")] GTQ = 320,
        /// <summary>Guyana Dollar</summary>
        [Display(Name="Guyana Dollar")] GYD = 328,
        /// <summary>Hong Kong Dollar</summary>
        [Display(Name="Hong Kong Dollar")] HKD = 344,
        /// <summary>Lempira</summary>
        [Display(Name="Lempira")] HNL = 340,
        /// <summary>Croatian Kuna</summary>
        [Display(Name="Croatian Kuna")] HRK = 191,
        /// <summary>Gourde</summary>
        [Display(Name="Gourde")] HTG = 332,
        /// <summary>Forint</summary>
        [Display(Name="Forint")] HUF = 348,
        /// <summary>Rupiah</summary>
        [Display(Name="Rupiah")] IDR = 360,
        /// <summary>New Israeli Sheqel</summary>
        [Display(Name="New Israeli Sheqel")] ILS = 376,
        /// <summary>Indian Rupee</summary>
        [Display(Name="Indian Rupee")] INR = 356,
        /// <summary>Iraqi Dinar</summary>
        [Display(Name="Iraqi Dinar")] IQD = 368,
        /// <summary>Iranian Rial</summary>
        [Display(Name="Iranian Rial")] IRR = 364,
        /// <summary>Iceland Krona</summary>
        [Display(Name="Iceland Krona")] ISK = 352,
        /// <summary>Jamaican Dollar</summary>
        [Display(Name="Jamaican Dollar")] JMD = 388,
        /// <summary>Jordanian Dinar</summary>
        [Display(Name="Jordanian Dinar")] JOD = 400,
        /// <summary>Yen</summary>
        [Display(Name="Yen")] JPY = 392,
        /// <summary>Kenyan Shilling</summary>
        [Display(Name="Kenyan Shilling")] KES = 404,
        /// <summary>Som</summary>
        [Display(Name="Som")] KGS = 417,
        /// <summary>Riel</summary>
        [Display(Name="Riel")] KHR = 116,
        /// <summary>Comoro Franc</summary>
        [Display(Name="Comoro Franc")] KMF = 174,
        /// <summary>North Korean Won</summary>
        [Display(Name="North Korean Won")] KPW = 408,
        /// <summary>Won</summary>
        [Display(Name="Won")] KRW = 410,
        /// <summary>Kuwaiti Dinar</summary>
        [Display(Name="Kuwaiti Dinar")] KWD = 414,
        /// <summary>Cayman Islands Dollar</summary>
        [Display(Name="Cayman Islands Dollar")] KYD = 136,
        /// <summary>Tenge</summary>
        [Display(Name="Tenge")] KZT = 398,
        /// <summary>Kip</summary>
        [Display(Name="Kip")] LAK = 418,
        /// <summary>Lebanese Pound</summary>
        [Display(Name="Lebanese Pound")] LBP = 422,
        /// <summary>Sri Lanka Rupee</summary>
        [Display(Name="Sri Lanka Rupee")] LKR = 144,
        /// <summary>Liberian Dollar</summary>
        [Display(Name="Liberian Dollar")] LRD = 430,
        /// <summary>Loti</summary>
        [Display(Name="Loti")] LSL = 426,
        /// <summary>Libyan Dinar</summary>
        [Display(Name="Libyan Dinar")] LYD = 434,
        /// <summary>Moroccan Dirham</summary>
        [Display(Name="Moroccan Dirham")] MAD = 504,
        /// <summary>Moldovan Leu</summary>
        [Display(Name="Moldovan Leu")] MDL = 498,
        /// <summary>Malagasy Ariary</summary>
        [Display(Name="Malagasy Ariary")] MGA = 969,
        /// <summary>Denar</summary>
        [Display(Name="Denar")] MKD = 807,
        /// <summary>Kyat</summary>
        [Display(Name="Kyat")] MMK = 104,
        /// <summary>Tugrik</summary>
        [Display(Name="Tugrik")] MNT = 496,
        /// <summary>Pataca</summary>
        [Display(Name="Pataca")] MOP = 446,
        /// <summary>Ouguiya</summary>
        [Display(Name="Ouguiya")] MRO = 478,
        /// <summary>Mauritius Rupee</summary>
        [Display(Name="Mauritius Rupee")] MUR = 480,
        /// <summary>Rufiyaa</summary>
        [Display(Name="Rufiyaa")] MVR = 462,
        /// <summary>Kwacha</summary>
        [Display(Name="Kwacha")] MWK = 454,
        /// <summary>Mexican Peso</summary>
        [Display(Name="Mexican Peso")] MXN = 484,
        /// <summary>Mexican Unidad de Inversion (UDI)</summary>
        [Display(Name="Mexican Unidad de Inversion (UDI)")] MXV = 979,
        /// <summary>Malaysian Ringgit</summary>
        [Display(Name="Malaysian Ringgit")] MYR = 458,
        /// <summary>Mozambique Metical</summary>
        [Display(Name="Mozambique Metical")] MZN = 943,
        /// <summary>Namibia Dollar</summary>
        [Display(Name="Namibia Dollar")] NAD = 516,
        /// <summary>Naira</summary>
        [Display(Name="Naira")] NGN = 566,
        /// <summary>Cordoba Oro</summary>
        [Display(Name="Cordoba Oro")] NIO = 558,
        /// <summary>Norwegian Krone</summary>
        [Display(Name="Norwegian Krone")] NOK = 578,
        /// <summary>Nepalese Rupee</summary>
        [Display(Name="Nepalese Rupee")] NPR = 524,
        /// <summary>New Zealand Dollar</summary>
        [Display(Name="New Zealand Dollar")] NZD = 554,
        /// <summary>Rial Omani</summary>
        [Display(Name="Rial Omani")] OMR = 512,
        /// <summary>Balboa</summary>
        [Display(Name="Balboa")] PAB = 590,
        /// <summary>Nuevo Sol</summary>
        [Display(Name="Nuevo Sol")] PEN = 604,
        /// <summary>Kina</summary>
        [Display(Name="Kina")] PGK = 598,
        /// <summary>Philippine Peso</summary>
        [Display(Name="Philippine Peso")] PHP = 608,
        /// <summary>Pakistan Rupee</summary>
        [Display(Name="Pakistan Rupee")] PKR = 586,
        /// <summary>Zloty</summary>
        [Display(Name="Zloty")] PLN = 985,
        /// <summary>Guarani</summary>
        [Display(Name="Guarani")] PYG = 600,
        /// <summary>Qatari Rial</summary>
        [Display(Name="Qatari Rial")] QAR = 634,
        /// <summary>New Romanian Leu</summary>
        [Display(Name="New Romanian Leu")] RON = 946,
        /// <summary>Serbian Dinar</summary>
        [Display(Name="Serbian Dinar")] RSD = 941,
        /// <summary>Russian Ruble</summary>
        [Display(Name="Russian Ruble")] RUB = 643,
        /// <summary>Rwanda Franc</summary>
        [Display(Name="Rwanda Franc")] RWF = 646,
        /// <summary>Saudi Riyal</summary>
        [Display(Name="Saudi Riyal")] SAR = 682,
        /// <summary>Solomon Islands Dollar</summary>
        [Display(Name="Solomon Islands Dollar")] SBD = 090,
        /// <summary>Seychelles Rupee</summary>
        [Display(Name="Seychelles Rupee")] SCR = 690,
        /// <summary>Sudanese Pound</summary>
        [Display(Name="Sudanese Pound")] SDG = 938,
        /// <summary>Swedish Krona</summary>
        [Display(Name="Swedish Krona")] SEK = 752,
        /// <summary>Singapore Dollar</summary>
        [Display(Name="Singapore Dollar")] SGD = 702,
        /// <summary>Saint Helena Pound</summary>
        [Display(Name="Saint Helena Pound")] SHP = 654,
        /// <summary>Leone</summary>
        [Display(Name="Leone")] SLL = 694,
        /// <summary>Somali Shilling</summary>
        [Display(Name="Somali Shilling")] SOS = 706,
        /// <summary>Surinam Dollar</summary>
        [Display(Name="Surinam Dollar")] SRD = 968,
        /// <summary>South Sudanese Pound</summary>
        [Display(Name="South Sudanese Pound")] SSP = 728,
        /// <summary>Dobra</summary>
        [Display(Name="Dobra")] STD = 678,
        /// <summary>El Salvador Colon</summary>
        [Display(Name="El Salvador Colon")] SVC = 222,
        /// <summary>Syrian Pound</summary>
        [Display(Name="Syrian Pound")] SYP = 760,
        /// <summary>Lilangeni</summary>
        [Display(Name="Lilangeni")] SZL = 748,
        /// <summary>Baht</summary>
        [Display(Name="Baht")] THB = 764,
        /// <summary>Somoni</summary>
        [Display(Name="Somoni")] TJS = 972,
        /// <summary>Turkmenistan New Manat</summary>
        [Display(Name="Turkmenistan New Manat")] TMT = 934,
        /// <summary>Tunisian Dinar</summary>
        [Display(Name="Tunisian Dinar")] TND = 788,
        /// <summary>Pa’anga</summary>
        [Display(Name="Pa’anga")] TOP = 776,
        /// <summary>Turkish Lira</summary>
        [Display(Name="Turkish Lira")] TRY = 949,
        /// <summary>Trinidad and Tobago Dollar</summary>
        [Display(Name="Trinidad and Tobago Dollar")] TTD = 780,
        /// <summary>New Taiwan Dollar</summary>
        [Display(Name="New Taiwan Dollar")] TWD = 901,
        /// <summary>Tanzanian Shilling</summary>
        [Display(Name="Tanzanian Shilling")] TZS = 834,
        /// <summary>Hryvnia</summary>
        [Display(Name="Hryvnia")] UAH = 980,
        /// <summary>Uganda Shilling</summary>
        [Display(Name="Uganda Shilling")] UGX = 800,
        /// <summary>US Dollar</summary>
        [Display(Name="US Dollar")] USD = 840,
        /// <summary>US Dollar (Next day)</summary>
        [Display(Name="US Dollar (Next day)")] USN = 997,
        /// <summary>Uruguay Peso en Unidades Indexadas (URUIURUI)</summary>
        [Display(Name="Uruguay Peso en Unidades Indexadas (URUIURUI)")] UYI = 940,
        /// <summary>Peso Uruguayo</summary>
        [Display(Name="Peso Uruguayo")] UYU = 858,
        /// <summary>Uzbekistan Sum</summary>
        [Display(Name="Uzbekistan Sum")] UZS = 860,
        /// <summary>Bolivar</summary>
        [Display(Name="Bolivar")] VEF = 937,
        /// <summary>Dong</summary>
        [Display(Name="Dong")] VND = 704,
        /// <summary>Vatu</summary>
        [Display(Name="Vatu")] VUV = 548,
        /// <summary>Tala</summary>
        [Display(Name="Tala")] WST = 882,
        /// <summary>CFA Franc BEAC</summary>
        [Display(Name="CFA Franc BEAC")] XAF = 950,
        /// <summary>Silver</summary>
        [Display(Name="Silver")] XAG = 961,
        /// <summary>Gold</summary>
        [Display(Name="Gold")] XAU = 959,
        /// <summary>Bond Markets Unit European Composite Unit (EURCO)</summary>
        [Display(Name="Bond Markets Unit European Composite Unit (EURCO)")] XBA = 955,
        /// <summary>Bond Markets Unit European Monetary Unit (E.M.U.-6)</summary>
        [Display(Name="Bond Markets Unit European Monetary Unit (E.M.U.-6)")] XBB = 956,
        /// <summary>Bond Markets Unit European Unit of Account 9 (E.U.A.-9)</summary>
        [Display(Name="Bond Markets Unit European Unit of Account 9 (E.U.A.-9)")] XBC = 957,
        /// <summary>Bond Markets Unit European Unit of Account 17 (E.U.A.-17)</summary>
        [Display(Name="Bond Markets Unit European Unit of Account 17 (E.U.A.-17)")] XBD = 958,
        /// <summary>East Caribbean Dollar</summary>
        [Display(Name="East Caribbean Dollar")] XCD = 951,
        /// <summary>SDR (Special Drawing Right)</summary>
        [Display(Name="SDR (Special Drawing Right)")] XDR = 960,
        /// <summary>CFA Franc BCEAO</summary>
        [Display(Name="CFA Franc BCEAO")] XOF = 952,
        /// <summary>Palladium</summary>
        [Display(Name="Palladium")] XPD = 964,
        /// <summary>CFP Franc</summary>
        [Display(Name="CFP Franc")] XPF = 953,
        /// <summary>Platinum</summary>
        [Display(Name="Platinum")] XPT = 962,
        /// <summary>Sucre</summary>
        [Display(Name="Sucre")] XSU = 994,
        /// <summary>Codes specifically reserved for testing purposes</summary>
        [Display(Name="Codes specifically reserved for testing purposes")] XTS = 963,
        /// <summary>ADB Unit of Account</summary>
        [Display(Name="ADB Unit of Account")] XUA = 965,
        /// <summary>The codes assigned for transactions where no currency is involved</summary>
        [Display(Name="The codes assigned for transactions where no currency is involved")] XXX = 999,
        /// <summary>Yemeni Rial</summary>
        [Display(Name="Yemeni Rial")] YER = 886,
        /// <summary>Rand</summary>
        [Display(Name="Rand")] ZAR = 710,
        /// <summary>Zambian Kwacha</summary>
        [Display(Name="Zambian Kwacha")] ZMW = 967,
        /// <summary>Zimbabwe Dollar</summary>
        [Display(Name="Zimbabwe Dollar")] ZWL = 932,
    }
}
