using System;


namespace Comum
{
  public class ProgressDialogTask : Android.OS.AsyncTask<String, String, String>
  {

    public Func<Boolean> RunInBackgroundMethod { get; set; }
    public Func<Boolean> OnPostExecuteMethod { get; set; }

    protected override string RunInBackground(params string[] @params)
    {
      RunInBackgroundMethod?.Invoke();
      return "OK";
    }

    protected override void OnPostExecute(string result)
    {
      base.OnPostExecute( result );
      OnPostExecuteMethod?.Invoke();
    }

  }
}