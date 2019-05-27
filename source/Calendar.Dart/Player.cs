using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using Calendar.Dart.Annotations;

namespace Calendar.Dart
{
    [Serializable]
    class Player : INotifyPropertyChanged
    {
        public static Color[] Colors { get; } =
        {
            Color.OrangeRed,
            Color.CornflowerBlue,
            Color.LimeGreen,
            Color.DarkKhaki,
            Color.Orchid,
            Color.Coral,
            Color.DarkTurquoise,
            Color.DarkSlateBlue
        };

        /// <summary>
        /// Initialisiert einen neue Instanz der <see cref="Player"/>-Klasse.
        /// </summary>
        public Player()
        {
            Jokers = Enum.GetValues(typeof(Joker)).Cast<Joker>().Where(j => j != Joker.None).ToList();
        }

        public string Name { get; set; }
        public Color Color { get; set; }
        public List<Joker> Jokers { get; }

        public Joker Joker { get; set;} = Joker.None;
        public int Score { get; set; }
        public int Points { get; set; }

        private bool _active;
        public bool Active
        {
            get => _active;
            set
            {
                if (value == _active) return;
                _active = value;
                OnPropertyChanged();
            }
        }

        public DateTime Guess { get; set; }

        public bool HasGuessed
        {
            get
            {
                if (!Active || Joker==Joker.Dice) return true;
                return Guess != DateTime.MinValue;
            }
        }

        public void InitRound()
        {
            Active = true;
            Guess = DateTime.MinValue;
            Joker = Joker.None;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void RollDice(DateTime min, DateTime max)
        {
            var random = new Random();

            var days = (int)(max - min).TotalDays + 1;
            var offset = random.Next(days);
            Guess = min.AddDays(offset);
        }
    }

    enum Joker
    {
        None,
        Double,
        Triple,
        Lucky,
        NoGo,
        Oracle,
        Dice,
    }

    internal static class JokerExtension
    {
        public static string GetString(this Joker joker)
        {
            return Properties.Jokers.ResourceManager.GetString(joker.ToString());
        }
    }
}
