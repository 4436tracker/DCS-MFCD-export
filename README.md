### 用途：

用于为DCS机型mod中LCD，LED等非钟表类型的仪表添加导出代码（不能过未修改脚本检查）。也可以用来取消已经添加的输出代码（恢复到可以过未修改脚本检查）。



### 用法：

分为两步，第一步添加机型仪表导出代码，第二部设置显示器配置lua文件

##### 第一步：

### ![1](https://raw.github.com/c4p74ln/DCS-MFCD-export/tree/main/img/1.png)

选择DCS.exe所在的路径并打开。即可扫描出所有已安装机型mod文件。

![2](https://github.com/c4p74ln/DCS-MFCD-export/tree/main/img/2.png)

其中JF17,F14,Ka50等自带导出所需的代码就不用操作了，FC3不支持。接下来勾选需要导出仪表的机型，并按下`添加输出`即可为相应机型添加仪表导出的代码。

![3](https://github.com/c4p74ln/DCS-MFCD-export/tree/main/img/3.png)

下方列表中出现各个文件的修改情况。其中`[+]`为成功执行，`[-]`为执行失败。

##### 第二步：

成功执行后即可添加MonitorSetup一个新的配置文件，lua代码如下

```lua
_  = function(p) return p; end;
name = _('twoscreen-LMFCD+Camera+RMFCD');
Description = 'Left MFCD,Right MFCD on the left and camera on the right'

A_10C_2_HUD = { x = 640, y = 0, width = 640, height = 640 }
A_10C_2_CDU_SCREEN = { x = 640, y = 640, width = 640, height = 440 }
A_10C_2_LEFT_MFCD = { x = 0, y = 440, width = 640, height = 640 }
A_10C_2_RIGHT_MFCD = { x = 1280, y = 440, width = 640, height = 640 }
A_10C_2_RWR_SCREEN = { x = 1280, y = 0, width = 440, height = 440 }
A_10C_2_DIGIT_CLOCK = { x = 200, y = 0, width = 440, height = 440 }

A_10C_HUD = { x = 640, y = 0, width = 640, height = 640 }
A_10C_CDU_SCREEN = { x = 640, y = 640, width = 640, height = 440 }
A_10C_LEFT_MFCD = { x = 0, y = 440, width = 640, height = 640 }
A_10C_RIGHT_MFCD = { x = 1280, y = 440, width = 640, height = 640 }
A_10C_RWR_SCREEN = { x = 1280, y = 0, width = 440, height = 440 }
A_10C_DIGIT_CLOCK = { x = 200, y = 0, width = 440, height = 440 }

F_16C_DED = { x = 1180, y = 740, width = 740, height = 150 }
F_16C_EHSI = { x = 740, y = 0, width = 440, height = 440 }
F_16C_LEFT_MFCD = { x = 0, y = 0, width = 740, height = 740 }
F_16C_RIGHT_MFCD = { x = 1180, y = 0, width = 740, height = 740 }
F_16C_RWR = { x = 740, y = 440, width = 440, height = 440 }

FA_18C_CENTER_MFCD = { x = 640, y = 440, width = 640, height = 640 }
FA_18C_IFEI = { x = 0, y = 640, width = 640, height = 440 }
FA_18C_LEFT_MFCD = { x = 0, y = 0, width = 640, height = 640 }
FA_18C_RIGHT_MFCD = { x = 1280, y = 0, width = 640, height = 640 }
FA_18C_RWR = { x = 1380, y = 640, width = 440, height = 440 }
FA_18C_UFC = { x = 640, y = 0, width = 640, height = 440 }

--Ka50
ABRIS = { x = 1080, y = 0, width = 840, height = 1080 }
Shkval = { x = 0, y = 0, width = 1080, height = 1080 }

AV8BNA_LEFT_MFCD = { x = 0, y = 0, width = 960, height = 960}
AV8BNA_RIGHT_MFCD = { x = 960, y = 0, width = 960, height = 960 }

AH_64D_EUFD = {x = 540, y = 660, width = 840, height = 420}
AH_64D_PLT_LEFT_MFD = {x = 0, y = 540, width = 540, height = 540}
AH_64D_PLT_RIGHT_MFD = {x = 1380, y = 540, width = 540, height = 540}
AH_64D_CPG_LEFT_MFD = {x = 0, y = 0, width = 540, height = 540}
AH_64D_CPG_RIGHT_MFD = {x = 1380, y = 0, width = 540, height = 540}
AH_64D_TEDAC = {x = 630, y = 0, width = 660, height = 660}

F14_VDI = {x = 0, y = 0, width = 540, height = 540}
F14_HUD = {x = 540, y = 0, width = 540, height = 540}
F14_HSD = {x = 1080, y = 0, width = 540, height = 540}
F14_DDD = {x = 0, y = 540, width = 540, height = 540}
F14_TID = {x = 540, y = 540, width = 540, height = 540}
F14_ECMD = {x = 1080, y = 0, width = 540, height = 540}
F14_ALR67 = {x = 1620, y = 0, width = 300, height = 300}
F14_UHF_ARC159 = {x = 1620, y = 300, width = 300, height = 100}
F14_VHF_ARC182 = {x = 1620, y = 400, width = 300, height = 100}


JF17_LEFT_MFCD = {x = 0, y = 0, width = 640, height = 860}
JF17_CENTER_MFCD = {x = 640, y = 220, width = 640, height = 860}
JF17_RIGHT_MFCD = {x = 1280, y = 0, width = 640, height = 860}
JF17_UFCP_1 = {x = 823, y = 0, width = 275, height = 55}
JF17_UFCP_2 = {x = 823, y = 55, width = 275, height = 55}
JF17_UFCP_3 = {x = 823, y = 110, width = 275, height = 55}
JF17_UFCP_4 = {x = 823, y = 165, width = 275, height = 55}
JF17_RADIO = {x = 0, y = 860, width = 640, height = 220}
JF17_CLOCK_WIN1 = {x = 1370, y = 860, width = 550, height = 110}
JF17_CLOCK_WIN2 = {x = 1370, y = 970, width = 550, height = 110}

Viewports =
{
     Center =
     {
          x = 1920;
          y = 0;
          width = 2560;
          height = 1440;
          viewDx = 0;
          viewDy = 0;
          aspect = 2560 / 1440;
     }
}

UIMainView = Viewports.Center
GU_MAIN_VIEWPORT = Viewports.Center
```

其中各项数据需要按自己显示器大小计算并填入。

### 需注意：

1. 该程序支持的取消仪表导出，恢复到可以过未修改脚本检查只对程序修改的有效。手动导出的无法恢复。
2. 程序再导出仪表前会对需要修改的文件进行备份并重命名为 `XXXX.lua.cfgbak` ,必要时可以手动删除 `.cfgbak` 恢复为正常的lua文件。
3. 为了避免导出程序出现意料之外的问题导致DCS无法使用。我也开发了另一款软件，可用于修复DCS。同时该软件也可切换官网版DCS至测试版，稳定版或者其他ED允许的特定版本号的版本。
