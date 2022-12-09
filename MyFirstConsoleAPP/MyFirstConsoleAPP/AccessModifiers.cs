﻿

namespace MyFirstConsoleAPP
{
    class AccessModifiers
    {
        private string privateField = "Public Information";
        protected string protectField = "Protected Information";
        internal string internalField = "Internal Information";
        protected internal string protectedInternalField = "Protect Internal Information";
        public string publicField = "Public Information";

        private string PrivateMethod()
        {
            return privateField;
        }
        protected string ProtectedMethod()
        {
            return protectField;
        }
        internal string InternalMethod()
        {
            return internalField;
        }
        protected internal string ProtectedInternalMethod()
        {
            return protectedInternalField;
        }
        public string PublicMethod()
        {
            return publicField;
        }

        static void Main()
        {
            var obj = new AccessModifiers();
            obj.PrivateMethod();
            obj.ProtectedMethod();
            obj.InternalMethod();
            obj.ProtectedInternalMethod();
            obj.PublicMethod();
        }

    }

    class TestAccessSpecifiers: AccessModifiers
    {
        static void Main()
        {
            var obj = new TestAccessSpecifiers();
            obj.PrivateMethod();
            obj.ProtectedMethod();
            obj.InternalMethod();
            obj.ProtectedInternalMethod();
            obj.PublicMethod();
        }
    }

    class OtherAccess
    {
        static void Main()
        {
            var obj = new AccessModifiers();
            obj.PrivateMethod();
            obj.ProtectedMethod();
            obj.InternalMethod();
            obj.ProtectedInternalMethod();
            obj.PublicMethod();
        }
    }

}
