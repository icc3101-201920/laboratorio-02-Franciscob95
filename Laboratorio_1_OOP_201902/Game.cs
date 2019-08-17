using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_1_OOP_201902
{
    public class Game
    {
        //Atributos
        private Player[] players;
        private Player activePlayer;
        private Board boardGame;
        private bool endGame;

        //Constructor
        public Game()
        {
            Random random = new Random();
            players = new Player[2] { new Player(), new Player() };
            ActivePlayer = players[random.Next(0, 2)];
            boardGame = new Board();
            EndGame = false;

        }
        //Propiedades
        public Player[] Players
        {
            get
            {
                return this.players;
            }
        }
        public Player ActivePlayer
        {
            get
            {
                return this.activePlayer;
            }
            set
            {
                activePlayer = value;
            }
        }
        public Board BoardGame
        {
            get
            {
                return this.boardGame;
            }
        }
        public bool EndGame
        {
            get
            {
                return this.endGame;
            }
            set
            {
                endGame = value;
            }
        }

        //Metodos
        public bool CheckIfEndGame()
        {
            if (EndGame == true)
            {
                Console.WriteLine("El juego ha terminado");
                return true;
            } 
            else 
            {
                return false;
            }
        }
        public bool GetWinner()
        {
            for (var i =0; i <= players.Length;i++)
            {
                if (players[i].LifePoints == 0)
                {
                    return false;
                }
                else
                {
                    Console.WriteLine(players[i]);
                    return true;
                }
            }
            return false;
        }
        public void Play()
        {
            throw new NotImplementedException();
        }
    }
}
