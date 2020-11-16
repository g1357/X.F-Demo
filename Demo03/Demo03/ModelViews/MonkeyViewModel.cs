using Demo03.Data;
using Demo03.Helpers;
using Demo03.Models;
using Demo03.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Demo03.ModelViews
{
    public class MonkeyViewModel
    {
        private MonkeyPage _page;
        public ObservableCollection<Grouping<string, Monkey>> MonkeysGrouped { get; set; }
        public int MonkeyCount { get; set; }

        public MonkeyViewModel(MonkeyPage page)
        {
            _page = page;

            var Monkeys = MonkeyData.Monkeys;
            MonkeyCount = Monkeys.Count;
            var sorted = from monkey in Monkeys
                         orderby monkey.Name
                         group monkey by monkey.Name[0].ToString() into monkeyGroup
                         select new Grouping<string, Monkey>(monkeyGroup.Key, monkeyGroup);
            MonkeysGrouped = new ObservableCollection<Grouping<string, Monkey>>(sorted);
        }
    }
}
