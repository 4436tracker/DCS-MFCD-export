using System;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Windows.Forms;

namespace DCS显示器设置
{
    internal class Aircraft
    {
        private string path;
        private ListBox listBox;
        private string luaImport = "\ndofile(LockOn_Options.common_script_path..\"ViewportHandling.lua\")\n" ;

        public Aircraft(string path, ListBox listBox)
        {
            this.path = path;
            this.listBox = listBox;
        }

        // append text
        private bool patchFile(string luaPath, string context)
        {
            try
            {
                string luaCode = File.ReadAllText(luaPath);
                if (luaCode.Contains(context))
                {
                    listBox.Items.Add("[*] " + luaPath + " has been patched!");
                    return true;
                }
                else
                {
                    File.WriteAllText(luaPath + ".cfgbak", luaCode);
                    File.WriteAllText(luaPath, luaCode + context);
                    listBox.Items.Add("[+] patch " + luaPath + " success!");
                    return true;
                }
            }
            catch
            {
                listBox.Items.Add("[-] patch " + luaPath + " failed!");
                return false;
            }
        }

        // replace text
        private bool patchFile(string luaPath, string oldContext, string newContext)
        {
            try
            {
                string luaCode = File.ReadAllText(luaPath);
                if (luaCode.Contains(newContext))
                {
                    listBox.Items.Add("[*] " + luaPath + " has been patched!");
                    return true;
                }
                else
                {
                    File.WriteAllText(luaPath + ".cfgbak", luaCode);
                    File.WriteAllText(luaPath, luaCode.Replace(oldContext, newContext));
                    listBox.Items.Add("[+] patch " + luaPath + " success!");
                    return true;
                }
            }
            catch
            {
                listBox.Items.Add("[-] patch " + luaPath + " failed!");
                return false;
            }
        }
        
        private bool recoveryFile(string luaPath)
        {
            try
            {
                if (System.IO.File.Exists(luaPath + ".cfgbak"))
                {
                    System.IO.File.Delete(luaPath);
                    System.IO.File.Move(luaPath + ".cfgbak", luaPath);
                    listBox.Items.Add("[+] recovery " + luaPath + " success!");
                }
                else
                {
                    listBox.Items.Add("[+] " + luaPath + " recovered!");
                }
                return true;
            }catch
            {
                listBox.Items.Add("[-] recovery" + luaPath + " failed!");
                return false;
            }
        }

        public bool setA10C()
        {
            string aircraftScriptPath = path + "A-10C\\Cockpit\\Scripts\\";
            listBox.Items.Add("[*] patching A10C");
            patchFile(aircraftScriptPath + "AN_ALR69V\\indicator\\AN_ALR69V_init.lua", luaImport + "try_find_assigned_viewport(\"A_10C_2_RWR_SCREEN\", \"RWR_SCREEN\")");
            patchFile(aircraftScriptPath + "CDU\\indicator\\CDU_init.lua", luaImport + "try_find_assigned_viewport(\"A_10C_2_CDU_SCREEN\", \"CDU_SCREEN\")");
            patchFile(aircraftScriptPath + "DigitalClock\\Indicator\\DIGIT_CLK_init.lua", luaImport + "try_find_assigned_viewport(\"A_10C_2_DIGIT_CLOCK\", \"DIGIT_CLOCK\")");
            patchFile(aircraftScriptPath + "HUD\\Indicator\\HUD_init.lua", luaImport + "try_find_assigned_viewport(\"A_10C_2_HUD\", \"HUD\")");
            patchFile(aircraftScriptPath + "MFCD\\indicator\\MFCD_left_init.lua", luaImport + "try_find_assigned_viewport(\"A_10C_2_LEFT_MFCD\", \"LEFT_MFCD\")");
            patchFile(aircraftScriptPath + "MFCD\\indicator\\MFCD_right_init.lua", luaImport + "try_find_assigned_viewport(\"A_10C_2_RIGHT_MFCD\", \"RIGHT_MFCD\")");
            return true;
        }

