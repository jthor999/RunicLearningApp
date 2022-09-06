using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunicLearningApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        
    }

    class TextHolder
    {
        public string InfoText() 
        {
            return "The Runic Learning application is designed to help people" +
                " learn about the ancient alphabet used by Germanic and Scandinavian" +
                " peoples and the deep meaning assocaited with them." +
                " Click a rune to read about its description!";
        }
        
        public  string DescriptionText(int txt)
        {
            string chosen_txt = "runic learning";

            switch (txt) 
            {
                case 0: chosen_txt = ("The Fehu Rune" +
                                    "\n\n Pronounced Fay-Who" +
                                    "\n\nLiterally: Cattle" +
                                    "\n\nEsoteric: Mobile Property, New Beginnings, Wealth" +
                                    "\n\nKey Concepts: Wealth, money, food, sustenance, intial conditions, luck, personal power, circulation of power,  financial strength, prosperity");
                                    

                    break;
                case 1:
                    chosen_txt = ("The Uruz Rune" +
                                    "\n\n Pronounced: Oo – Ruse" +
                                    "\n\nLiterally: Aurochs" +
                                    "\n\nEsoteric:  Endurance, Will Power, Manifestation" +
                                    "\n\nKey Concepts: life force, physical health, courage, organic structure, manifestation, formation, healing, vigor, endurance");

                    break;
                case 2:
                    chosen_txt = ("The Thurisaz Rune" +
                                    "\n\n Pronounced: Thor-is-as" +
                                    "\n\nLiterally: Giants" +
                                    "\n\nEsoteric: Strong one, Resistance, violent power" +
                                    "\n\nKey Concepts: Unconscious forces, sociological forces, Thor, chaos, destruction by natural forces, aggression, conflicts, disputes, lightning, enthusiasm");

                    break;
                case 3:
                    chosen_txt = ("The Ansuz Rune" +
                                    "\n\n Pronounced: Anne – suhz" +
                                    "\n\nLiterally: Odin" +
                                    "\n\nEsoteric: Breath or Ancestral Sovereign God" +
                                    "\n\nKey Concepts: order, Gods, Odin, transmission of intelligence, inspiration, breath,  the Voice of the Universe, spellsong, ancestors,poetry, runes");

                    break;
                case 4:
                    chosen_txt = ("The Raidho Rune" +
                                    "\n\n Pronounced: Ride-ho" +
                                    "\n\nLiterally: To ride or wagon" +
                                    "\n\nEsoteric: Journey" +
                                    "\n\nKey Concepts: the journey of Life, stories, heroism, means of transportation, right action, rituals");

                    break;
                case 5:
                    chosen_txt = ("The Kenaz Rune" +
                                    "\n\n Pronounced: Kay-naz" +
                                    "\n\nLiterally: Torch" +
                                    "\n\nEsoteric: Knowledge" +
                                    "\n\nKey Concepts: Illumination, searching for enlightenment, shedding light on matters, quest for truth, skills, creativity, art, craftsmanship, cunning");

                    break;
                case 6:
                    chosen_txt = ("The Gebo Rune" +
                                    "\n\n Pronounced: Geh-boo" +
                                    "\n\nLiterally: Gift" +
                                    "\n\nEsoteric: Fair Exchange, Sacrifice, Sacred Marriage" +
                                    "\n\nKey Concepts: gifts, giving, taking, trade, sacrifice, process of exchange, balance, compensation, equilibrium, reciprocation, altruism,  generosity, hospitality, honor");

                    break;
                case 7:
                    chosen_txt = ("The Wunjo Rune" +
                                    "\n\n Pronounced: Won-joe" +
                                    "\n\nLiterally: Joy" +
                                    "\n\nEsoteric: Hope, Harmony, Perfection" +
                                    "\n\nKey Concepts: joy, perfection, the art of correct wishing, correct application of the will, well-being, contentment, hope, expectation, relationship, family, bonding, trusted kinsfolk");

                    break;
                case 8:
                    chosen_txt = ("The Hagalaz Rune" +
                                    "\n\n Pronounced: Hag-all-az" +
                                    "\n\nLiterally: Hail or Hailing stone" +
                                    "\n\nEsoteric: Crisis or Radical Change" +
                                    "\n\nKey Concepts: crisis and catastrophe, disruption, radical change, destructive elements of nature, severe weather, the uncontrollable, unavoidable unpleasantness");
                    break;
                case 9:
                    chosen_txt = ("The Nauthiz Rune" +
                                    "\n\n Pronounced: Now-these" +
                                    "\n\nLiterally: Need-fire or Necessity" +
                                    "\n\nEsoteric: Constraint, Friction" +
                                    "\n\nKey Concepts:Need, resistance, constraint, conflict, drama, effort, necessity, urgency, hard work, need-fire, life lessons, creative friction, distress, force of growth");

                    break;
                case 10:
                    chosen_txt = ("The Isa Rune" +
                                    "\n\n Pronounced: Iss-ah" +
                                    "\n\nLiterally: Ice" +
                                    "\n\nEsoteric: Stasis, Stillness" +
                                    "\n\nKey Concepts: Concentrated self, ego-consciousness, self-control, unity of being; or egomania, dullness, blindness, dissipation, immobility, self-centeredness, lack of change, psychopathy.");

                    break;
                case 11:
                    chosen_txt = ("The Jera Rune" +
                                    "\n\n Pronounced: Yehr-ah" +
                                    "\n\nLiterally: Year" +
                                    "\n\nEsoteric: Harvest" +
                                    "\n\nKey Concepts: good harvest, orbits, cycles, progress, biorhythms, right effort,Fertility, creativity and harmony with the land");

                    break;
                case 12:
                    chosen_txt = ("The Eihwaz Rune" +
                                    "\n\n Pronounced: Yew-was" +
                                    "\n\nLiterally: Yew" +
                                    "\n\nEsoteric: Yggdrasil " +
                                    "\n\nKey Concepts: Initiation into the wisdom of the World Tree,Liberation from the fear of death,Development of spiritual endurance");

                    break;
                case 13:
                    chosen_txt = ("The Perthro Rune" +
                                    "\n\n Pronounced: Per-Throw" +
                                    "\n\nLiterally: Luck" +
                                    "\n\nEsoteric: The Norns, Fate, Lot-Cup" +
                                    "\n\nKey Concepts: co-incidence, living with the unknown, the art and magic of guessing, pattern recognition, prophecy,evolutionary force, luck, nothingness, the unborn");

                    break;
                case 14:
                    chosen_txt = ("The Algiz Rune" +
                                    "\n\n Pronounced: Al-jiz" +
                                    "\n\nLiterally: Elk" +
                                    "\n\nEsoteric: Protection, Higher Self" +
                                    "\n\nKey Concepts: divinity, higher self, the state of listening, protective teaching force, the divine plan, Valkyries, Mystical and religious communication with non-human sentients");

                    break;
                case 15:
                    chosen_txt = ("The Sowilo Rune" +
                                    "\n\n Pronounced: So-iölo" +
                                    "\n\nLiterally: Sun" +
                                    "\n\nEsoteric: wholeness, success" +
                                    "\n\nKey Concepts: seat of the soul, revelation, wholeness, sun-wheel, strengthening the hvel/charka, cosmic energies, motivation, life-giving force, action");

                    break;
                case 16:
                    chosen_txt = ("The Tiwaz Rune" +
                                    "\n\n Pronounced: Tea-waz" +
                                    "\n\nLiterally: The God Tyr" +
                                    "\n\nEsoteric: Justice, Sacrifice" +
                                    "\n\nKey Concepts: Rune of the balance and justice ruled from a higher rationality, sovereign order, sacrifice, right decision making, faith, loyalty, sacrifice");

                    break;
                case 17:
                    chosen_txt = ("The Berkano Rune" +
                                    "\n\n Pronounced: Ber-kan-oh" +
                                    "\n\nLiterally: Birch Goddess" +
                                    "\n\nEsoteric: Birth, Sanctuary" +
                                    "\n\nKey Concepts: continued growth and continual rebirth or renewal, secrecy, silence, safety, mature wisdom, dependence, motherhood, healing, gardening, child raising, the womb");

                    break;
                case 18:
                    chosen_txt = ("The Ehwaz Rune" +
                                    "\n\n Pronounced: Eh-was" +
                                    "\n\nLiterally: Horse" +
                                    "\n\nEsoteric: Trust" +
                                    "\n\nKey Concepts: harmonious teamwork and trust, trust between individual entities, cooperation, friendship, loyalty ");

                    break;
                case 19:
                    chosen_txt = ("The Mannaz Rune" +
                                    "\n\n Pronounced: Man-az" +
                                    "\n\nLiterally: Mankind" +
                                    "\n\nEsoteric: Humankind, awareness" +
                                    "\n\nKey Concepts: Rune of the Divine structure of intelligence in the human soul, mind & memory, psychic order of the gods reflected in humankind");

                    break;
                case 20:
                    chosen_txt = ("The Laguz Rune" +
                                    "\n\n Pronounced: Lag-ooz" +
                                    "\n\nLiterally: Water" +
                                    "\n\nEsoteric: Unconscious, Collective Memory" +
                                    "\n\nKey Concepts: Rune of the unconscious context of becoming, emotion, psychic powers, unconscious mental processes, love");

                    break;
                case 21:
                    chosen_txt = ("The Inguz Rune" +
                                    "\n\n Pronounced: Ing-guz" +
                                    "\n\nLiterally: Seed or God Ing" +
                                    "\n\nEsoteric: Process, space" +
                                    "\n\nKey Concepts: internal growth, personal development, the power of suggestion, the inner-child, wholeness, stored energy, subtlety, planned bursts");

                    break;
                case 22:
                    chosen_txt = ("The Dagaz Rune" +
                                    "\n\n Pronounced: Day-gahz" +
                                    "\n\nLiterally: Day" +
                                    "\n\nEsoteric: Awakening" +
                                    "\n\nKey Concepts: hyper-consciousness, paradoxical truth, incommunicable experience, non-dual reality, unity, synthesis");

                    break;
                case 23:
                    chosen_txt = ("The Othala Rune" +
                                    "\n\n Pronounced: Oath-ala" +
                                    "\n\nLiterally: Homeland or Ancestral resting place" +
                                    "\n\nEsoteric: Inheritance, estate, noble" +
                                    "\n\nKey Concepts: anscetral spiritual power, divine inheritance, ancestral spiritual power, inheritance, heaven on earth, the gift of Ing, paradise, utopia");

                    break;
            }


            return  chosen_txt;
        }

    }
}
