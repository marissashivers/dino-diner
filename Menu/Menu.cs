/*  Menu.cs
*   Author: Marissa Shivers
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class that represents the menu =)
    /// </summary>
    public class Menu
    {
        /// <summary>
        /// Property for Available Menu Items. Returns a list containing one instance
        /// of every menu item currently offered by DinoDiner
        /// </summary>
        public List<IMenuItem> AvailableMenuItems
        {
            get
            {
                List<IMenuItem> menuItems = new List<IMenuItem>();

                //Drinks
                JurassicJava jj = new JurassicJava();
                menuItems.Add(jj);
                Sodasaurus ss = new Sodasaurus();
                menuItems.Add(ss);
                Tyrannotea tt = new Tyrannotea();
                menuItems.Add(tt);
                Water w = new Water();
                menuItems.Add(w);

                // Entrees
                Brontowurst b = new Brontowurst();
                menuItems.Add(b);
                DinoNuggets dn = new DinoNuggets();
                menuItems.Add(dn);
                PrehistoricPBJ pbj = new PrehistoricPBJ();
                menuItems.Add(pbj);
                SteakosaurusBurger sb = new SteakosaurusBurger();
                menuItems.Add(sb);
                TRexKingBurger tkb = new TRexKingBurger();
                menuItems.Add(tkb);
                VelociWrap vw = new VelociWrap();
                menuItems.Add(vw);

                // Sides
                Fryceritops ft = new Fryceritops();
                menuItems.Add(ft);
                MeteorMacAndCheese mmc = new MeteorMacAndCheese();
                menuItems.Add(mmc);
                MezzorellaSticks ms = new MezzorellaSticks();
                menuItems.Add(ms);
                Triceritots trycer = new Triceritots();
                menuItems.Add(trycer);

                return menuItems;
            }
        }

        /// <summary>
        /// List of all available entrees
        /// </summary>
        public List<IMenuItem> AvailableEntrees
        {
            get
            {
                List<IMenuItem> menuItems = new List<IMenuItem>();
                // Entrees
                Brontowurst b = new Brontowurst();
                menuItems.Add(b);
                DinoNuggets dn = new DinoNuggets();
                menuItems.Add(dn);
                PrehistoricPBJ pbj = new PrehistoricPBJ();
                menuItems.Add(pbj);
                SteakosaurusBurger sb = new SteakosaurusBurger();
                menuItems.Add(sb);
                TRexKingBurger tkb = new TRexKingBurger();
                menuItems.Add(tkb);
                VelociWrap vw = new VelociWrap();
                menuItems.Add(vw);
                return menuItems;
            }
        }
        
        /// <summary>
        /// List of all available sides
        /// </summary>
        public List<IMenuItem> AvailableSides
        {
            get
            {
                List<IMenuItem> menuItems = new List<IMenuItem>();
                // Sides
                Fryceritops ft = new Fryceritops();
                menuItems.Add(ft);
                MeteorMacAndCheese mmc = new MeteorMacAndCheese();
                menuItems.Add(mmc);
                MezzorellaSticks ms = new MezzorellaSticks();
                menuItems.Add(ms);
                Triceritots trycer = new Triceritots();
                menuItems.Add(trycer);

                return menuItems;
            }
        }
        
        /// <summary>
        /// List of all available drinks
        /// </summary>
        public List<IMenuItem> AvailableDrinks
        {
            get
            {
                List<IMenuItem> menuItems = new List<IMenuItem>();
                //Drinks
                JurassicJava jj = new JurassicJava();
                menuItems.Add(jj);
                Sodasaurus ss = new Sodasaurus();
                menuItems.Add(ss);
                Tyrannotea tt = new Tyrannotea();
                menuItems.Add(tt);
                Water w = new Water();
                menuItems.Add(w);

                return menuItems;
            }
        }

        /// <summary>
        /// List of all available combos
        /// </summary>
        public List<IMenuItem> AvailableCombos
        {
            get
            {
                List<IMenuItem> combos = new List<IMenuItem>();
                TRexKingBurger burger = new TRexKingBurger();
                CretaceousCombo combo = new CretaceousCombo(burger);
                combos.Add(combo);
                return combos;
                
            }
        }

        /// <summary>
        /// Displays full menu comtents separated by \n
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            // return full list of menu items
            return base.ToString();
        }
    }
}
