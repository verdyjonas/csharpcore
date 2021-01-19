using System.Collections.Generic;

namespace csharpcore
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }


        public void MyUpDateQuality()
        {
            int Downday = 1;
            int Max = 50;
            int Min = 0;
            int result = 0;           
          
            foreach (var i in Items)
            {
              
                   i.SellIn -= Downday;
                  switch (i.Name)
                  {
                    case ("Sulfuras, Hand of Ragnaros"):
                        {                        
                                break; 
                        }

                    case ("Backstage passes to a TAFKAL80ETC concert"):
                        {
                            if (i.SellIn <= 10 && i.SellIn >= 5) { i.Quality = 2; }
                            else if (i.SellIn >= 5) { i.Quality = 3; }
                            break;
                        }
                    case ("Aged Brie"):
                        {
                           if (i.SellIn <= 10 && i.SellIn <= 5)
                            {
                                result = i.Quality + 2;
                               if (result > Max) { i.Quality = Max; }
                               else { i.Quality = result; }
                           }
                                break;
                        }
                    case ("Conjured Mana Cake"):
                        {
                              result =  i.Quality - (2 * Downday); 
                              if(result < 0) { i.Quality = Min; }
                              else { i.Quality = result; }
                              break;
                        }
                     case ("Elixir of the Mongoose"):
                            {
                                if (i.SellIn <= 0)
                                {
                                    result = i.Quality - (2 * Downday);
                                    if (result < 0) { i.Quality = Min; }
                                    else { i.Quality = result; }
                                }
                                else { i.Quality -= Downday; }
                                break;
                            }
                      case ("+5 Dexterity Vest"):
                            {
                                if (i.SellIn <= 0)
                                {
                                    result = i.Quality - (2 * Downday);
                                    if (result < 0) { i.Quality = Min; }
                                    else { i.Quality = result; }
                                }
                                else { i.Quality -= Downday; }
                                break;
                            }
                  }

               
              
            }
           
        }
        public void UpdateQuality()
        {

            MyUpDateQuality(); 
            //for (var i = 0; i < Items.Count; i++)
            //{
            //    if (Items[i].Name != "Aged Brie" && Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
            //    {
            //        if (Items[i].Quality > 0)
            //        {
            //            if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
            //            {
            //                Items[i].Quality = Items[i].Quality - 1;
            //            }
            //        }
            //    }
            //    else
            //    {
            //        if (Items[i].Quality < 50)
            //        {
            //            Items[i].Quality = Items[i].Quality + 1;

            //            if (Items[i].Name == "Backstage passes to a TAFKAL80ETC concert")
            //            {
            //                if (Items[i].SellIn < 11)
            //                {
            //                    if (Items[i].Quality < 50)
            //                    {
            //                        Items[i].Quality = Items[i].Quality + 1;
            //                    }
            //                }

            //                if (Items[i].SellIn < 6)
            //                {
            //                    if (Items[i].Quality < 50)
            //                    {
            //                        Items[i].Quality = Items[i].Quality + 1;
            //                    }
            //                }
            //            }
            //        }
            //    }

            //    if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
            //    {
            //        Items[i].SellIn = Items[i].SellIn - 1;
            //    }

            //    if (Items[i].SellIn < 0)
            //    {
            //        if (Items[i].Name != "Aged Brie")
            //        {
            //            if (Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
            //            {
            //                if (Items[i].Quality > 0)
            //                {
            //                    if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
            //                    {
            //                        Items[i].Quality = Items[i].Quality - 1;
            //                    }
            //                }
            //            }
            //            else
            //            {
            //                Items[i].Quality = Items[i].Quality - Items[i].Quality; // !!!!     = 0 
            //            }
            //        }
            //        else
            //        {
            //            if (Items[i].Quality < 50)
            //            {
            //                Items[i].Quality = Items[i].Quality + 1;
            //            }
            //        }
            //    }
            //}
        }
    }
}
