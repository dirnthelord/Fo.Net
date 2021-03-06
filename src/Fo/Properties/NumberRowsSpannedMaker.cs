namespace Fonet.Fo.Properties
{
    internal class NumberRowsSpannedMaker : NumberProperty.Maker
    {
        new public static PropertyMaker Maker(string propName)
        {
            return new NumberRowsSpannedMaker(propName);
        }

        protected NumberRowsSpannedMaker(string name) : base(name) { }


        public override bool IsInherited()
        {
            return false;
        }

        private Property m_defaultProp = null;

        public override Property Make(PropertyList propertyList)
        {
            if (m_defaultProp == null)
            {
                m_defaultProp = Make(propertyList, "1", propertyList.getParentFObj());
            }
            return m_defaultProp;

        }

    }
}