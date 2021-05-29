using System;
using System.Collections.Generic;
using System.Text;

namespace MyClass {
   abstract class Item {
        protected long invNumber;
        protected bool taken;

        public Item(long invNumber, bool taken) {
            this.invNumber = invNumber;
            this.taken = taken;
        }

        public Item() {
            taken = false;
        }

        public bool isAvailable() {
            return !taken;
        }

        public long GetInvNumber() {
            return invNumber;
        }

        private void Take() {
            taken = true;
        }

        abstract public void Return();

        public virtual void Show() {
            Console.WriteLine("Состояние единицы хранения:" +
                $"\n Инвентарный номер: {invNumber}\n Наличие: {!taken}");
        }

        public void TakeItem() {
            if (isAvailable()) {
                Take();
            }
        }

    }
}