        public bool setA10C2()
        {
            string aircraftScriptPath = path + "A-10C_2\\Cockpit\\Scripts\\";
            listBox.Items.Add("[*] patching A10C2");
            patchFile(aircraftScriptPath + "AN_ALR69V\\indicator\\AN_ALR69V_init.lua", luaImport + "try_find_assigned_viewport(\"A_10C_RWR_SCREEN\", \"RWR_SCREEN\")");
            patchFile(aircraftScriptPath + "CDU\\indicator\\CDU_init.lua", luaImport + "try_find_assigned_viewport(\"A_10C_CDU_SCREEN\", \"CDU_SCREEN\")");
            patchFile(aircraftScriptPath + "DigitalClock\\Indicator\\DIGIT_CLK_init.lua", luaImport + "try_find_assigned_viewport(\"A_10C_DIGIT_CLOCK\", \"DIGIT_CLOCK\")");
            patchFile(aircraftScriptPath + "HUD\\Indicator\\HUD_init.lua", luaImport + "try_find_assigned_viewport(\"A_10C_HUD\", \"HUD\")");
            patchFile(aircraftScriptPath + "MFCD\\indicator\\MFCD_left_init.lua", luaImport + "try_find_assigned_viewport(\"A_10C_LEFT_MFCD\", \"LEFT_MFCD\")");
            patchFile(aircraftScriptPath + "MFCD\\indicator\\MFCD_right_init.lua", luaImport + "try_find_assigned_viewport(\"A_10C_RIGHT_MFCD\", \"RIGHT_MFCD\")");
            return true;
        }

        public bool setAH64D()
        {
            string aircraftScriptPath = path + "AH-64D\\Cockpit\\Scripts\\";
            string oldTEDAC = "try_find_assigned_viewport(\"TEDAC\")";
            string newTEDAC = "!--try_find_assigned_viewport(\"TEDAC\")";
            listBox.Items.Add("[*] patching AH64D");
            patchFile(aircraftScriptPath + "Displays\\EUFD\\EUFD_plt_init.lua", luaImport + "try_find_assigned_viewport(\"AH_64D_EUFD\")");
            patchFile(aircraftScriptPath + "Displays\\MFD\\indicator\\MFD_cpg_left_init.lua", luaImport + "try_find_assigned_viewport(\"AH_64D_CPG_LEFT_MFD\", \"LEFT_MFCD\")");
            patchFile(aircraftScriptPath + "Displays\\MFD\\indicator\\MFD_cpg_right_init.lua", luaImport + "try_find_assigned_viewport(\"AH_64D_CPG_RIGHT_MFD\", \"RIGHT_MFCD\")");
            patchFile(aircraftScriptPath + "Displays\\MFD\\indicator\\MFD_plt_left_init.lua", luaImport + "try_find_assigned_viewport(\"AH_64D_PLT_LEFT_MFD\", \"LEFT_MFCD\") ");
            patchFile(aircraftScriptPath + "Displays\\MFD\\indicator\\MFD_plt_right_init.lua", luaImport + "try_find_assigned_viewport(\"AH_64D_PLT_RIGHT_MFD\", \"RIGHT_MFCD\") ");
            patchFile(aircraftScriptPath + "Displays\\TEDAC\\TEDAC_init.lua", luaImport + "try_find_assigned_viewport(\"AH_64D_TEDAC\", \"TEDAC\")");
            patchFile(aircraftScriptPath + "Displays\\TEDAC\\LCD\\TEDAC_LCD_init.lua", oldTEDAC, newTEDAC);
            return true;
        }

        public bool setAV8B()
        {
            string aircraftScriptPath = path + "AV8BNA\\Cockpit\\MPCD\\indicator\\MPCD_init.lua";
            string oldContext = "if monitorpos == 'R' then\r\n\ttry_find_assigned_viewport(\"RIGHT_MFCD\")\r\nelse \r\n\ttry_find_assigned_viewport(\"LEFT_MFCD\")\r\nend";
            string newContext = "if monitorpos == 'R' then\r\n\ttry_find_assigned_viewport(\"AV8BNA_RIGHT_MFCD\", \"RIGHT_MFCD\")\r\nelse \r\n\t" + 
                "try_find_assigned_viewport(\"AV8BNA_LEFT_MFCD\", \"LEFT_MFCD\")\r\nend";
            listBox.Items.Add("[*] patching AV8B");
            return patchFile(aircraftScriptPath, oldContext, newContext);
        }
        
        public bool setF16C()
        {
            string aircraftScriptPath = path + "F-16C\\Cockpit\\Scripts\\";
            listBox.Items.Add("[*] patching F16C");
            patchFile(aircraftScriptPath + "Displays\\DED\\indicator\\DED_init.lua", luaImport + "try_find_assigned_viewport(\"F_16C_DED\", \"DED\")");
            patchFile(aircraftScriptPath + "Displays\\EHSI\\indicator\\LCD\\EHSI_LCD.lua", luaImport + "try_find_assigned_viewport(\"F_16C_EHSI\", \"EHSI\")");
            patchFile(aircraftScriptPath + "Displays\\MFD\\indicator\\LCD\\MFD_LCD_Left.lua", luaImport + "try_find_assigned_viewport(\"F_16C_LEFT_MFCD\")");
            patchFile(aircraftScriptPath + "Displays\\MFD\\indicator\\LCD\\MFD_LCD_Right.lua", luaImport + "try_find_assigned_viewport(\"F_16C_RIGHT_MFCD\")");
            patchFile(aircraftScriptPath + "EWS\\RWR\\indicator\\RWR_ALR56_init.lua", luaImport + "try_find_assigned_viewport(\"F_16C_RWR\", \"RWR\")");
            return true;
        }
        
