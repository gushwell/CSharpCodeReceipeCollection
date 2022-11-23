using System.Diagnostics;

var traceSwitch = new TraceSwitch("General", "Entire Application");
// TraceLevelがWarning以上を出力　　TraceLevel: Off, Error, Warning, Info, Verbose　
traceSwitch.Level = TraceLevel.Warning; 
Debug.WriteLineIf(traceSwitch.TraceVerbose, "デバッグ出力 Verbose");
Debug.WriteLineIf(traceSwitch.TraceInfo, "デバッグ出力 Info");
Debug.WriteLineIf(traceSwitch.TraceWarning, "デバッグ出力 Warning");
Debug.WriteLineIf(traceSwitch.TraceError, "デバッグ出力 Error");
Debug.WriteLine("デバッグ出力");  // 無条件に出力

