using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HerculesTool.Enums
{
    [Flags]
    public enum MobMode
    {
        MD_CANMOVE              = 0x00001,
        MD_LOOTER               = 0x00002,
        MD_AGGRESSIVE           = 0x00004,
        MD_ASSIST               = 0x00008,
        MD_CASTSENSOR_IDLE      = 0x00010,
        MD_BOSS                 = 0x00020,
        MD_PLANT                = 0x00040,
        MD_CANATTACK            = 0x00080,
        MD_DETECTOR             = 0x00100,
        MD_CASTSENSOR_CHASE     = 0x00200,
        MD_CHANGECHASE          = 0x00400,
        MD_ANGRY                = 0x00800,
        MD_CHANGETARGET_MELEE   = 0x01000,
        MD_CHANGETARGET_CHASE   = 0x02000,
        MD_TARGETWEAK           = 0x04000,
        MD_NOKNOCKBACK          = 0x08000,
        MD_RANDOMTARGET         = 0x10000,
    }
}