        public bool setFA18C()
        {
            string aircraftScriptPath = path + "FA-18C\\Cockpit\\Scripts\\";
            string oldCenterMFCD = "try_find_assigned_viewport(\"CENTER_MFCD\")";
            string newCenterMFCD = "try_find_assigned_viewport(\"FA_18C_CENTER_MFCD\", \"CENTER_MFCD\")";
            string oldLeftMFCD = "try_find_assigned_viewport(\"LEFT_MFCD\")";
            string newLeftMFCD = "try_find_assigned_viewport(\"FA_18C_LEFT_MFCD\", \"LEFT_MFCD\")";
            string oldRightMFCD = "try_find_assigned_viewport(\"RIGHT_MFCD\")";
            string newRightMFCD = "try_find_assigned_viewport(\"FA_18C_RIGHT_MFCD\", \"RIGHT_MFCD\")";
            listBox.Items.Add("[*] patching FA18C");
            patchFile(aircraftScriptPath + "IFEI\\indicator\\IFEI_init.lua", luaImport + "try_find_assigned_viewport(\"FA_18C_IFEI\", \"IFEI\")");
            patchFile(aircraftScriptPath + "UFC\\indicator\\UFC_init.lua", luaImport + "try_find_assigned_viewport(\"FA_18C_UFC\", \"UFC\")");
            patchFile(aircraftScriptPath + "Multipurpose_Display_Group\\AMPCD\\indicator\\AMPCD_viewport_cfg.lua", oldCenterMFCD, newCenterMFCD);
            patchFile(aircraftScriptPath + "Multipurpose_Display_Group\\MDI_IP1556A\\indicator\\MDI_left_viewport_cfg.lua", oldLeftMFCD, newLeftMFCD);
            patchFile(aircraftScriptPath + "Multipurpose_Display_Group\\MDI_IP1556A\\indicator\\MDI_right_viewport_cfg.lua", oldRightMFCD, newRightMFCD);

            // Patch the rwr file separately
            try
            {
                string luaCode = File.ReadAllText(aircraftScriptPath + "TEWS\\indicator\\RWR_ALR67_init.lua");
                string oldShaderLineDefaultThickness = "shaderLineDefaultThickness = 1.8";
                string newShaderLineDefaultThickness = "shaderLineDefaultThickness = 0.045";
                string oldShaderLineDefaultFuzziness = "shaderLineDefaultFuzziness = 0.4";
                string newShaderLineDefaultFuzziness = "shaderLineDefaultFuzziness = 0.01";
                string context = luaImport + "try_find_assigned_viewport(\"FA_18C_RWR\", \"RWR\")";
                if (luaCode.Contains(newShaderLineDefaultFuzziness) && luaCode.Contains(newShaderLineDefaultThickness) && luaCode.Contains(context))
                {
                    listBox.Items.Add("[*] F18 RWR has been patched!");
                    return true;
                }
                else
                {
                    File.WriteAllText(aircraftScriptPath + "TEWS\\indicator\\RWR_ALR67_init.lua.cfgbak", luaCode);
                    string newLuaCode;
                    newLuaCode = luaCode.Replace(oldShaderLineDefaultFuzziness, newShaderLineDefaultFuzziness);
                    newLuaCode = newLuaCode.Replace(oldShaderLineDefaultThickness, newShaderLineDefaultThickness);
                    newLuaCode = newLuaCode + context;
                    File.WriteAllText(aircraftScriptPath + "TEWS\\indicator\\RWR_ALR67_init.lua", newLuaCode);
                    return true;
                }
            }
            catch
            {
                return false;
            }

            
        }

