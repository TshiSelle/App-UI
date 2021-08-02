class Relay : ICommand
{
  private Action<object> _execute;
  private Func<object, bool> _canExecute;

  public event EventHandler CanExecuteChanged
  {
    add{ CommandManager.RequerySuggested += value;}
    remove {CommandManager.RequerySuggested -= value;}
  }
  public Relay(Action<object> execute, Func<object, bool> canExecute = null)
  {
    
  }
}