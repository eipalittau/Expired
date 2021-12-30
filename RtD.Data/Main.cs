using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RtD.Data {
    public sealed class Main {
        public Main() { }

        public void LoadData(string aPathName, Enumerations.LanguageEnum aLanguage) {
            var lEnemyClasses = new Json.EnemyClassesLoader(this);

            lEnemyClasses.LoadData(aPathName);

        }
    }
}