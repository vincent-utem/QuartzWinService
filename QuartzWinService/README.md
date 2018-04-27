## QuartzWinService 

通用WinService服务模板，基于Quartz.net（2.4.1）的WinService，支持分布式部署



## Frame version

<package id="Common.Logging" version="3.4.1" targetFramework="net461" />
<package id="Common.Logging.Core" version="3.4.1" targetFramework="net461" />
<package id="log4net" version="2.0.8" targetFramework="net461" />
<package id="Microsoft.CSharp" version="4.4.1" targetFramework="net461" />
<package id="Quartz" version="2.4.1" targetFramework="net461" />
<package id="Topshelf" version="4.0.4" targetFramework="net461" />
<package id="Topshelf.Log4Net" version="4.0.4" targetFramework="net461" />



## Why use

简单WinService开发，让开发专注于业务逻辑的开发，降低高效WinService的开发门槛



## How to use

单机版WinService服务模板 —— QuartzWinService
1、配置log4net.config；
2、配置quartz.config，注意：如要开启分布式布署，需开启SQL存储分布关系（数据库脚本/tables_sqlServer.sql）；
3、在/Jobs目录下，创建业务逻辑目录，该业务逻辑代码将存放在该目录下。如：写一个监控服务，创建/Jobs/Mirror目录；
4、在上一步创建的业务逻辑目录下，新建Work.cs文件，做为业务启动入口。请参考/Jobs/JobTemplate/Work.cs文件；（注：如果业务比较繁琐，还需创建其它模型文件，建议一并放在该目录下）
5、代码完成，需在/quartz_jobs.xml新建job节点，具体参考JobTemplate 任务配置；
6、本地调试，因为是控制台项目，可以直接按F5调试；
7、编译好的文件拷至服务器上安装，在命令行环境下，执行如下代码：
安装 <编译好的exe文件> install
启动 <编译好的exe文件> start
卸载 <编译好的exe文件> uninstall



## Update Logs

注：2018年1月Quartz.net已发布3.0.*版本，由于改动较大，暂不支持，待后期版本迭代再做修改；


-----------2018-04-26【V1.0.0】-----------
第一次提交，考虑到团队使用，从现有项目中分离中一个干净版本，做为通用WinService服务模板



