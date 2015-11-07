namespace Lab_3
{
    using System;
   
    class AttackingMonsterException: ApplicationException
    {
        public AttackingMonsterException():base()
        {
        }

        public AttackingMonsterException(string message):base(message)
        {
        }
    }
}
