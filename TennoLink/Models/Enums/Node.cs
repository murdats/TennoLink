﻿using System;
using System.Linq;

namespace TennoLink.Models.Enums
{
    public enum Node
    {
        SettlementNode1,
        SettlementNode2,
        SettlementNode3,
        SettlementNode4,
        SettlementNode5,
        SettlementNode6,
        SettlementNode7,
        SettlementNode8,
        SettlementNode9,
        SettlementNode10,
        SettlementNode11,
        SettlementNode12,
        SettlementNode13,
        SettlementNode14,
        SettlementNode15,
        SettlementNode16,
        SettlementNode17,
        SettlementNode18,
        SettlementNode19,
        SettlementNode20,
        SettlementNode21,
        ClanNode0,
        ClanNode1,
        ClanNode2,
        ClanNode3,
        ClanNode4,
        ClanNode5,
        ClanNode6,
        ClanNode7,
        ClanNode8,
        ClanNode9,
        ClanNode10,
        ClanNode11,
        ClanNode12,
        ClanNode13,
        ClanNode14,
        ClanNode15,
        ClanNode16,
        ClanNode17,
        ClanNode18,
        ClanNode19,
        ClanNode20,
        ClanNode21,
        ClanNode22,
        ClanNode23,
        ClanNode24,
        ClanNode25,
        ClanNode26,
        ClanNode27,
        ClanNode28,
        ClanNode29,
        ClanNode30,
        SolNode1,
        SolNode2,
        SolNode3,
        SolNode4,
        SolNode5,
        SolNode6,
        SolNode7,
        SolNode8,
        SolNode9,
        SolNode10,
        SolNode11,
        SolNode12,
        SolNode13,
        SolNode14,
        SolNode15,
        SolNode16,
        SolNode17,
        SolNode18,
        SolNode19,
        SolNode20,
        SolNode21,
        SolNode22,
        SolNode23,
        SolNode24,
        SolNode25,
        SolNode26,
        SolNode27,
        SolNode28,
        SolNode29,
        SolNode30,
        SolNode31,
        SolNode32,
        SolNode33,
        SolNode34,
        SolNode35,
        SolNode36,
        SolNode37,
        SolNode38,
        SolNode39,
        SolNode40,
        SolNode41,
        SolNode42,
        SolNode43,
        SolNode44,
        SolNode45,
        SolNode46,
        SolNode47,
        SolNode48,
        SolNode49,
        SolNode50,
        SolNode51,
        SolNode52,
        SolNode53,
        SolNode54,
        SolNode55,
        SolNode56,
        SolNode57,
        SolNode58,
        SolNode59,
        SolNode60,
        SolNode61,
        SolNode62,
        SolNode63,
        SolNode64,
        SolNode65,
        SolNode66,
        SolNode67,
        SolNode68,
        SolNode69,
        SolNode70,
        SolNode71,
        SolNode72,
        SolNode73,
        SolNode74,
        SolNode75,
        SolNode76,
        SolNode77,
        SolNode78,
        SolNode79,
        SolNode80,
        SolNode81,
        SolNode82,
        SolNode83,
        SolNode84,
        SolNode85,
        SolNode86,
        SolNode87,
        SolNode88,
        SolNode89,
        SolNode90,
        SolNode91,
        SolNode92,
        SolNode93,
        SolNode94,
        SolNode95,
        SolNode96,
        SolNode97,
        SolNode98,
        SolNode99,
        SolNode100,
        SolNode101,
        SolNode102,
        SolNode103,
        SolNode104,
        SolNode105,
        SolNode106,
        SolNode107,
        SolNode108,
        SolNode109,
        SolNode110,
        SolNode111,
        SolNode112,
        SolNode113,
        SolNode114,
        SolNode115,
        SolNode116,
        SolNode117,
        SolNode118,
        SolNode119,
        SolNode120,
        SolNode121,
        SolNode122,
        SolNode123,
        SolNode124,
        SolNode125,
        SolNode126,
        SolNode127,
        SolNode128,
        SolNode129,
        SolNode130,
        SolNode131,
        SolNode132,
        SolNode133,
        SolNode134,
        SolNode135,
        SolNode136,
        SolNode137,
        SolNode138,
        SolNode139,
        SolNode140,
        SolNode141,
        SolNode142,
        SolNode143,
        SolNode144,
        SolNode145,
        SolNode146,
        SolNode147,
        SolNode148,
        SolNode149,
        SolNode150,
        SolNode151,
        SolNode152,
        SolNode153,
        SolNode154,
        SolNode155,
        SolNode156,
        SolNode157,
        SolNode158,
        SolNode159,
        SolNode160,
        SolNode161,
        SolNode162,
        SolNode163,
        SolNode164,
        SolNode165,
        SolNode166,
        SolNode167,
        SolNode168,
        SolNode169,
        SolNode170,
        SolNode171,
        SolNode172,
        SolNode173,
        SolNode174,
        SolNode175,
        SolNode176,
        SolNode177,
        SolNode178,
        SolNode179,
        SolNode180,
        SolNode181,
        SolNode182,
        SolNode183,
        SolNode184,
        SolNode185,
        SolNode186,
        SolNode187,
        SolNode188,
        SolNode189,
        SolNode190,
        SolNode191,
        SolNode192,
        SolNode193,
        SolNode194,
        SolNode195,
        SolNode196,
        SolNode197,
        SolNode198,
        SolNode199,
        SolNode200,
        SolNode201,
        SolNode202,
        SolNode203,
        SolNode204,
        SolNode205,
        SolNode206,
        SolNode207,
        SolNode208,
        SolNode209,
        SolNode210,
        SolNode211,
        SolNode212,
        SolNode213,
        SolNode214,
        SolNode215,
        SolNode216,
        SolNode217,
        SolNode218,
        SolNode219,
        SolNode220,
        SolNode221,
        SolNode222,
        SolNode223,
        SolNode224,
        SolNode225,
        SolNode226,
        SolNode227,
        SolNode228,
        SolNode229,
        SolNode230,
        SolNode231,
        SolNode232,
        SolNode233,
        SolNode234,
        SolNode235,
        SolNode236,
        SolNode237,
        SolNode238,
        SolNode239,
        SolNode240,
        SolNode241,
        SolNode242,
        SolNode243,
        SolNode244,
        SolNode245,
        SolNode246,
        SolNode247,
        SolNode248,
        SolNode249,
        SolNode250,
        SolNode251,
        SolNode252,
        SolNode253,
        SolNode254,
        SolNode255,
        SolNode256,
        SolNode257,
        SolNode258,
        SolNode259,
        SolNode260,
        SolNode261,
        SolNode262,
        SolNode263,
        SolNode264,
        SolNode265,
        SolNode266,
        SolNode267,
        SolNode268,
        SolNode269,
        SolNode270,
        SolNode271,
        SolNode272,
        SolNode273,
        SolNode274,
        SolNode275,
        SolNode276,
        SolNode277,
        SolNode278,
        SolNode279,
        SolNode280,
        SolNode281,
        SolNode282,
        SolNode283,
        SolNode284,
        SolNode285,
        SolNode286,
        SolNode287,
        SolNode288,
        SolNode289,
        SolNode290,
        SolNode291,
        SolNode292,
        SolNode293,
        SolNode294,
        SolNode295,
        SolNode296,
        SolNode297,
        SolNode298,
        SolNode299,
        SolNode300,
        SolNode301,
        SolNode302,
        SolNode303,
        SolNode304,
        SolNode305,
        SolNode306,
        SolNode307,
        SolNode308,
        SolNode309,
        SolNode310,
        SolNode311,
        SolNode312,
        SolNode313,
        SolNode314,
        SolNode315,
        SolNode316,
        SolNode317,
        SolNode318,
        SolNode319,
        SolNode320,
        SolNode321,
        SolNode322,
        SolNode323,
        SolNode324,
        SolNode325,
        SolNode326,
        SolNode327,
        SolNode328,
        SolNode329,
        SolNode330,
        SolNode331,
        SolNode332,
        SolNode333,
        SolNode334,
        SolNode335,
        SolNode336,
        SolNode337,
        SolNode338,
        SolNode339,
        SolNode340,
        SolNode341,
        SolNode342,
        SolNode343,
        SolNode344,
        SolNode345,
        SolNode346,
        SolNode347,
        SolNode348,
        SolNode349,
        SolNode350,
        SolNode351,
        SolNode352,
        SolNode353,
        SolNode354,
        SolNode355,
        SolNode356,
        SolNode357,
        SolNode358,
        SolNode359,
        SolNode360,
    }
}