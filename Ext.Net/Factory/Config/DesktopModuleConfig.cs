/********
 * This file is part of Ext.NET.
 *     
 * Ext.NET is free software: you can redistribute it and/or modify
 * it under the terms of the GNU AFFERO GENERAL PUBLIC LICENSE as 
 * published by the Free Software Foundation, either version 3 of the 
 * License, or (at your option) any later version.
 * 
 * Ext.NET is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU AFFERO GENERAL PUBLIC LICENSE for more details.
 * 
 * You should have received a copy of the GNU AFFERO GENERAL PUBLIC LICENSE
 * along with Ext.NET.  If not, see <http://www.gnu.org/licenses/>.
 *
 *
 * @version   : 2.1.1 - Ext.NET Community License (AGPLv3 License)
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : GNU AFFERO GENERAL PUBLIC LICENSE (AGPL) 3.0. 
 *              See license.txt and http://www.ext.net/license/.
 *              See AGPL License at http://www.gnu.org/licenses/agpl-3.0.txt
 ********/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    public partial class DesktopModule
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public DesktopModule(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit DesktopModule.Config Conversion to DesktopModule
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DesktopModule(DesktopModule.Config config)
        {
            return new DesktopModule(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : BaseItem.Config 
        { 
			/*  Implicit DesktopModule.Config Conversion to DesktopModule.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator DesktopModule.Builder(DesktopModule.Config config)
			{
				return new DesktopModule.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private string moduleID = "";

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue("")]
			public virtual string ModuleID 
			{ 
				get
				{
					return this.moduleID;
				}
				set
				{
					this.moduleID = value;
				}
			}
        
			private WindowCollection window = null;

			/// <summary>
			/// Standard menu attribute consisting of a reference to a menu object, a menu id or a menu config blob.
			/// </summary>
			public WindowCollection Window
			{
				get
				{
					if (this.window == null)
					{
						this.window = new WindowCollection();
					}
			
					return this.window;
				}
			}
			
			private MenuItem launcher = null;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(null)]
			public virtual MenuItem Launcher 
			{ 
				get
				{
					return this.launcher;
				}
				set
				{
					this.launcher = value;
				}
			}

			private DesktopShortcut shortcut = null;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(null)]
			public virtual DesktopShortcut Shortcut 
			{ 
				get
				{
					return this.shortcut;
				}
				set
				{
					this.shortcut = value;
				}
			}

			private bool autoRun = false;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(false)]
			public virtual bool AutoRun 
			{ 
				get
				{
					return this.autoRun;
				}
				set
				{
					this.autoRun = value;
				}
			}

			private string autoRunHandler = "";

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue("")]
			public virtual string AutoRunHandler 
			{ 
				get
				{
					return this.autoRunHandler;
				}
				set
				{
					this.autoRunHandler = value;
				}
			}

        }
    }
}