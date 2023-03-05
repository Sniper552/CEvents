using DynamicData;
using CEvents.Models;
using ReactiveUI;
using System;
using System.Collections.ObjectModel;
using System.Reactive.Linq;

namespace CEvents.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private EventC vkladka;
        private readonly ReadOnlyObservableCollection<EventC> vkladka1;
        private readonly ReadOnlyObservableCollection<EventC> vkladka2;
        private readonly ReadOnlyObservableCollection<EventC> vkladka3;
        private readonly ReadOnlyObservableCollection<EventC> vkladka4;
        private readonly ReadOnlyObservableCollection<EventC> vkladka5;
        private readonly ReadOnlyObservableCollection<EventC> vkladka6;
        private readonly ReadOnlyObservableCollection<EventC> vkladka7;
        private readonly ReadOnlyObservableCollection<EventC> vkladka8;
        private readonly ReadOnlyObservableCollection<EventC> vkladka9;
        private SourceList<EventC> sourceList;
        private EventC[] events;
        public MainWindowViewModel()
        {
            events = Serializer<EventC[]>.Load("../../../../data.xml");
            sourceList = new SourceList<EventC>();

            foreach (EventC ch in events)
            {
                sourceList.Add(ch);
            }

            sourceList.Connect().AutoRefresh(x => x.Category).Filter(x => x.Category.Children == true).ObserveOn(RxApp.MainThreadScheduler).Bind(out vkladka1).Subscribe();
            sourceList.Connect().AutoRefresh(x => x.Category).Filter(x => x.Category.Sport == true).ObserveOn(RxApp.MainThreadScheduler).Bind(out vkladka2).Subscribe();
            sourceList.Connect().AutoRefresh(x => x.Category).Filter(x => x.Category.Cultur == true).ObserveOn(RxApp.MainThreadScheduler).Bind(out vkladka3).Subscribe();
            sourceList.Connect().AutoRefresh(x => x.Category).Filter(x => x.Category.Excursion == true).ObserveOn(RxApp.MainThreadScheduler).Bind(out vkladka4).Subscribe();
            sourceList.Connect().AutoRefresh(x => x.Category).Filter(x => x.Category.Lifestyle == true).ObserveOn(RxApp.MainThreadScheduler).Bind(out vkladka5).Subscribe();
            sourceList.Connect().AutoRefresh(x => x.Category).Filter(x => x.Category.Party == true).ObserveOn(RxApp.MainThreadScheduler).Bind(out vkladka6).Subscribe();
            sourceList.Connect().AutoRefresh(x => x.Category).Filter(x => x.Category.Education == true).ObserveOn(RxApp.MainThreadScheduler).Bind(out vkladka7).Subscribe();
            sourceList.Connect().AutoRefresh(x => x.Category).Filter(x => x.Category.Online == true).ObserveOn(RxApp.MainThreadScheduler).Bind(out vkladka8).Subscribe();
            sourceList.Connect().AutoRefresh(x => x.Category).Filter(x => x.Category.Show == true).ObserveOn(RxApp.MainThreadScheduler).Bind(out vkladka9).Subscribe();
        }
        public ReadOnlyObservableCollection<EventC> Vkladka1 => vkladka1;
        public ReadOnlyObservableCollection<EventC> Vkladka2 => vkladka2;
        public ReadOnlyObservableCollection<EventC> Vkladka3 => vkladka3;
        public ReadOnlyObservableCollection<EventC> Vkladka4 => vkladka4;
        public ReadOnlyObservableCollection<EventC> Vkladka5 => vkladka5;
        public ReadOnlyObservableCollection<EventC> Vkladka6 => vkladka6;
        public ReadOnlyObservableCollection<EventC> Vkladka7 => vkladka7;
        public ReadOnlyObservableCollection<EventC> Vkladka8 => vkladka8;
        public ReadOnlyObservableCollection<EventC> Vkladka9 => vkladka9;
    }

}