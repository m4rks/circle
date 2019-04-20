using System.Collections.Generic;

namespace circle.Model
{

    public class Tile : Point
    {
        public int OrderNo { get; set; }
        public string Picture { get; set; }
    }

    public class OrderGame : Base
    {
        public int Id { get; set; }
        public List<Tile> Tiles { get; set; }

    }
}
