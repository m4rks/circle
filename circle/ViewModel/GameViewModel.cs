using circle.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Shapes;

namespace circle.ViewModel
{
    public class GameViewModel
    {
        #region FIELDS
        public ObservableCollection<Figure> ButtonList { get; private set; }
        #endregion
        #region Members
        private OrderGame _game;
        private Figure _myFigure;
        #endregion

        #region Constructor
        public GameViewModel()
        {
            Tile tile1 = new Tile() { OrderNo = 1, Picture = "asdf", X = 10, Y = 20 };
            Tile tile2 = new Tile() { OrderNo = 2, Picture = "asdf", X = 10, Y = 40 };
            Tile tile3 = new Tile() { OrderNo = 3, Picture = "asdf", X = 10, Y = 60 };
            Tile tile4 = new Tile() { OrderNo = 4, Picture = "asdf", X = 10, Y = 80 };
            List<Tile> _listTiles = new List<Tile>();
            _listTiles.Add(tile1);
            _listTiles.Add(tile2);
            _listTiles.Add(tile3);
            _listTiles.Add(tile4);
            _game = new OrderGame() { Id = 1, Tiles = _listTiles };

            ButtonList = new ObservableCollection<Figure>();
            List<string> listImage = new List<string> { "../Resources/ImageVWpng.png", "../Resources/ImageAmiga.png" };
            Random random = new Random();
            _myFigure = new Figure
            {
                Id = ButtonList.Count + 1,
                StepX = random.Next(-20, 20),
                StepY = random.Next(-20, 20),
                TypeFigure = new Rectangle(),
                X = random.Next(0, 200),
                Y = random.Next(0, 200),
                Image = listImage[random.Next(0, 2)],
            };
            AddButton(_myFigure);
            AddButton(_myFigure);
            AddButton(_myFigure);
            AddButton(_myFigure);

        }

        private void AddButton(Figure myFigure)
        {
            ButtonList.Add(myFigure); ;
        }

        #endregion

        #region Properties


        #endregion
    }
}
