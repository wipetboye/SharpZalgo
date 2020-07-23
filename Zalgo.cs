using System;

class Zalgo {
    public static readonly ushort[] ZalgoUp = {
        0x030d, 0x030e, 0x0304, 0x0305,
        0x033f, 0x0311, 0x0306, 0x0310,
        0x0352, 0x0357, 0x0351, 0x0307,
        0x0308, 0x030a, 0x0342, 0x0343,
        0x0344, 0x034a, 0x034b, 0x034c,
        0x0303, 0x0302, 0x030c, 0x0350,
        0x0300, 0x0301, 0x030b, 0x030f,
        0x0312, 0x0313, 0x0314, 0x033d,
        0x0309, 0x0363, 0x0364, 0x0365,
        0x0366, 0x0367, 0x0368, 0x0369,
        0x036a, 0x036b, 0x036c, 0x036d,
        0x036e, 0x036f, 0x033e, 0x035b
    };

    public static readonly ushort[] ZalgoMid = {
        0x0315, 0x031b, 0x0340, 0x0341,
        0x0358, 0x0321, 0x0322, 0x0327,
        0x0328, 0x0334, 0x0335, 0x0336,
        0x034f, 0x035c, 0x035d, 0x035e,
        0x035f, 0x0360, 0x0362, 0x0338,
        0x0337, 0x0361, 0x0489
    };

    public static readonly ushort[] ZalgoDown = {
        0x0316, 0x0317, 0x0318, 0x0319,
        0x031c, 0x031d, 0x031e, 0x031f,
        0x0320, 0x0324, 0x0325, 0x0326,
        0x0329, 0x032a, 0x032b, 0x032c,
        0x032d, 0x032e, 0x032f, 0x0330,
        0x0331, 0x0332, 0x0333, 0x0339,
        0x033a, 0x033b, 0x033c, 0x0345,
        0x0347, 0x0348, 0x0349, 0x034d,
        0x034e, 0x0353, 0x0354, 0x0355,
        0x0356, 0x0359, 0x035a, 0x0323
    };

    private static readonly Random RNG = new Random();

    public static bool IsZalgoChar(char c, int zalgoUpLen, int zalgoDownLen, int zalgoMidLen) {
        for (int i = 0; i < zalgoUpLen; i++)
            if (c == (char)ZalgoUp[i])
                return true;
        for (int i = 0; i < zalgoDownLen; i++)
            if (c == (char)ZalgoDown[i])
                return true;
        for (int i = 0; i < zalgoMidLen; i++)
            if (c == (char)ZalgoMid[i])
                return true;
        return false;
    }

    public static string GenerateString(string originalStr, bool zalgoUp, bool zalgoMid, bool zalgoDown, bool ignoreZalgoChars, ushort zalgoRate) {
        string ret = "";
        char[] strChars = originalStr.ToCharArray();

        for (int i = 0; i < originalStr.Length; i++) {
            if (!ignoreZalgoChars && IsZalgoChar(strChars[i], zalgoUp ? ZalgoUp.Length : 0, zalgoDown ? ZalgoDown.Length : 0, zalgoMid ? ZalgoMid.Length : 0))
                continue;

            ret += strChars[i];
            if (strChars[i] < 32)
                continue;

            for (int j = 0; zalgoUp && j < RNG.Next(8) + zalgoRate; j++)
                ret += (char)ZalgoUp[RNG.Next(ZalgoUp.Length)];
            for (int j = 0; zalgoMid && j < (RNG.Next(6) / 2) + zalgoRate; j++)
                ret += (char)ZalgoMid[RNG.Next(ZalgoMid.Length)];
            for (int j = 0; zalgoDown && j < RNG.Next(64) / 4 + 3 + zalgoRate; j++)
                ret += (char)ZalgoDown[RNG.Next(ZalgoDown.Length)];
        }

        return ret;
    }
}
