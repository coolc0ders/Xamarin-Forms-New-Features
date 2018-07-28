using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewXFormsFeatures.ViewModels
{
    public class MainViewModel : ReactiveObject
    {
        string _spanText;
        public string SpanText
        {
            get { return _spanText; }
            set
            {
                this.RaiseAndSetIfChanged(ref _spanText, value);
            }
        }
        public ReactiveCommand SpanTappedCommand { get; set; }

        public MainViewModel()
        {
            SpanText = "Span text...";
            SpanTappedCommand = ReactiveCommand.Create(async () =>
            {
                await App.Current.MainPage.DisplayAlert("Span Tapped", "You tapped the span", "cancel");
            });
        }
    }
}
