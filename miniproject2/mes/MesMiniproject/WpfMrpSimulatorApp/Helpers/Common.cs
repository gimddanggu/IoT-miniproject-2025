using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MahApps.Metro.Controls.Dialogs;

namespace WpfMrpSimulatorApp.Helpers
{
    /// <summary>
    /// 프로제게트 내에서 공통으로 사용하는 정적 클래스
    /// 클래스 자체가 static 일 필요는 없음. 사용할 변수들이 static 이어야 함 !!
    /// 
    /// </summary>
    public class Common
    {
        // DB연결 문자열
        public static readonly string CONNSTR = "Server=localhost;Database=miniproject;Uid=root;Password=12345;Charset=utf8";

        // MahApps.Metro 다이어로그 코디네이터(MVM에서 사용하기 위해서)
        public static IDialogCoordinator DIALOGCOORDINATOR;
    }
}
