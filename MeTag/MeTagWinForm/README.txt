本工具满足以下需求，是暂时使用的简化版
===========================================
IPA项目Travel领域的数据标注需求
1、建议数据来源：
SMS corpus (NUS SMS corpus - english): http://wing.comp.nus.edu.sg:8080/SMSCorpus/history.jsp，为短文档
Twitter corpus: 需要自己爬取，为短文档
Travel guide sites: www.tripadvisor.com，国家地理，Lonely planet等，还可以是一些垂直网站，如backpacks方面的，参考 http://www.dmoz.org/Recreation/Travel/Specialty_Travel/Backpacking
Travel guide sites分为长文档和短文档
长文档数据：游记，travel blog等
短文档数据：用户review或comment
以上数据，如果原数据有用户信息，都需要爬取
2、标注量和标注项
     长文档数据：每个类目3000篇
     短文档数据：每个类目3000篇
<type>...</type>	tour > rest > backpacks > business中的一种
<purpose>...</purpose>	文中明确提到能够触发旅游的事件，而且，需要区别是大众事件还是个人事件。个人事件，如 anniversary，vacation，wedding，business trip，birthday，graduation。大众事件，如 节日, 演唱会，表演等。
需要用<purpose value="personal/public">表明。
<destination>...</destination>	国家、城市、旅馆、景点都可以是destination
需要用<destination value="country/city/hotel/attraction">表明。
<attender>...</attender>	需要包含物主代词，如my wife整个标注
 <transport>...</transport>	交通工具
<beforetravel>...</beforetravel>	如下三类是activity。如果整个句子需要总结，则用 value=“总结的activity”（你们可以自己建立这些总结的activity，单数目不要过多，最简单的"动宾短语"形式总结）。
< duringtravel >...</ duringtravel >	同上
< aftertravel >...</ aftertravel >	同上
<time>...</time>	旅游发生或持续的时间。包括具体日期或时间，如after 3 days, this summer, on weekend, etc，和时长，如 玩了" 3 days", for "3 weeks", etc.
需要用<time value="time/period">表明。
<intent>...</intent>	分为正向和负向，正向表示有较大可能会到某地去，比如，"have a plan to go trip", "can't wait to go ", etc.负向表示不想去某地，比如,"have been to New York", "will not attend", etc.
注：
<type>...</type>和<intent>...</intent>需要整段标示。其他是在原文出现位置标示，不出现不需要标示
如果感觉无法清晰区分的，可以忽略，不对改文档进行标注（如感觉一篇文档无法认为是tours还是rest，或者即使tours有事rest，就不标注该文档）。
backpacks通常涉及多个地方，持续时间通常比tour和rest长的多,一般长达1月甚至半年、一年。
我们会按照标注出来的有效tag来计算费用，每篇文章标注出来的有效tag越多，则钱数越多。
如果像purpose和activity这样的tag，如果有经过我们确认的新增tag产生，则有额外奖励。
<intent>...</intent>，表示不太确定
     
3. 标注对象要求
 整个文档只描述一个destination的情况，
其中如果是长文档， 
    如一个文档描述多个destination（如3个），每个destination的描述都比较全面，则将改文档拆分为多个标注（如拆为3个来进行标注）
如一个文档只清晰的描述一个destination，其他描述比较模糊，则标注为一个；如果描述都比较模糊，则不对本文档进行标注。
短文档，尽可能一句话中出现所有元素。
   
4. 标注样例
长文档标注样例（不一定完善，只是大致表示）
<type>tour</type> 
<attender>My wife</attender> and I went to <destination value="attraction">Yosemite National Park</destination> <time value="time”>last July</time> for our <purpose value="personal">anniversary</purpose>. We have such kind of travel every year, since in July, my wife has one holiday about one and half month.
before departure, <beforetravel value="check weather">we had make sure whether there is good weather</beforetravel>is good or not in Yosemite National Park. In order to have enough energy to enjoy the natural beauty of Yosemite National Park, we <beforetravel value="schedule transport">decided to take public transportation</beforetravel>.
In order to store the beauty in memory, we prepare the camera. Although it seems one simple travel, there are so many things to prepare, food, water, tent and so on
We departed from Los Angeles <transport>by bus</transport> <time value="time”>at 4:10 AM, 2 July</time> and arrived at Bakersfield <time value="time”>at 7:15 AM</time>. Without break, we <transport>took train</transport> at <time value="time”>7:15 AM</time>, <time value="time”>after 3 hours</time>, we arrived at Merced. After a short rest, we <transport>took bus</transport> <time value="time”>at 10:50 AM</time> to go to Yosemite Lodge. Finally, we arrived at <time value="time”>2:45 PM</time>.
In Yosemite National Park, we <duringtrave>watched A</duringtrave>.... <duringtrave>climbed xxx mountain</duringtravel>.

短文档标注样例
 <time value="time”>next	week</time> <attender>my husband</attender> & I will be heading to our <purpose value="personal">honeymoon</purpose> in <destination value="city">Paris</destination> !
 I spend <time value=" period”>2 weeks</time> staying in <destination value="hotel">Hilton Hawaiian Village</destination> this summer.

标注基本准则：
开始真实标注时，和数据公司商量好，按照文章的量拆成小包。我们会在每个小包中，抽查10~30%不等的标注样例。
如果标注准确度不合格，则该数据包退回全部重标。如果数据包被退回三次或三次以上，则该数据包全部数据作废。
注：标注准确度=1-（多标+漏标+错标）/标注的tag数量

