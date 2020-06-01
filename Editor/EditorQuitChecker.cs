using UnityEditor;
using UnityEngine;

namespace Kogane.Internal
{
	[InitializeOnLoad]
	internal static class EditorQuitChecker
	{
		static EditorQuitChecker()
		{
			EditorApplication.wantsToQuit += () =>
			{
				var isJapanese = Application.systemLanguage == SystemLanguage.Japanese;
				var message    = isJapanese ? "Unity を終了しますか？" : "Exit the Unity Editor?";
				var ok         = isJapanese ? "はい" : "Yes";
				var cancel     = isJapanese ? "いいえ" : "No";

				return EditorUtility.DisplayDialog( "Unity", message, ok, cancel );
			};
		}
	}
}