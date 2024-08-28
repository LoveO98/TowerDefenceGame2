using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using SharpDX.MediaFoundation;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowerDefenceGame.Visuals;

namespace TowerDefenceGame.Managers
{
    public class ParticleManager
    {
        //Two lists to store the particles in
        static List<Particle> particlesBottomUp = new List<Particle>();
        static List<Particle> particlesTopDown = new List<Particle>();

        static List<StationaryParticle> statParticlesBottomUp = new List<StationaryParticle>();
        static List<StationaryParticle> statParticlesTopDown = new List<StationaryParticle>();

        public ParticleManager()
        {

        }

        public void Update(GameTime gameTime)
        {
            //Update both lists, since I delete the particles in the update step I can't use "foreach", but this workaround makes it work.
            if (particlesBottomUp.Count > 0)
            {
                for (int i = particlesBottomUp.Count - 1; i > -1; i--)
                {
                    particlesBottomUp[i].Update(gameTime);
                }
            }

            if (particlesTopDown.Count > 0)
            {
                for (int i = 0; i < particlesTopDown.Count; i++)
                {
                    particlesTopDown[i].Update(gameTime);
                }
            }

            if (statParticlesBottomUp.Count > 0)
            {
                for (int i = statParticlesBottomUp.Count - 1; i > -1; i--)
                {
                    statParticlesBottomUp[i].Update(gameTime);
                }
            }

            if (statParticlesTopDown.Count > 0)
            {
                for (int i = 0; i < statParticlesTopDown.Count; i++)
                {
                    statParticlesTopDown[i].Update(gameTime);
                }
            }

        }

        public void Draw(SpriteBatch sb)
        {
            //Draw both lists, one is drawn with the most recently added particle on top and one is drawn with the oldest particle on top. This is so I can for example create smoke rising without having the newly created smoke particles on top, which wouldn't make sense.
            if (particlesBottomUp.Count > 0)
            {
                for (int i = particlesBottomUp.Count - 1; i > -1; i--)
                {
                    particlesBottomUp[i].Draw(sb);
                }
            }

            if (particlesTopDown.Count > 0)
            {
                for (int i = 0; i < particlesTopDown.Count; i++)
                {
                    particlesTopDown[i].Draw(sb);
                }
            }

            if (statParticlesBottomUp.Count > 0)
            {
                for (int i = statParticlesBottomUp.Count - 1; i > -1; i--)
                {
                    statParticlesBottomUp[i].Draw(sb);
                }
            }

            if (statParticlesTopDown.Count > 0)
            {
                for (int i = 0; i < statParticlesTopDown.Count; i++)
                {
                    statParticlesTopDown[i].Draw(sb);
                }
            }
        }
        

        //Methods for creating particles, takes A LOT of variables, though they should all be self explanatory
        //I seperated the top down and bottom up particles into two different methods to make it easier for myself. Easier to just write "CreateParticleBottomUp" when I need a bottom->up particle instead of including a bool in the method variables or something
        static public void CreateParticleBottomUp(Texture2D tex, Vector2 startPos, Vector2 direction, float spread, float speed, float speedVar, float drag, float lifetime, float sizeTime1, float sizeTime2, float startSize, float midSize, float endSize, float startRot, float rotationSpeed, Color startColor, Color midColor, Color endColor)
        {
            Vector2 finalDirection = RandomDirection(direction, spread);
            finalDirection.Normalize();
            float finalSpeed = GetRandomFloatVar(speed, speedVar);
            if (startRot == 12345) startRot = MathF.Atan2(1, 0) - MathF.Atan2(finalDirection.X, finalDirection.Y); //Just don't ask about this

            particlesBottomUp.Add(new Particle(tex, startPos, finalDirection, finalSpeed, drag, lifetime, sizeTime1, sizeTime2, startSize, midSize, endSize, startRot, rotationSpeed, startColor, midColor, endColor));
        }

        static public void CreateParticleTopDown(Texture2D tex, Vector2 startPos, Vector2 direction, float spread, float speed, float speedVar, float drag, float lifetime, float sizeTime1, float sizeTime2, float startSize, float midSize, float endSize, float startRot, float rotationSpeed,  Color startColor, Color midColor, Color endColor)
        {
            Vector2 finalDirection = RandomDirection(direction, spread);
            finalDirection.Normalize();
            float finalSpeed = GetRandomFloatVar(speed, speedVar);
            if (startRot == 12345) startRot = MathF.Atan2(1, 0) - MathF.Atan2(finalDirection.X, finalDirection.Y);
            
            particlesTopDown.Add(new Particle(tex, startPos, finalDirection, finalSpeed, drag, lifetime, sizeTime1, sizeTime2, startSize, midSize, endSize, startRot, rotationSpeed, startColor, midColor, endColor));
        }

        static public void CreateStatParticleBottomUp(Texture2D tex, Vector2 pos, float lifeTime, float lifeTimeVar, float startSize, float endSize, float endSizeVar, float rot, float rotSpeed, Color startColor, Color endColor)
        {
            lifeTime = GetRandomFloatVar(lifeTime, lifeTimeVar);
            endSize = GetRandomFloatVar(endSize, endSizeVar);
            statParticlesBottomUp.Add(new StationaryParticle(tex, pos, lifeTime, startSize, endSize, rot, rotSpeed, startColor, endColor));
        }

        static public void CreateStatParticleTopDown(Texture2D tex, Vector2 pos, float lifeTime, float lifeTimeVar, float startSize, float endSize, float endSizeVar, float rot, float rotSpeed, Color startColor, Color endColor)
        {
            lifeTime = GetRandomFloatVar(lifeTime, lifeTimeVar);
            endSize = GetRandomFloatVar(endSize, endSizeVar);
            statParticlesTopDown.Add(new StationaryParticle(tex, pos, lifeTime, startSize, endSize, rot, rotSpeed, startColor, endColor));
        }

        //These methods are just to house some math for the particle creation
        static private float GetRandomFloatVar(float input, float inputVar)
        {
            if (inputVar == 0) return input;
            float randomFloat = Util.GetRandom((int)(-inputVar * 100), (int)((inputVar + 1) * 100));
            float returnFloat = input + (randomFloat / 100);
            return returnFloat;
        }

        static private Vector2 RandomDirection(Vector2 direction, float spread)
        {
            float randomXLower = (direction.X * 100) - (MathF.Abs(spread) * 50);
            float randomXHigher = (direction.X * 100) + (MathF.Abs(spread) * 50);
            float randomYLower = (direction.Y * 100) - (MathF.Abs(spread) * 50);
            float randomYHigher = (direction.Y * 100) + (MathF.Abs(spread) * 50);
            float directionX = Util.GetRandom((int)randomXLower, (int)randomXHigher);
            float directionY = Util.GetRandom((int)randomYLower, (int)randomYHigher);
            Vector2 randomizedDirection = new Vector2(directionX / 100, directionY / 100);
            return randomizedDirection;
        }

        static public void DeleteMovingParticle(Particle particle)
        {
            particlesBottomUp.Remove(particle);
            particlesTopDown.Remove(particle);
        }

        static public void DeleteStationaryParticle(StationaryParticle particle)
        {
            statParticlesBottomUp.Remove(particle);
            statParticlesTopDown.Remove(particle);
        }
    }

    public static class Util
    {
        private static Random rnd = new Random();
        public static float GetRandom(int a, int b)
        {
            return rnd.Next(a, b);
        }
    }
}
