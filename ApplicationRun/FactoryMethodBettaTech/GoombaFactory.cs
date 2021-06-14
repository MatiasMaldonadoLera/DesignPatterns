using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodBettaTech
{
    public class GoombaFactory : IEnemyFactory
    {
        public Entity CreateEnemy()
        {
            //puedo crear de acuerdo a cualquier logica
            return new Goomba();
        }
    }
}
