# LanzouLinkBuilder
## 原理
生成各式各样的蓝奏云文件分享链接！<br>
由于蓝奏云的域名是泛解析，所以域名`https://www.bilibili.fxxk.www.lanzoux.com`都是可以访问的，不信就[点这](https://www.bilibili.fxxk.www.lanzoux.com)试试

## 生成格式
生成器在`a - z`和`A - Z`和`0 - 9`之间随机选取字符插入到域名中，域名于`https://`开头，`www.lanzoux.com/`结尾

## 注意事项
节数不建议超过**13**，节字符数不建议超过**10**，往后可能会解析失败

## 运行库
此软件使用`.NET Framwork 4.8` `WinForm`框架开发，使用`AntdUI`库