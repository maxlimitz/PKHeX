﻿using System.Collections.Generic;

namespace PKHeX.Core
{
    public static class Meta8
    {
        public static SCBlock[] GetBlankDataSWSH() => GetBlankBlockArray(DefaultChunkSizesSWSH);

        /// <summary>
        /// Create a blank block array using the provided <see cref="arr"/> definition.
        /// </summary>
        /// <param name="arr">Block specification tuples (key, size)</param>
        /// <returns>List of blocks</returns>
        private static SCBlock[] GetBlankBlockArray(IReadOnlyList<uint> arr)
        {
            var blocks = new SCBlock[arr.Count / 2];
            for (int i = 0; i < blocks.Length; i++)
            {
                int index = i * 2;
                var key = arr[index];
                var length = (int) arr[index + 1];
                var dummy = new byte[length];
                blocks[i] = new SCBlock(key, SCTypeCode.None, dummy);
            }
            return blocks;
        }

#if DEBUG
        public static IEnumerable<string> RipSizes(IReadOnlyCollection<SCBlock> blocks)
        {
            int ctr = 0;
            foreach (var block in blocks)
            {
                if (block.Data.Length == 0)
                    continue;
                if (ctr == 4)
                {
                    yield return System.Environment.NewLine;
                    ctr = 0;
                }
                yield return $"0x{block.Key:X8}, 0x{block.Data.Length:X5}, ";
                ctr++;
            }
        }
#endif