        public bool recoveryA10C()
        {
            string aircraftScriptPath = path + "A-10C\\Cockpit\\Scripts\\";
            listBox.Items.Add("[*] recovering A10C");
            recoveryFile(aircraftScriptPath + "AN_ALR69V\\indicator\\AN_ALR69V_init.lua");
            recoveryFile(aircraftScriptPath + "CDU\\indicator\\CDU_init.lua");
            recoveryFile(aircraftScriptPath + "DigitalClock\\Indicator\\DIGIT_CLK_init.lua");
            recoveryFile(aircraftScriptPath + "HUD\\Indicator\\HUD_init.lua");
            recoveryFile(aircraftScriptPath + "MFCD\\indicator\\MFCD_left_init.lua");
            recoveryFile(aircraftScriptPath + "MFCD\\indicator\\MFCD_right_init.lua");
            return false;
        }

        public bool recoveryA10C2()
        {
            string aircraftScriptPath = path + "A-10C_2\\Cockpit\\Scripts\\";
            listBox.Items.Add("[*] recovering A10C2");
            recoveryFile(aircraftScriptPath + "AN_ALR69V\\indicator\\AN_ALR69V_init.lua");
            recoveryFile(aircraftScriptPath + "CDU\\indicator\\CDU_init.lua");
            recoveryFile(aircraftScriptPath + "DigitalClock\\Indicator\\DIGIT_CLK_init.lua");
            recoveryFile(aircraftScriptPath + "HUD\\Indicator\\HUD_init.lua");
            recoveryFile(aircraftScriptPath + "MFCD\\indicator\\MFCD_left_init.lua");
            recoveryFile(aircraftScriptPath + "MFCD\\indicator\\MFCD_right_init.lua");
            return true;
        }

        public bool recoveryAH64D()
        {
            string aircraftScriptPath = path + "AH-64D\\Cockpit\\Scripts\\";
            listBox.Items.Add("[*] recovering AH64D");
            recoveryFile(aircraftScriptPath + "Displays\\EUFD\\EUFD_plt_init.lua");
            recoveryFile(aircraftScriptPath + "Displays\\MFD\\indicator\\MFD_cpg_left_init.lua");
            recoveryFile(aircraftScriptPath + "Displays\\MFD\\indicator\\MFD_cpg_right_init.lua");
            recoveryFile(aircraftScriptPath + "Displays\\MFD\\indicator\\MFD_plt_left_init.lua");
            recoveryFile(aircraftScriptPath + "Displays\\MFD\\indicator\\MFD_plt_right_init.lua");
            recoveryFile(aircraftScriptPath + "Displays\\TEDAC\\TEDAC_init.lua");
            recoveryFile(aircraftScriptPath + "Displays\\TEDAC\\LCD\\TEDAC_LCD_init.lua");
            return true;
        }

        public bool recoveryAV8B()
        {
            string aircraftScriptPath = path + "AV8BNA\\Cockpit\\MPCD\\indicator\\MPCD_init.lua";
            listBox.Items.Add("[*] recovering AV8B");
            return recoveryFile(aircraftScriptPath);
        }

        public bool recoveryF16C()
        {
            string aircraftScriptPath = path + "F-16C\\Cockpit\\Scripts\\";
            listBox.Items.Add("[*] recovering F16C");
            recoveryFile(aircraftScriptPath + "Displays\\DED\\indicator\\DED_init.lua");
            recoveryFile(aircraftScriptPath + "Displays\\EHSI\\indicator\\LCD\\EHSI_LCD.lua");
            recoveryFile(aircraftScriptPath + "Displays\\MFD\\indicator\\LCD\\MFD_LCD_Left.lua");
            recoveryFile(aircraftScriptPath + "Displays\\MFD\\indicator\\LCD\\MFD_LCD_Right.lua");
            recoveryFile(aircraftScriptPath + "EWS\\RWR\\indicator\\RWR_ALR56_init.lua");
            return true;
        }

        public bool recoveryFA18C()
        {
            string aircraftScriptPath = path + "FA-18C\\Cockpit\\Scripts\\";
            listBox.Items.Add("[*] recovering FA18C");
            recoveryFile(aircraftScriptPath + "IFEI\\indicator\\IFEI_init.lua");
            recoveryFile(aircraftScriptPath + "UFC\\indicator\\UFC_init.lua");
            recoveryFile(aircraftScriptPath + "Multipurpose_Display_Group\\AMPCD\\indicator\\AMPCD_viewport_cfg.lua");
            recoveryFile(aircraftScriptPath + "Multipurpose_Display_Group\\MDI_IP1556A\\indicator\\MDI_left_viewport_cfg.lua");
            recoveryFile(aircraftScriptPath + "Multipurpose_Display_Group\\MDI_IP1556A\\indicator\\MDI_right_viewport_cfg.lua");
            recoveryFile(aircraftScriptPath + "TEWS\\indicator\\RWR_ALR67_init.lua");
            return true;
        }
    }
}
