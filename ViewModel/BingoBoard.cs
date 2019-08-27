using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace VideoEssayBingo.ViewModel
{
    public class BingoBoard : ObservableObject
    {
        //Random generator = new Random(DateTime.Now.Millisecond);
        public List<Item> itemList = new List<Item>();

        public BingoBoard()
        {
            itemList.Add(new Item("Awkward pause", false));
            itemList.Add(new Item("THEMES", false));
            itemList.Add(new Item("Statement without evidence or reference", false));
            itemList.Add(new Item("Buzzwords", false));
            itemList.Add(new Item("Putting words on screen", false));
            itemList.Add(new Item("Softly-spoken and fragile", false));
            itemList.Add(new Item("\"This reminds me of...* insert random philosopher * \"", false));
            itemList.Add(new Item("Crappy music (especially piano)", false));
            itemList.Add(new Item("Insulting the viewers' intelligence", false));
            itemList.Add(new Item("Reaching", false));
            itemList.Add(new Item("Strange font or visual", false));
            itemList.Add(new Item("Metanarrative", false));
            itemList.Add(new Item("FREE SPACE", false));
            itemList.Add(new Item("Citing a pretentious book", false));
            itemList.Add(new Item("Artsy filter", false));
            itemList.Add(new Item("\"This is a quote, so it must be true\"", false));
            itemList.Add(new Item("Subverts expectations", false));
            itemList.Add(new Item("\"I could explain this.....but i won't\"", false));
            itemList.Add(new Item("Misplaced humour/Please laugh moment", false));
            itemList.Add(new Item("\"If you don't agree, you're a ist / phobe / tism\"", false));
            itemList.Add(new Item("Strawman", false));
            itemList.Add(new Item("Video contains hypocrisy/contradiction within itself", false));
            itemList.Add(new Item("string22", false));
            itemList.Add(new Item("string23", false));
            itemList.Add(new Item("string24", false));
        }

        public List<Item> ItemList
        {
            get { return itemList; }
            set { SetProperty(ref itemList, value); }
        }
    }
}
