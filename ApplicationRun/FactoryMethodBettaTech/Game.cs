using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodBettaTech
{
    public class Game
    {
        private IEnemyFactory enemyFactory;
        public Game(IEnemyFactory _enemyFactory)
        {
            enemyFactory = _enemyFactory;
        }

        public void gameLogic()
        {
            var enemy = this.enemyFactory.CreateEnemy();
        }
    }
}