输入格式样例：
==========================================
<?xml version="1.0" encoding="GBK"?>
<document id="4928" type="News">
  <meta url="http://www.china-region.com/News/HTML/20090901075048_8768.htm" src="中国证券网·上海证券报" time="2009-9-1 7:50:48" channel="中国区域开发网&gt;&gt;规划热点&gt;&gt;新闻正文" bookmark="" />
  <author name="王屹" />
  <title>发改委批准重庆三基地四港区物流规划</title>
  <doc>重庆市发改委副主任王平30日表示，该市拟订的“三基地四港区”规划，近日已获得国家发改委批准。据悉，这是全国相关物流规划尚未正式出台以前，国家发改委出文确认的第一个物流布局规划。
　　据王平介绍，“三基地”包括：团结村集装箱中心站铁路物流基地、江北国际机场航空物流基地、巴南区公路物流基地。“四港区”则是结合长江水运资源和国家批准的内陆唯一保税港区优势，规划布局的寸滩港港区、果园港港区、东港港区和黄谦港港区4个水运物流枢纽。
　　该规划是重庆市对接国家物流业调整和振兴规划的主枢纽平台，其内部交通均为多式联运。建成后，货物可通过铁路、水运、航空、公路快速周转，通达非常便捷。
　　“以上项目将在2020年以前全部投入使用。”王平说，“三基地四港区”预计总投资上百亿元，若算上周边交通改造，总投资将达200亿元以上。目前，寸滩港第三期、果园港、东港等港区均已开工建设，位于巴南的公路物流基地也正在规划中。
　　据悉，重庆是全国9大物流区域中心城市之一，根据国家对该市发展的要求，重庆将在2020年以前，建设成为长江上游地区的经济中心和综合交通枢纽。近期为推动项目上马，重庆近日已先后在中国香港、新加坡等地举行招商推介会，吸引企业参建。目前全球共有数十家企业对重庆物流项目兴趣浓厚，例如新加坡亚星集团、辉联、讯通、凝聚船务、总统轮船、叶水福等企业，近期均将来渝进行详细考察。
　　对此， 重庆港九(行情 股吧)董事长黄继向本报记者表示，“四港区”中的寸滩港一、二期和黄谦港均为上市公司控股或参股子公司，下一步寸滩港三期和果园港建成投产后也有计划考虑从实际控制人重庆港务物流集团手中收购，因此这无疑对重庆港九的未来发展构成长期利好。
</doc>
  <category>##城市规划##区域规划</category>
  <sentiment>褒义</sentiment>
</document>


输出格式为：
==========================================
<?xml version="1.0" encoding="UTF-8"?>
<doc id="some doc Id" ref="http://someurl.com/somerandomsubways" author="AuthorName">
   <type>tour</type>
   <title>如果明显有则标出，没有则留为空</title>
   <content xml:space="preserve"><attender>My wife</attender> and I went to <destination value="attraction">Yosemite National Park</destination> <time value="time">last July</time> for our <purpose value="personal">anniversary</purpose>. We have such kind of travel every year, since in July, my wife has one holiday about one and half month.
before departure, <beforetravel value="check weather">we had make sure whether there is good weather</beforetravel>is good or not in Yosemite National Park. In order to have enough energy to enjoy the natural beauty of Yosemite National Park, we <beforetravel value="schedule transport">decided to take public transportation</beforetravel>.
In order to store the beauty in memory, we prepare the camera. Although it seems one simple travel, there are so many things to prepare, food, water, tent and so on
We departed from Los Angeles <transport>by bus</transport> <time value="time">at 4:10 AM, 2 July</time> and arrived at Bakersfield <time value="time">at 7:15 AM</time>. Without break, we <transport>took train</transport> at <time value="time">7:15 AM</time>, <time value="time">after 3 hours</time>, we arrived at Merced. After a short rest, we <transport>took bus</transport> <time value="time">at 10:50 AM</time> to go to Yosemite Lodge. Finally, we arrived at <time value="time">2:45 PM</time>.
In Yosemite National Park, we <duringtravel>watched A</duringtravel>.... <duringtravel>climbed xxx mountain</duringtravel>.
   </content>
</doc>


使用方法：
========================================
基本操作：
----------------------------------------
使用Open按钮打开输入的xml文件或者工作文件（*.ws），打开工作文件可以继续之前的结果进行操作。
使用Save按钮保存标记好的文件。保存结果又两个，一个是输出文件，一个是包含完整标记信息的方便工具二次读取的工作文件（*.ws）。
在左侧文本栏里可以浏览文本，使用Ctrl+鼠标滚轮缩放字体，文本栏会自动换行但是这个换行不会输出。
拖动窗体右下角改变窗体大小。

标记Tag：
----------------------------------------
type和intent直接在下拉列表中选取，标记作用于整篇文档。
其它8个标记使用鼠标选择一段文本，然后在下拉列表中选择附加属性（如果有的话），然后按快捷键F1~F8添加。
或者选择文本，按住快捷键F1~F8不放，这时可以使用鼠标滚轮选择对应Tag的附加属性列表，然后松开F1~F8完成添加
Tag会在文档中以响应的颜色标出。

修改/删除Tag：
----------------------------------------
选择Tag范围内的一部分后，当前Tag会在右侧粗体显示，同时下拉列表显示当前Tag的附加属性，这个时候选择下拉列表其它项目则当前Tag的附加属性也一同修改。
选择Tag范围内的一部分后，当前Tag会在右侧粗体显示，同时下拉列表显示当前Tag的附加属性，这个时候再次点击任意快捷键会删除当前Tag

关于历史记录
----------------------------------------
点击工具栏Show History按钮可以查看文档的编辑记录，如果打开的不是工作文件"*.ws"则只会有当前记录。打开工作文件可以查看工作文件记录。
每次保存文件会添加一条历史记录，历史记录包括打开，保存文件的时间和计算机名。