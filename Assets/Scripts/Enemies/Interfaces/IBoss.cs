/*
 * (c) 2022 Tripledot Studios, all rights reserved.
 * Tripledot Studios owns the copyright to this file and all of it's content
 * The file may not be reproduced in any form without permission.
 * 
 * Created and maintained by:
 * Kazimierz Luska (kazimierz.luska@tripledotstudios.com
 */

using Tripledot.Adventure.Enums;

namespace Tripledot.Adventure.Enemies.Interfaces
{
    public interface IBoss : IEnemy
    {
        BossType BossType { get; }
    }    
}