        private static readonly uint[] DefaultChunkSizesSWSH =
        {
            0x00A1F55B, 0x00004, 0x0123EA7A, 0x00004, 0x017C3CBB, 0x00001, 0x0192A204, 0x00009,
            0x01A1F6EE, 0x00004, 0x01BFCAD0, 0x00002, 0x02B647B4, 0x00004, 0x02BFCC63, 0x00002,
            0x02C163FD, 0x00004, 0x02DD636A, 0x00004, 0x034B256C, 0x00004, 0x03C18D2C, 0x00002,
            0x03C550C3, 0x00004, 0x03C69A96, 0x00004, 0x044B26FF, 0x00004, 0x0490A3C3, 0x056F8,
            0x04BFCF89, 0x00002, 0x04C18EBF, 0x00002, 0x04C55256, 0x00004, 0x051A8415, 0x00004,
            0x053EF7F5, 0x00004, 0x05C553E9, 0x00004, 0x06498466, 0x00004, 0x064B2A25, 0x00004,
            0x066F38F5, 0x00004, 0x06C0FBC8, 0x00004, 0x06C191E5, 0x00002, 0x07165742, 0x00004,
            0x071A3599, 0x00004, 0x097D2359, 0x00004, 0x0A01FC6C, 0x00004, 0x0A01FE1F, 0x00004,
            0x0A0204EB, 0x00004, 0x0A02069E, 0x00004, 0x0A020851, 0x00004, 0x0A0515F5, 0x00004,
            0x0A0517A8, 0x00004, 0x0A05195B, 0x00004, 0x0A051B0E, 0x00004, 0x0A051CC1, 0x00004,
            0x0A051E74, 0x00004, 0x0A052027, 0x00004, 0x0A0521DA, 0x00004, 0x0A05238D, 0x00004,
            0x0AD1037C, 0x00004, 0x0B90EFF8, 0x00004, 0x0BFDEBA1, 0x00004, 0x0C7C3E38, 0x00004,
            0x0CBEB855, 0x00004, 0x0CF6D916, 0x00004, 0x0D0E00C9, 0x00004, 0x0D477836, 0x00004,
            0x0D591902, 0x00004, 0x0D66012C, 0x50A00, 0x0D74AA40, 0x00008, 0x0D987D50, 0x00004,
            0x0E11ED8C, 0x00004, 0x0E411743, 0x00001, 0x0E591A95, 0x00004, 0x0E615A8C, 0x023D4,
            0x0E85795E, 0x00004, 0x0EA7CF37, 0x00004, 0x0F022C05, 0x00004, 0x0F0F2271, 0x00004,
            0x0F591C28, 0x00004, 0x0F850803, 0x00001, 0x0FA7D0CA, 0x00004, 0x10347218, 0x00004,
            0x10591DBB, 0x00004, 0x10850996, 0x00001, 0x108657DC, 0x00004, 0x10A7D25D, 0x00004,
            0x112D5141, 0x017C8, 0x11591F4E, 0x00004, 0x11615F45, 0x023D4, 0x1177C2C4, 0x012F8,
            0x11850B29, 0x00001, 0x125920E1, 0x00004, 0x127D6F1B, 0x00004, 0x12C96CFC, 0x00004,
            0x13349604, 0x00001, 0x133FD4BC, 0x00002, 0x13592274, 0x00004, 0x14592407, 0x00004,
            0x148DA703, 0x00A68, 0x149A1DD0, 0x00880, 0x14C97022, 0x00004, 0x14D0124C, 0x00648,
            0x151AE138, 0x00004, 0x1534992A, 0x00001, 0x153FD7E2, 0x00002, 0x1559259A, 0x00004,
            0x158DA896, 0x00A68, 0x15C971B5, 0x00004, 0x15D013DF, 0x00648, 0x15E9A450, 0x00004,
            0x15E9A603, 0x00004, 0x15E9A7B6, 0x00004, 0x15E9AB1C, 0x00004, 0x15E9ACCF, 0x00004,
            0x15E9AE82, 0x00004, 0x15E9B035, 0x00004, 0x15E9B701, 0x00004, 0x160CDE80, 0x00004,
            0x16349ABD, 0x00001, 0x163FD975, 0x00002, 0x1659272D, 0x00004, 0x169A20F6, 0x00880,
            0x16AAA7FA, 0x06010, 0x171AE45E, 0x00004, 0x175573FB, 0x00004, 0x177786BA, 0x00004,
            0x179A2289, 0x00880, 0x17C4CBAC, 0x00004, 0x181AE5F1, 0x00004, 0x184014A4, 0x00004,
            0x189A241C, 0x00880, 0x1920C1E4, 0x00084, 0x19401637, 0x00004, 0x19722C89, 0x00440,
            0x199A25AF, 0x00880, 0x1A961810, 0x00004, 0x1B40195D, 0x00004, 0x1B4C150C, 0x00001,
            0x1B882B09, 0x0021C, 0x1B9619A3, 0x00004, 0x1BE94648, 0x00004, 0x1C5FAE08, 0x00002,
            0x1D482A63, 0x00004, 0x1D961CC9, 0x00004, 0x1DC26AF0, 0x00001, 0x1DD41D8C, 0x00004,
            0x1DE9496E, 0x00004, 0x1E5FB12E, 0x00002, 0x1EC26C83, 0x00001, 0x1EE94B01, 0x00004,
            0x1F5FB2C1, 0x00002, 0x1F637658, 0x00004, 0x206377EB, 0x00004, 0x20C26FA9, 0x00001,
            0x20DA9878, 0x00001, 0x20FA6183, 0x00132, 0x2163797E, 0x00004, 0x224A1BD2, 0x00008,
            0x22DA9B9E, 0x00001, 0x23DA9D31, 0x00001, 0x23E747F4, 0x00001, 0x24280E24, 0x00004,
            0x2454C888, 0x00001, 0x24ADE637, 0x00004, 0x24B9E3CC, 0x00004, 0x24E74987, 0x00001,
            0x24F1F93C, 0x00004, 0x24F1FAEF, 0x00004, 0x24F1FCA2, 0x00004, 0x2554CA1B, 0x00001,
            0x2575BD5B, 0x00004, 0x25A7CED1, 0x00004, 0x25E74B1A, 0x00001, 0x2654CBAE, 0x00001,
            0x26A1BEDE, 0x00004, 0x26B99C02, 0x00004, 0x26FE3299, 0x00004, 0x26FE3B18, 0x00004,
            0x26FE3CCB, 0x00004, 0x26FE3E7E, 0x00004, 0x26FE41E4, 0x00004, 0x26FE4397, 0x00004,
            0x26FE454A, 0x00004, 0x26FE46FD, 0x00004, 0x2846B7DB, 0x00004, 0x28BC6BDC, 0x00002,
            0x28E707F5, 0x21FC0, 0x28F03D03, 0x00004, 0x29036436, 0x00004, 0x2985FE5D, 0x00814,
            0x29A93E10, 0x00004, 0x29BC6D6F, 0x00002, 0x29E026C7, 0x00001, 0x2A7F88A8, 0x00001,
            0x2B07632B, 0x00004, 0x2B103B06, 0x00004, 0x2B232D98, 0x00001, 0x2BBC7095, 0x00002,
            0x2C232F2B, 0x00001, 0x2C7F8BCE, 0x00001, 0x2D0520CD, 0x00004, 0x2D2330BE, 0x00001,
            0x2D6FBA6A, 0x00570, 0x2D7F8D61, 0x00001, 0x2DFA8C4E, 0x00004, 0x2E9F837C, 0x00001,
            0x2EB1B190, 0x00020, 0x2F773C75, 0x00004, 0x2F9F850F, 0x00001, 0x2FC2FD50, 0x00004,
            0x30080BB6, 0x00004, 0x30396510, 0x00002, 0x30671AD9, 0x00008, 0x30C2FEE3, 0x00004,
            0x313966A3, 0x00002, 0x319F8835, 0x00001, 0x31A13425, 0x00004, 0x31C30076, 0x00004,
            0x32396836, 0x00002, 0x32C4F443, 0x00004, 0x32EF5030, 0x00001, 0x33068788, 0x00004,
            0x331EF563, 0x00004, 0x331EF716, 0x00004, 0x335AA3F7, 0x00001, 0x33EF51C3, 0x00001,
            0x33F39467, 0x00048, 0x343E6FC1, 0x00004, 0x345AA58A, 0x00001, 0x3468783B, 0x00004,
            0x34E60D88, 0x00004, 0x34EF5356, 0x00001, 0x355AA71D, 0x00001, 0x355C8314, 0x00004,
            0x356879CE, 0x00004, 0x3576EE34, 0x00004, 0x363D064C, 0x00004, 0x36687B61, 0x00004,
            0x3677602D, 0x00004, 0x36E2F1C8, 0x00004, 0x374090B6, 0x00004, 0x375A5D09, 0x00004,
            0x37A13A2A, 0x00004, 0x37DA95A3, 0x000C8, 0x37E17D13, 0x00004, 0x38548020, 0x00004,
            0x39227A79, 0x00D50, 0x3934BEC0, 0x00004, 0x39B43CEF, 0x00004, 0x3A313F00, 0x00004,
            0x3A3140B3, 0x00004, 0x3A314266, 0x00004, 0x3A314419, 0x00004, 0x3A31477F, 0x00004,
            0x3A314932, 0x00004, 0x3A314AE5, 0x00004, 0x3A315364, 0x00004, 0x3A315517, 0x00004,
            0x3A345DA2, 0x00004, 0x3A345F55, 0x00004, 0x3A377578, 0x00004, 0x3A37772B, 0x00004,
            0x3A377A91, 0x00004, 0x3A377FAA, 0x00004, 0x3A3A90B4, 0x00004, 0x3A68EA36, 0x00004,
            0x3A6B2A3F, 0x00004, 0x3A6F5768, 0x00004, 0x3B23B1E2, 0x00004, 0x3BFF8084, 0x00002,
            0x3C6F5A8E, 0x00004, 0x3C7119C4, 0x00004, 0x3C9366F0, 0x02760, 0x3CF2E964, 0x00001,
            0x3CFF8217, 0x00002, 0x3D6F5C21, 0x00004, 0x3DBE736D, 0x00004, 0x3DF2EAF7, 0x00001,
            0x3DFF83AA, 0x00002, 0x3E711CEA, 0x00004, 0x3E8CFA15, 0x033D0, 0x3F64E8A0, 0x00004,
            0x3F680229, 0x00004, 0x3F6A4232, 0x00004, 0x3F6D5BBB, 0x00004, 0x3F711E7D, 0x00004,
            0x3F8120BA, 0x00002, 0x3F936BA9, 0x02790, 0x3FE99FE1, 0x00004, 0x3FF17E2F, 0x00004,
            0x3FF2EE1D, 0x00001, 0x4033C7DB, 0x00001, 0x4034BE27, 0x00004, 0x40B20AF8, 0x00004,
            0x40CC5A21, 0x00002, 0x40E9A268, 0x00001, 0x41309084, 0x00001, 0x4192B91C, 0x00004,
            0x41DAB84F, 0x00004, 0x41E9A3FB, 0x00001, 0x41F566B2, 0x00004, 0x4292BAAF, 0x00004,
            0x435C4F14, 0x00002, 0x436CAF2B, 0x00004, 0x437E8C7C, 0x00004, 0x439116A4, 0x00001,
            0x43D3E2C3, 0x00004, 0x43E9A721, 0x00001, 0x443FB19E, 0x00038, 0x4492BDD5, 0x00004,
            0x45462EBF, 0x00004, 0x455C523A, 0x00002, 0x4584784A, 0x00004, 0x465C53CD, 0x00002,
            0x46ACC334, 0x00028, 0x46BC63C5, 0x00004, 0x46D1FDC7, 0x00004, 0x4716C404, 0x04B00,
            0x47D73984, 0x00001, 0x48043955, 0x00004, 0x495E3674, 0x00004, 0x49D73CAA, 0x00001,
            0x4A0F21AD, 0x00004, 0x4A3BED80, 0x00004, 0x4A69631D, 0x00004, 0x4A741A7A, 0x00004,
            0x4AD73E3D, 0x00001, 0x4ADD5E5C, 0x00001, 0x4AEA5A7E, 0x00004, 0x4B8B80F6, 0x00004,
            0x4BC891F4, 0x00004, 0x4BD31BDB, 0x00004, 0x4C3BF0A6, 0x00004, 0x4C54B0CF, 0x00004,
            0x4C67BA2E, 0x00004, 0x4CDFE1B5, 0x00004, 0x4D3BF239, 0x00004, 0x4D50B655, 0x00004,
            0x4D52705C, 0x00001, 0x4D8DD022, 0x00004, 0x4DBB9B79, 0x00004, 0x4E5271EF, 0x00001,
            0x4EF25E14, 0x00004, 0x4FD773E2, 0x00004, 0x4FF25FA7, 0x00004, 0x50359D63, 0x00004,
            0x50527515, 0x00001, 0x50925E91, 0x02964, 0x50F2613A, 0x00004, 0x52689B80, 0x00004,
            0x533DF099, 0x00004, 0x539DD549, 0x00004, 0x54AC4B39, 0x00004, 0x54D5CDC4, 0x00004,
            0x5586B8F0, 0x02304, 0x55D5CF57, 0x00004, 0x5686BA83, 0x02304, 0x56D5D0EA, 0x00004,
            0x5786BC16, 0x02304, 0x57F29628, 0x00004, 0x582E4A5C, 0x00004, 0x5886BDA9, 0x02304,
            0x5986BF3C, 0x02304, 0x5A86C0CF, 0x02304, 0x5B86C262, 0x02304, 0x5BA54B4B, 0x00004,
            0x5BAAACCC, 0x00004, 0x5C548FE0, 0x00001, 0x5C63C0C5, 0x00004, 0x5C86C3F5, 0x02304,
            0x5D549173, 0x00001, 0x5D6C0AED, 0x00004, 0x5D77D781, 0x00004, 0x5DCF71D9, 0x00004,
            0x5E549306, 0x00001, 0x5ECE9F76, 0x00004, 0x5F135643, 0x00004, 0x5F1D8945, 0x00004,
            0x5F74FCEE, 0x00002, 0x5FCEA109, 0x00004, 0x605EBC30, 0x00001, 0x6106657D, 0x00004,
            0x6148F6AC, 0x00810, 0x6186CBD4, 0x02304, 0x61952B51, 0x00004, 0x61BC9BB4, 0x00004,
            0x61D277C7, 0x00004, 0x61D2797A, 0x00004, 0x61D27B2D, 0x00004, 0x6226F5AD, 0x00002,
            0x624C7B30, 0x00004, 0x62743428, 0x00002, 0x6286CD67, 0x02304, 0x62A0A180, 0x00004,
            0x62C9FAAF, 0x00012, 0x62F05895, 0x00004, 0x63170940, 0x00002, 0x6371183B, 0x00004,
            0x63A0A313, 0x00004, 0x64170AD3, 0x00002, 0x64A0A4A6, 0x00004, 0x64CEA8E8, 0x00004,
            0x65170C66, 0x00002, 0x65CEAA7B, 0x00004, 0x66CEAC0E, 0x00004, 0x6701AF09, 0x00004,
            0x67A659C4, 0x00004, 0x67CEADA1, 0x00004, 0x67F25394, 0x00001, 0x680EEB85, 0x0426C,
            0x6816DFDB, 0x00004, 0x68BBA8B1, 0x00004, 0x68CEAF34, 0x00004, 0x68DE4CD2, 0x00004,
            0x697141AC, 0x00004, 0x697D1E29, 0x00004, 0x69CEB0C7, 0x00004, 0x69F256BA, 0x00001,
            0x6A09346C, 0x00132, 0x6A262628, 0x00004, 0x6A614361, 0x00004, 0x6ACEB25A, 0x00004,
            0x6AF2584D, 0x00001, 0x6B2627BB, 0x00004, 0x6BCEB3ED, 0x00004, 0x6C12BF1F, 0x00004,
            0x6C3B5E62, 0x00004, 0x6C447903, 0x00004, 0x6C99F9A0, 0x00002, 0x6CD15C44, 0x00004,
            0x6D12C0B2, 0x00004, 0x6D262AE1, 0x00004, 0x6D601EDD, 0x00004, 0x6DF7A8FB, 0x00004,
            0x6E081D6F, 0x00004, 0x6E12C245, 0x00004, 0x6E972CFB, 0x00002, 0x6EB72940, 0x067D0,
            0x6EEEC240, 0x00001, 0x6F411E56, 0x00004, 0x6F66951C, 0x00004, 0x6F6696CF, 0x00004,
            0x6F669A35, 0x00004, 0x6F884079, 0x00004, 0x6F972E8E, 0x00002, 0x70973021, 0x00002,
            0x70EEC566, 0x00001, 0x71115B78, 0x00002, 0x71599CC8, 0x00004, 0x7169F53F, 0x00004,
            0x71825204, 0x00001, 0x718621A5, 0x00132, 0x71EEC6F9, 0x00001, 0x72115D0B, 0x00002,
            0x721AE36F, 0x00004, 0x736639B3, 0x00004, 0x737D1964, 0x00004, 0x74116031, 0x00002,
            0x74441C98, 0x00001, 0x748543C7, 0x0000B, 0x758C45E8, 0x00001, 0x759FF274, 0x00002,
            0x76441FBE, 0x00001, 0x765468C3, 0x00004, 0x768C477B, 0x00001, 0x76921EEB, 0x00001,
            0x7701D95E, 0x04610, 0x771E4C88, 0x00004, 0x77275404, 0x00004, 0x7742B542, 0x00004,
            0x77442151, 0x00001, 0x77BD26F2, 0x00004, 0x780BF029, 0x00004, 0x783D2039, 0x00004,
            0x783EEFDC, 0x00004, 0x7875451A, 0x01F50, 0x788C4AA1, 0x00001, 0x789FF72D, 0x00002,
            0x78D78638, 0x00040, 0x79151C13, 0x00004, 0x7964A5A9, 0x00004, 0x7999DAFD, 0x00004,
            0x79C56A5C, 0x00004, 0x79D787CB, 0x00040, 0x7A7A3480, 0x00004, 0x7A9B68E2, 0x00004,
            0x7A9EF7D9, 0x00004, 0x7AADA3E3, 0x00004, 0x7AD7895E, 0x00040, 0x7AF09C40, 0x00002,
            0x7B022344, 0x00004, 0x7B7A3613, 0x00004, 0x7BD78AF1, 0x00040, 0x7BE8A4C6, 0x00020,
            0x7BF09DD3, 0x00002, 0x7C86783F, 0x00008, 0x7CB6E900, 0x00004, 0x7D249649, 0x00004,
            0x7D6EEAB4, 0x00001, 0x7D7A3939, 0x00004, 0x7DF0A0F9, 0x00002, 0x7E6EEC47, 0x00001,
            0x7E7E36B9, 0x00004, 0x7EF9C424, 0x00004, 0x7F4B4B10, 0x00004, 0x7FD700DC, 0x00001,
            0x806EEF6D, 0x00001, 0x81961C6F, 0x00004, 0x81AD2AF6, 0x00004, 0x81D70402, 0x00001,
            0x82D70595, 0x00001, 0x83978C43, 0x00004, 0x84B301C2, 0x00004, 0x84B4A11A, 0x00004,
            0x84FD4F59, 0x00132, 0x85FDF16A, 0x00004, 0x865605E6, 0x00004, 0x86F9272C, 0x00004,
            0x874DA6FA, 0x001D0, 0x87560779, 0x00004, 0x876D7A3B, 0x00004, 0x87F611F8, 0x00004,
            0x87F613AB, 0x00004, 0x87F61711, 0x00004, 0x87F92D34, 0x00004, 0x886D7BCE, 0x00004,
            0x88F6D6AE, 0x033D0, 0x8902E727, 0x00004, 0x89048303, 0x033D0, 0x892112D4, 0x00002,
            0x896D7D61, 0x00004, 0x89A3A2B6, 0x00004, 0x8A211467, 0x00002, 0x8A468BEC, 0x00004,
            0x8A4C1426, 0x00004, 0x8A4C178C, 0x00004, 0x8A4C193F, 0x00004, 0x8A4C1CA5, 0x00004,
            0x8AD859BF, 0x00004, 0x8B2115FA, 0x00002, 0x8B4600C9, 0x00004, 0x8B468D7F, 0x00004,
            0x8B93CB0E, 0x00004, 0x8C096F9E, 0x00004, 0x8C468F12, 0x00004, 0x8C560F58, 0x00004,
            0x8C696110, 0x00004, 0x8C804D7B, 0x00004, 0x8CA88020, 0x00038, 0x8CBBFD90, 0x00008,
            0x8CD9973A, 0x00004, 0x8D321AB8, 0x000D0, 0x8D5610EB, 0x00004, 0x8DBF8019, 0x00004,
            0x8E1D74E8, 0x00004, 0x8E56127E, 0x00004, 0x8EAEB8FF, 0x00004, 0x8EF4E556, 0x00009,
            0x8F3C763E, 0x00004, 0x8F561411, 0x00004, 0x9033EB7B, 0x00A68, 0x905615A4, 0x00004,
            0x91561737, 0x00004, 0x91AC63B3, 0x00004, 0x91E09E4C, 0x00001, 0x91E89ACF, 0x00004,
            0x925618CA, 0x00004, 0x92B2F3F3, 0x00004, 0x92E09FDF, 0x00001, 0x92EB0306, 0x00004,
            0x92F4F7F0, 0x00055, 0x93490AAF, 0x00004, 0x93561A5D, 0x00004, 0x93868FC6, 0x00004,
            0x93D4B32C, 0x00004, 0x93D4B845, 0x00004, 0x944481DD, 0x00132, 0x9497A849, 0x00004,
            0x94C400E0, 0x00004, 0x94C40293, 0x00004, 0x94C40446, 0x00004, 0x94E0A305, 0x00001,
            0x95A75FF8, 0x00001, 0x95F4FCA9, 0x00019, 0x96A7618B, 0x00001, 0x96D3F39F, 0x00002,
            0x9751BABE, 0x00400, 0x97D712D3, 0x00004, 0x982972C2, 0x00004, 0x982FCB42, 0x00004,
            0x98A764B1, 0x00001, 0x98B0956F, 0x00001, 0x996BEEAA, 0x00004, 0x99B09702, 0x00001,
            0x99B9F60B, 0x00004, 0x99F197E9, 0x00004, 0x9A39C8FC, 0x00004, 0x9A535FA0, 0x00004,
            0x9AB09895, 0x00001, 0x9AC98C4C, 0x00004, 0x9ACC0AEC, 0x00004, 0x9ACC0E52, 0x00004,
            0x9ACC1005, 0x00004, 0x9C781AE2, 0x00004, 0x9CC98F72, 0x00004, 0x9CE5CDB5, 0x00132,
            0x9CF58395, 0x00001, 0x9D6727F6, 0x00004, 0x9DC99105, 0x00004, 0x9E32AE34, 0x00004,
            0x9EC079DA, 0x00002, 0x9EED59DE, 0x00004, 0x9F730ECF, 0x00002, 0xA0731062, 0x00002,
            0xA0F49CFB, 0x00004, 0xA17311F5, 0x00002, 0xA1D06D0C, 0x00004, 0xA1F76014, 0x00004,
            0xA202729F, 0x00004, 0xA2954E3A, 0x00004, 0xA2C094C7, 0x00004, 0xA2D06E9F, 0x00004,
            0xA2F761A7, 0x00004, 0xA3419FC7, 0x00019, 0xA3F7633A, 0x00004, 0xA4042B23, 0x00004,
            0xA448D9F0, 0x00004, 0xA4B74E00, 0x00004, 0xA4D071C5, 0x00004, 0xA4D5B8C0, 0x00004,
            0xA4E3B2CF, 0x00004, 0xA5D0453A, 0x00004, 0xA7301FBD, 0x00004, 0xA7B8C97B, 0x00004,
            0xA8067616, 0x00004, 0xA83021C1, 0x00268, 0xA8533433, 0x00004, 0xA8EB523D, 0x00004,
            0xA9B04C50, 0x00004, 0xAA86248B, 0x00004, 0xAB07B11E, 0x00004, 0xAD2750BE, 0x00280,
            0xAD3920F5, 0x1241C, 0xAD4E4275, 0x00004, 0xAD67A297, 0x00004, 0xAD6F9196, 0x00004,
            0xAD9DFA6A, 0x023D4, 0xAE1283B0, 0x00004, 0xAE3497CF, 0x00004, 0xAE474936, 0x00004,
            0xAEF960AC, 0x00001, 0xAF0E8346, 0x00004, 0xAF37666F, 0x00004, 0xAF376822, 0x00004,
            0xAF3769D5, 0x00004, 0xAFF9623F, 0x00001, 0xB027F396, 0x00004, 0xB046236C, 0x00004,
            0xB0CD214B, 0x00004, 0xB0F963D2, 0x00001, 0xB125CDDC, 0x00004, 0xB14624FF, 0x00004,
            0xB189D2B8, 0x00004, 0xB189D46B, 0x00004, 0xB189D7D1, 0x00004, 0xB19386DE, 0x00004,
            0xB1C26FB0, 0x000F8, 0xB1C7C436, 0x00004, 0xB1DDDCA8, 0x00028, 0xB2137AFE, 0x00004,
            0xB25C772B, 0x50C20, 0xB3462825, 0x00004, 0xB3FF0924, 0x00001, 0xB42F0EDC, 0x00004,
            0xB47E1776, 0x0001E, 0xB4FF0AB7, 0x00001, 0xB58354DB, 0x00004, 0xB5C02173, 0x00004,
            0xB5FF0C4A, 0x00001, 0xB6C02306, 0x00004, 0xB6C76A95, 0x00004, 0xB7C02499, 0x00004,
            0xB8495C0F, 0x00004, 0xB868EE77, 0x00040, 0xB9495DA2, 0x00004, 0xB95B1BB9, 0x00004,
            0xB968F00A, 0x00010, 0xB98F962B, 0x00004, 0xB9C0ECFC, 0x00004, 0xB9E1DE0C, 0x00004,
            0xBA29D287, 0x00001, 0xBA495F35, 0x00004, 0xBB1DE8EF, 0x00004, 0xBB29D41A, 0x00001,
            0xBB7B57FB, 0x00004, 0xBC29D5AD, 0x00001, 0xBC4ADA83, 0x00004, 0xBE3BD183, 0x00004,
            0xBF17C11F, 0x00004, 0xBF8E28DF, 0x00002, 0xC017C2B2, 0x00004, 0xC0362EDD, 0x00004,
            0xC08E2A72, 0x00002, 0xC0D49E2D, 0x00004, 0xC0DE5C5F, 0x00408, 0xC10889B1, 0x00004,
            0xC117C445, 0x00004, 0xC1264133, 0x00001, 0xC18E2C05, 0x00002, 0xC1BA2375, 0x00004,
            0xC22642C6, 0x00001, 0xC23AF741, 0x00004, 0xC2EFEC6A, 0x00004, 0xC3264459, 0x00001,
            0xC35F6291, 0x00004, 0xC37F267B, 0x00158, 0xC3FB9E77, 0x000A0, 0xC4F35C2E, 0x00004,
            0xC5FC19DC, 0x00002, 0xC6102A59, 0x00004, 0xC69945F9, 0x00004, 0xC7161487, 0x00004,
            0xC7652F1C, 0x00004, 0xC7911610, 0x00004, 0xC87219F6, 0x00132, 0xC89117A3, 0x00004,
            0xC8E44448, 0x00004, 0xC94D1C48, 0x00004, 0xC9541EB3, 0x00002, 0xC96FEA27, 0x00004,
            0xC9A133BC, 0x00004, 0xC9A138D5, 0x00004, 0xC9E6E098, 0x00004, 0xCA0279C5, 0x00004,
            0xCA5FA1A3, 0x00004, 0xCA8A8CEE, 0x00004, 0xCA911AC9, 0x00004, 0xCAE4476E, 0x00004,
            0xCB135C68, 0x00004, 0xCBE44901, 0x00004, 0xCC45DA54, 0x00004, 0xCCC153CD, 0x00004,
            0xCE07D358, 0x0001C, 0xCE4AC6FA, 0x00001, 0xCE76E539, 0x00004, 0xCEEB37FF, 0x00001,
            0xCF5BC550, 0x00004, 0xCF90B39A, 0x00004, 0xCFEB3992, 0x00001, 0xD033E667, 0x00004,
            0xD05BC6E3, 0x00004, 0xD08391B9, 0x00004, 0xD0EB3B25, 0x00001, 0xD105027A, 0x00132,
            0xD14C95F9, 0x00004, 0xD15BC876, 0x00004, 0xD224F9AC, 0x00F1C, 0xD25BCA09, 0x00004,
            0xD25E08A0, 0x00004, 0xD2FC64C7, 0x00004, 0xD35BCB9C, 0x00004, 0xD35E0A33, 0x00004,
            0xD3ED94AF, 0x00004, 0xD45BCD2F, 0x00004, 0xD4F8410C, 0x00002, 0xD55BCEC2, 0x00004,
            0xD65BD055, 0x00004, 0xD6F84432, 0x00002, 0xD7F845C5, 0x00002, 0xD81C8A46, 0x00004,
            0xDA5E1538, 0x00004, 0xDB5E16CB, 0x00004, 0xDBE374D7, 0x00004, 0xDBEF0145, 0x00004,
            0xDC5E185E, 0x00004, 0xDC82C7C9, 0x00004, 0xDCBDFB50, 0x00004, 0xDD12C9A5, 0x00008,
            0xDD5E19F1, 0x00004, 0xDDBDFCE3, 0x00004, 0xDE5E1B84, 0x00004, 0xDEBDFE76, 0x00004,
            0xDF5E1D17, 0x00004, 0xDFAAEECD, 0x00004, 0xDFC8508B, 0x00001, 0xE048C668, 0x00008,
            0xE05E1EAA, 0x00004, 0xE07F44FC, 0x02304, 0xE0C8521E, 0x00001, 0xE15E203D, 0x00004,
            0xE17F468F, 0x02304, 0xE1C853B1, 0x00001, 0xE2003E60, 0x00280, 0xE250A142, 0x00004,
            0xE2798DDE, 0x00001, 0xE2950DA8, 0x00001, 0xE2ED6B1D, 0x00320, 0xE2F6E456, 0x00008,
            0xE3181BAC, 0x00001, 0xE3ABBA00, 0x00004, 0xE3ED8F16, 0x00004, 0xE40A0EF4, 0x00004,
            0xE479EE37, 0x00810, 0xE47F4B48, 0x02304, 0xE5004319, 0x00280, 0xE5181ED2, 0x00001,
            0xE579EFCA, 0x00810, 0xE57F4CDB, 0x02304, 0xE6182065, 0x00001, 0xE64A93E0, 0x00001,
            0xE67F4E6E, 0x02304, 0xE74A9573, 0x00001, 0xE75196AB, 0x00004, 0xE77F5001, 0x02304,
            0xE7C7FE6B, 0x00002, 0xE851983E, 0x00004, 0xE85BEA57, 0x00004, 0xE87F5194, 0x02304,
            0xE8C7FFFE, 0x00002, 0xE9131991, 0x00004, 0xE94A9899, 0x00001, 0xE95199D1, 0x00004,
            0xE97F5327, 0x02304, 0xE9BE28BF, 0x000F0, 0xE9C80191, 0x00002, 0xEA40157B, 0x00014,
            0xEA7F54BA, 0x02304, 0xEB07C276, 0x00004, 0xEB7F564D, 0x02304, 0xECF1AE60, 0x02304,
            0xEDCE8E4C, 0x00004, 0xEDF1AFF3, 0x02304, 0xEE7B2ABD, 0x00001, 0xEE7D64D5, 0x00538,
            0xEE841484, 0x00004, 0xEEE5A3F8, 0x033D0, 0xEEF1B186, 0x02304, 0xEFCAE04E, 0x116C4,
            0xEFCE9172, 0x00004, 0xEFDC1AB1, 0x00004, 0xEFF1B319, 0x02304, 0xF0159FB2, 0x00004,
            0xF0576532, 0x00002, 0xF06213E4, 0x00004, 0xF0CE9305, 0x00004, 0xF0F1B4AC, 0x02304,
            0xF19F7785, 0x06000, 0xF1C4948B, 0x00004, 0xF1F1B63F, 0x02304, 0xF239E881, 0x02955,
            0xF25C070E, 0x00110, 0xF26B9151, 0x00004, 0xF273F5B7, 0x00004, 0xF2F1B7D2, 0x02304,
            0xF36C4BC3, 0x00004, 0xF3F1B965, 0x02304, 0xF5A72492, 0x00004, 0xF5BACCEC, 0x00004,
            0xF64719D9, 0x00004, 0xF6C672E9, 0x00004, 0xF6FB2550, 0x00001, 0xF73CDD1F, 0x00004,
            0xF75FC566, 0x00004, 0xF75FC719, 0x00004, 0xF7DFDD95, 0x00004, 0xF8154AC9, 0x00004,
            0xF8A1B32F, 0x00004, 0xF8E07F9B, 0x00004, 0xF8FB2876, 0x00001, 0xF9FB2A09, 0x00001,
            0xFA43BB59, 0x00004, 0xFAA7378A, 0x00004, 0xFAF1C46A, 0x02304, 0xFB2AE32B, 0x03208,
            0xFB5133BC, 0x00004, 0xFBF1C5FD, 0x02304, 0xFBFF61F2, 0x00004, 0xFC1AF2FC, 0x00001,
            0xFC4493F8, 0x00002, 0xFCB63E1B, 0x00001, 0xFD1AF48F, 0x00001, 0xFDB63FAE, 0x00001,
            0xFE1AF622, 0x00001, 0xFE2E9869, 0x00004, 0xFE44971E, 0x00002, 0xFE4D59C7, 0x00004,
            0xFEB13D33, 0x00002, 0xFEB64141, 0x00001, 0xFEE68CE1, 0x00004, 0xFF4498B1, 0x00002,
            0xFFA1F3C8, 0x00004,
        };
    }
}
