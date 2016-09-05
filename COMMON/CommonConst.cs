using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BtcConvertPro.Common
{
    public static class CommonConst
    {
        #region メッセージ

        //2016/02/05 HANAWA EDIT START
        //public const string INFO_START = "∵∵∵            VCとFC転換 移行開始   {0}           ∵∵∵";
        //public const string INFO_END = "∴∴∴            VCとFC転換 移行終了   {0}           ∴∴∴";

        public const string INFO_START = "∵∵∵            データ移行開始   {0}           ∵∵∵";
        public const string INFO_END = "∴∴∴            データ移行移行終了   {0}           ∴∴∴";
        //2016/02/05 HANAWA EDIT END

        public const string ERR_COMPANY_NASI = "  ★★★    エラー：移行対象加盟店がありません。    ★★★";
        public const string ERR_COMPANYINFO_NASI = "  ★★★    エラー：移行対象加盟店の情報がありません。店舗CD： {0}    ★★★";

        public const string COMPANY_START = "    ▽▽▽      移行対象加盟店取得開始   {0}      ▽▽▽";
        public const string COMPANY_END = "    △△△      移行対象加盟店取得終了   {0}      △△△";

        public const string REMOVE_START = "    ▽▽▽      店舗CD： {0}   開始: {1}      ▽▽▽";
        public const string REMOVE_END = "    △△△      店舗CD： {0}   終了: {1}      △△△";

        public const string EX = "■異常終了 {0}";
        public const string EX_AUTO = "■AUTOお知らせ-異常終了 {0}";

        public const string KOUSINSYA_NAME = "管理者";

        public const string EX_COMPANY_ERR = "        ★★★    エラー：移行対象加盟店が異常終了しました。店舗CD： {0}    ★★★";
        #endregion

        #region 文字列

        /// <summary>
        /// 未設定
        /// </summary>
        public const string MEI_TANTOUSYA_MISETTE = "未設定";
        /// <summary>
        /// Convert
        /// </summary>
        public const string ID_SAKUSEISYA = "Convert";
        /// <summary>
        /// データ取込
        /// </summary>
        public const string MEI_SAKUSEISYA = "データ取込";

        /// <summary>
        /// 工事部位--その他
        /// </summary>
        public const string KOJI_BUII_OTHER = "その他";

        /// <summary>
        /// SYSDATE_YYYYMMDD
        /// </summary>
        public static string SYSDATE_YYYYMMDD = DateTime.Now.Date.ToString("yyyyMMdd");

        #endregion

        #region 種別コード


        /// <summary>
        /// 敬称--24
        /// </summary>
        public const int KBN_SBT_CD_KEISYO = 24;

        /// <summary>
        ///自社顧客ランクNO--25
        /// </summary>
        public const int KBN_SBT_CD_JISHA_KOKYAKU_RANK_NO = 25;

        /// <summary>
        /// 工法
        /// </summary>
        public const int KBN_SBT_CD_KOUHOU = 30;

        /// <summary>
        /// 建物区分--39
        /// </summary>
        public const int KBN_SBT_CD_TATEMONOKBN = 39;

        /// <summary>
        /// 物件区分--43
        /// </summary>
        public const int KBN_SBT_CD_BUKKEN = 43;

        /// <summary>
        /// 見込ランク--54
        /// </summary>
        public const int KBN_SBT_CD_MIKOMIRANKNO = 54;

        /// <summary>
        /// 性別--10004
        /// </summary>
        public const int KBN_SBT_CD_SEX = 10004;

        /// <summary>
        /// 顧客分類
        /// </summary>
        public const int KBN_SBT_CD_KOKYAKU_BUNRUI1 = 101;
        public const int KBN_SBT_CD_KOKYAKU_BUNRUI2 = 102;
        public const int KBN_SBT_CD_KOKYAKU_BUNRUI3 = 103;
        //public const int KBN_SBT_CD_KOKYAKU_BUNRUI4 = 104;
        public const int KBN_SBT_CD_KOKYAKU_BUNRUI5 = 105;
        
        /// <summary>
        /// 採番桁数--8
        /// </summary>
        public const int SAIBAN_NO_KETA = 8;

        #endregion

        #region SEQ種別区分

        public const int SEQ_KBN_SOSIKI1 = 1;               // 組織1
        public const int SEQ_KBN_SOSIKI2 = 2;               // 組織2
        public const int SEQ_KBN_KENGEN = 3;                // 権限
        public const int SEQ_KBN_TANTOU = 4;                // 担当者
        public const int SEQ_KBN_KOUZA = 5;                 // 口座
        public const int SEQ_KBN_SYOUHIZEI = 6;             // 消費税
        public const int SEQ_KBN_GYOUSYA = 7;               // 業者
        public const int SEQ_KBN_NOAREA = 8;                // No.1エリア
        public const int SEQ_KBN_MYPAGENEWS = 9;            // マイページお知らせ
        public const int SEQ_KBN_KOKYAKU = 10;              // 顧客
        public const int SEQ_KBN_KATSUDOU = 11;             // 活動
        public const int SEQ_KBN_TOIAWASE = 12;             // お問合せ
        public const int SEQ_KBN_TOIAWASEDTL = 13;          // お問合せ明細
        public const int SEQ_KBN_TATEMONO = 14;             // 建物
        public const int SEQ_KBN_SETUBIKIKI = 15;           // 住宅設備機器
        public const int SEQ_KBN_BUKKEN = 16;               // 物件
        public const int SEQ_KBN_BUKKENDOC = 17;            // 物件書類
        public const int SEQ_KBN_KOUTEI = 18;               // 工程
        public const int SEQ_KBN_KOUJIMEI = 19;             // 設計変更追加工事名
        public const int SEQ_KBN_MIT = 20;                  // 見積ヘッダ
        public const int SEQ_KBN_MITDETAIL = 21;            // 見積明細
        public const int SEQ_KBN_JIK = 22;                  // 実行予算ヘッダ
        public const int SEQ_KBN_JIKDETAIL = 23;            // 実行予算明細
        public const int SEQ_KBN_HAT = 24;                  // 発注ヘッダ
        public const int SEQ_KBN_SEI = 25;                  // 請求
        public const int SEQ_KBN_JISYAMIT = 26;             // 自社見積ヘッダ
        public const int SEQ_KBN_FILE = 27;                 // ファイル
        public const int SEQ_KBN_NYUUKIN = 28;              // 入金予定
        public const int SEQ_KBN_JISYA = 29;                // 自社
        public const int SEQ_KBN_BUZAIHDR = 30;             // 部材ヘッダSEQ
        public const int SEQ_KBN_BUZAIDTL = 31;             // 部材明細SEQ
        public const int SEQ_KBN_SYURI_HISTORY = 32;        // 修理点検履歴
        #endregion

        #region システム区分

        public const int SYSTEM_KBN_FC = 1;               // FC
        public const int SYSTEM_KBN_VC = 3;               // VC

        #endregion

        //税端数処理区分(切捨て、切上、四捨五入)
        public static int ZEI_SYORI_KBN;

        //顧客番号
        public static string KOKYAKU_NO_BEFOR;
       
        //基本顧客ランク、リピート数の計算
        public static int  KOKYAKU_RANK_NO;
        public static int  REPEAT_CNT;

    }
}
