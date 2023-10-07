using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

          public class Property
        {
            public string Header { get; set; }
            public string Image { get; set; }
            public bool NewItem { get; set; }
            public Property[] Items { get; set; }

            public static Property[] GetData(string val)
            {
                return new Property[]
                {
                new Property
                {
                    Header = "Fruit",
                    Image = "/Content/images/Fruit.png",
                    Items = new Property[]
                    {
                        new Property { Header="Apple" },
                        new Property { Header="Mango" },
                        new Property { Header="Orange",
                            Image ="/Content/images/Fruit.png",
                            Items = new Property[] {
                                new Property { Header="Apple" },
                                new Property { Header="Mango", NewItem=true },
                                new Property { Header="Orange" },
                                new Property { Header="----" }}
                        },
                        new Property { Header="-----", NewItem=true },
                        new Property { Header="******" }
                    }
                },
                new Property{
                    Header = "Vegetable",
                    Image = "/Content/images/Vegetable.png",
                    Items = new Property[]{
                        new Property{ Header = "Salad" },
                        new Property{ Header = "Potato" },
                        new Property{ Header = "Mushroom", NewItem = true },
                        new Property{ Header = "*******" },
                        new Property{ Header = "-----" }
                    }
                },
                new Property{
                    Header = "Home",
                    Image = "/Content/images/home.png",
                    Items = new Property[] {
                        new Property{ Header = "" },
                        new Property{ Header = "", NewItem = true },
                        new Property{ Header = "", NewItem = true },
                        new Property{ Header = "" },
                        new Property{ Header = "" }
                    }
                }
                };
            }
        }
       

    }
}
