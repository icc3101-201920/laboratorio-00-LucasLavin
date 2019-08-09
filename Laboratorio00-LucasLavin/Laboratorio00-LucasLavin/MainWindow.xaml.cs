using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Laboratorio00_LucasLavin
namespace Card
{
    public class CombatCard
    {
        private string name;
        private int attackPoints;
        private Boolean hero;
        private string type;
        private string effect;

        public CombatCard(string name, int attackPoints, Boolean hero, string type, string effect)
        {
            this.name = name;
            this.attackPoints = attackPoints;
            this.hero = hero;
            this.type = type;
            this.effect = effect;

        }

        public string Name
        {
            get { return name; }
            set { name = value; }
            
        }
        public int AttackPoints
        {
            get { return attackPoints; }
            set { attackPoints = int; }

        }
        public Boolean Hero
        {
            get { return hero; }
            set { hero = Boolean; }
        }
        public string Type
        {
            get { return type; }
            set { type = string; }

        }
        public string Effect
        {
            get { return effect; }
            set { effect = string; }
        }
    }
    public class SpecialCard
    {
        private string name;
        private string type;
        private string buffType;
        private string effect;

        public SpecialCard(string name, string type, string buffType, string effect)
        {
            this.name = name;
            this.type = type;
            this.buffType = buffType;
            this.effect = effect;
        }
        public string Name
        {
            get { return name; }
            set { name = int; }

        }
        public string Type
        {
            get { return type; }
            set { type = string; }

        }
        public string BuffType
        {
            get { return buffType; }
            set { buffType = string; }
        }
        public string Effect
        {
            get { return effect; }
            set { effect = string; }
        }
    }
    public class Player
    {
        private int lifePoints;
        private int attackPoints;
        private Deck deck;
        private Hand hand;
        private Board board;
        private SpecialCard captain;

        public Player(int lifePoints, int attackPoints, Deck deck, Hand hand, Board board,SpecialCard captain)
        {
            this.lifePoints = lifePoints;
            this.attackPoints = attackPoints;
            this.deck = deck;
            this.hand = hand;
            this.board = board;
            this.captain = captain;

        }

        public int LifePoints
        {
            get { return lifePoints; }
            set { lifePoints = int; }

        }
        public int AttackPoints
        {
            get { return attackPoints; }
            set { attackPoints = int; }

        }
        public Deck Deck
        {
            get { return deck; }
            set { deck = Deck; }
        }
        public Hand Hand
        {
            get { return hand; }
            set { hand = Hand; }

        }
        public Board Board
        {
            get { return board; }
            set { board = Board; }
        }
        public SpecialCard Captain
        {
            get { return captain; }
            set { captain = SpecialCard}
        }
        public void DrawCard() { ; }
        public void PlayCard(int cardId) { ; }
        public void ChangeCard(int cardId) { ; }
        public void FirstHand() { ; }
        public void ChooseCaptainCardlayCard(SpecialCard captainCard) { ; }
    }
    public class Board
    {
        private List<CombatCard> meleeCards = new List<CombatCard>();
        private List<CombatCard> rangeCards = new List<CombatCard>();
        private List<CombatCard> longRangeCards = new List<CombatCard>();
        private List<SpecialCard> specialMeleeCards = new List<SpecialCard>();
        private List<SpecialCard> specialRangeCards = new List<SpecialCard>();
        private List<SpecialCard> specialLongRangeCards = new List<SpecialCard>();
        private List<SpecialCard> captainCards = new List<SpecialCard>();
        private List<SpecialCard> weatherCards = new List<SpecialCard>();

        public Board(CombatCard meleeCards, CombatCard rangeCards, CombatCard longRangeCards, SpecialCard specialMeleeCards, SpecialCard specialRangeCards, SpecialCard specialLongRangeCards, SpecialCard captainCards, SpecialCard weatherCards)
        {
            this.meleeCards = meleeCards;
            this.rangeCards = rangeCards;
            this.longRangeCards = longRangeCards;
            this.specialMeleeCards = specialMeleeCards;
            this.specialRangeCards = specialRangeCards;
            this.specialLongRangeCards = specialLongRangeCards;
            this.captainCards = captainCards;
            this.weatherCards = weatherCards;
        }
        public CombatCard MeleeCards
        {
            get { return meleeCards; }
        }
        public CombatCard RangeCards
        {
            get { return rangeCards; }
        }
        public CombatCard LongRangeCards
        {
            get { return longRangeCards; }
        }
        public SpecialCard SpecialMeleeCards
        {
            get { return specialMeleeCards; }
        }
        public SpecialCard SpecialRangeCards
        {
            get { return specialRangeCards; }
        }
        public SpecialCard SpecialLongRangeCards
        {
            get { return specialLongRangeCards; }
        }
        public SpecialCard CaptainCards
        {
            get { return captainCards; }
        }
        public SpecialCard WeatherCards
        {
            get { return weatherCards; }
        }
    }
    public class Game
    {

    }
    public class Deck
    {

    }
    public class Hand
    {

    }

}
