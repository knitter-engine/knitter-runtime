# knitter-runtime
（开发中）Knitter引擎，是一款纯c#开发的开源游戏引擎。前期会主要以2d开发为主，3d方向次之。开发主要分为几个阶段：
- 利用三方库，接入渲染、音频、输入、资源等等模块。迅速完成一个完整流程的开发。但是每个模块要尽可能使用接口进行解耦，方便未来替换、升级
- 完善runtime的开发流程，更趋向于一个完整的开发流程，而不是一个玩具。
- 构建上层Editor，方便开发

# Roadmap
- [ ] 渲染库
- [ ] 音频库
- [ ] 输入库
- [ ] 图像库
- [ ] 物理引擎
- [ ] 确定场景内物体管理方案
- [ ] 脚本系统，c#、c++、rust、python等语言
- [ ] 图形化api
- [ ] Roslyn语法分析接入
