using System.ComponentModel.Design.Serialization;

namespace ThePianist
{
    internal class Program
    {

        public class Piece
        {
            public Piece(string name, string composer, string key)
            {
               Name = name;
                Composer = composer;
                Key = key;
            }
            public string Name { get; set; }
            public string Composer { get; set; }
            public string Key { get; set; }
        }
        static void Main(string[] args)
        {
            List<Piece> piecesList = new List<Piece>();
            int numberOfPiece = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPiece; i++)
            {
                string[] data = Console.ReadLine().Split("|");
                string pieceName = data[0];
                string composerName = data[1];
                string key = data[2];

                
              
                piecesList.Add(new Piece(pieceName,composerName,key));

            }

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Stop")
            {
                string[] pieceData = input.Split("|");
                string command = pieceData[0];
                string piece = pieceData[1];

                Piece existing = piecesList.FirstOrDefault(p => p.Name == piece);

                switch (command)
                {
                    case "Add":
                string composer = pieceData[2];
                string key = pieceData[3];
                       if (existing != null)
                        {
                            Console.WriteLine($"{piece} is already in the collection!");
                        }
                        else
                        {
                            piecesList.Add(new Piece(piece,composer,key));
                            Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                        } 
                            
                            break;

                    case "Remove":
                        if (existing != null)
                        {
                            piecesList.Remove(existing);
                            Console.WriteLine($"Successfully removed {piece}!");
                        }
                        else
                        {
                            Console.WriteLine($"Invalid operation! {piece} does not exist in the collection."); 
                            
                        }

                            break;

                    case "ChangeKey":
                        string newKey = pieceData[2];
                        if (existing != null)
                        {
                            existing.Key = newKey;

                            Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                        }
                        else
                            Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                            break;
                }
            }

            foreach (Piece piece in piecesList)
            {
                Console.WriteLine($"{piece.Name} -> Composer: {piece.Composer}, Key: {piece.Key}");
            } 
        }
    }
}
