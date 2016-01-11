using Otter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VideoGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Game("Sakurai Plz");
          
            var scene = new Scene();
            var testEntity = new Entity(350, 240);
            // comment
           
            testEntity.AddGraphic(Image.CreateCircle( 100,Color.Red));
            
          
            
           
            scene.Add(testEntity);

           
            game.Start(scene);
        }

        class SoundScene : Scene
        {
            public Sound SoundOne = new Sound("sound1.wav");
        }

        public Music Music = new Music("KIRBYZ.mp3");

        if (Input.KeyPressed(Key.Num1))
            {
                SoundOne.Play();
            }

    }

}
