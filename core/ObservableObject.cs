class ObservableObject : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChnaged;

    protected void OnPropertyChanged([CallerMemeberName]string name = null)
    {
      
    }
}