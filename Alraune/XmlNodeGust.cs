using System;
using System.Collections.Generic;

namespace Alraune
{
    class XmlNodeGust
    {
        public int Entry { get; set; }
        public XmlAttributeGust[] Attributes { get; set; }
    }

    class XmlAttributeGust
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public string ValueOri { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
    enum AcceptedAtributesXml
    {
        effect_name,
        description,
        Name,
        name,
        name0,
        name1,
        name2,
        name3,
        name4,
        name5,
        name6,
        name7,
        name8,
        name9,
        Text,
        Text2,
        text,
        text_0,
        text_1,
        text_2,
        text_3,
        text_4,
        text1_1,
        text1_2,
        text1_3,
        text2_1,
        text2_2,
        text2_3,
        text3_1,
        text3_2,
        text3_3,
        text4_1,
        text4_2,
        text4_3,
        title,
        title1,
        title2,
        title3,
        title4,
        Title1,
        Title2,
        Title3,
        ItemName,
        itemName,
        MiniEvent1,
        MiniEvent2,
        MiniEvent3,
        change_state_0,
        change_state_1,
        change_skill_title_0,
        change_skill_title_1,
        change_skill_desc_0,
        change_skill_desc_1,
        mess01,
        mess02,
        mess03,
        mess04,
        mess0,
        mess0_0,
        mess0_1,
        mess1_0,
        note0,
        note1,
        explain,
        TypeName,
        ShopName,
        skill_name,
        skill_desc,
        LineHelp,
        FlavorText,
        message,
        Owner
    }
}
