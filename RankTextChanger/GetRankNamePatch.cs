using HarmonyLib;
using System;

namespace RankTextChanger
{
    [HarmonyPatch(
        typeof(RankModel),
        nameof(RankModel.GetRankName),
        new Type[] { typeof(RankModel.Rank) }
        )]
    internal class GetRankNamePatch
    {
        public static void Postfix(RankModel.Rank rank, ref string __result)
        {
            switch (rank)
            {
                case RankModel.Rank.E:
                    __result = "超悪";
                    break;
                case RankModel.Rank.D:
                    __result = "悪";
                    break;
                case RankModel.Rank.C:
                    __result = "微悪";
                    break;
                case RankModel.Rank.B:
                    __result = "普通";
                    break;
                case RankModel.Rank.A:
                    __result = "可";
                    break;
                case RankModel.Rank.S:
                    __result = "良";
                    break;
                case RankModel.Rank.SS:
                    __result = "超良";
                    break;
                case RankModel.Rank.SSS:
                    __result = "神";
                    break;
                default:
                    break;
            }
        }
    }
}
