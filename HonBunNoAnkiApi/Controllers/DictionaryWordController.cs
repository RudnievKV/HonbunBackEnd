﻿using AutoMapper;
using HonbunNoAnkiApi.Dtos;
using HonbunNoAnkiApi.Dtos.WordDtos;
using HonbunNoAnkiApi.Common;
using HonbunNoAnkiApi.Models;
using HonbunNoAnkiApi.Services.Interfaces;
using MeCab;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HonbunNoAnkiApi.Models.DictionaryModels;

namespace HonbunNoAnkiApi.Controllers
{
    [Route("api/dictionary/word")]
    [ApiController]
    [Produces("application/json")]
    [AllowAnonymous]
    [EnableCors(CORSPolicies.StandartCORSPolicy)]
    public class DictionaryWordController : ControllerBase
    {
        private readonly IDictionaryWordService _wordService;

        public DictionaryWordController(IDictionaryWordService wordService)
        {
            this._wordService = wordService;
        }

        // GET: api/word/test
        [HttpPost("test")]
        public async Task<IActionResult> GetWordsTest()
        {
            try
            {
                var request = new Request()
                {
                    Text = "私《わたくし》はその人を常に先生と呼んでいた。だからここでもただ先生と書くだけで本名は打ち明けない。これは世間を憚《はば》かる遠慮というよりも、その方が私にとって自然だからである。私はその人の記憶を呼び起すごとに、すぐ「先生」といいたくなる。筆を執《と》っても心持は同じ事である。よそよそしい頭文字《かしらもじ》などはとても使う気にならない。私が先生と知り合いになったのは鎌倉《かまくら》である。その時私はまだ若々しい書生であった。暑中休暇を利用して海水浴に行った友達からぜひ来いという端書《はがき》を受け取ったので、私は多少の金を工面《くめん》して、出掛ける事にした。私は金の工面に二《に》、三日《さんち》を費やした。ところが私が鎌倉に着いて三日と経《た》たないうちに、私を呼び寄せた友達は、急に国元から帰れという電報を受け取った。電報には母が病気だからと断ってあったけれども友達はそれを信じなかった。友達はかねてから国元にいる親たちに勧《すす》まない結婚を強《し》いられていた。彼は現代の習慣からいうと結婚するにはあまり年が若過ぎた。それに肝心《かんじん》の当人が気に入らなかった。それで夏休みに当然帰るべきところを、わざと避けて東京の近くで遊んでいたのである。彼は電報を私に見せてどうしようと相談をした。私にはどうしていいか分らなかった。けれども実際彼の母が病気であるとすれば彼は固《もと》より帰るべきはずであった。それで彼はとうとう帰る事になった。せっかく来た私は一人取り残された。学校の授業が始まるにはまだ大分《だいぶ》日数《ひかず》があるので鎌倉におってもよし、帰ってもよいという境遇にいた私は、当分元の宿に留《と》まる覚悟をした。友達は中国のある資産家の息子《むすこ》で金に不自由のない男であったけれども、学校が学校なのと年が年なので、生活の程度は私とそう変りもしなかった。したがって一人《ひとり》ぼっちになった私は別に恰好《かっこう》な宿を探す面倒ももたなかったのである。宿は鎌倉でも辺鄙《へんぴ》な方角にあった。玉突《たまつ》きだのアイスクリームだのというハイカラなものには長い畷《なわて》を一つ越さなければ手が届かなかった。車で行っても二十銭は取られた。けれども個人の別荘はそこここにいくつでも建てられていた。それに海へはごく近いので海水浴をやるには至極便利な地位を占めていた。私は毎日海へはいりに出掛けた。古い燻《くす》ぶり返った藁葺《わらぶき》の間《あいだ》を通り抜けて磯《いそ》へ下りると、この辺《へん》にこれほどの都会人種が住んでいるかと思うほど、避暑に来た男や女で砂の上が動いていた。ある時は海の中が銭湯《せんとう》のように黒い頭でごちゃごちゃしている事もあった。その中に知った人を一人ももたない私も、こういう賑《にぎ》やかな景色の中に裹《つつ》まれて、砂の上に寝《ね》そべってみたり、膝頭《ひざがしら》を波に打たしてそこいらを跳《は》ね廻《まわ》るのは愉快であった。私は実に先生をこの雑沓《ざっとう》の間《あいだ》に見付け出したのである。その時海岸には掛茶屋《かけぢゃや》が二軒あった。私はふとした機会《はずみ》かその一軒の方に行き慣《な》れていた。長谷辺《はせへん》に大きな別荘を構えている人と違って、各自《めいめい》に専有の着換場《きがえば》を拵《こしらえていないここいらの避暑客には、ぜひともこうした共同着換所といった風《ふう》なものが必要なのであった。彼らはここで茶を飲み、ここで休息する外《か》に、ここで海水着を洗濯させたり、ここで鹹《しお》はゆい身体《からだ》を清めたり、ここへ帽子や傘《かさ》を預けたりするのである。海水着を持たな私にも持物を盗まれる恐れはあったので、私は海へはいるたびにその茶屋へ一切《いっさい》を脱《ぬ》ぎ棄《す》てる事にしていた。「私の亡友に対するこうした感じはいつまでも続きました。実は私も初めからそれを恐れていたのです。年来の希望であった結婚すら、不安のうちに式を挙げたといえばいえない事もないでしょう。しかし自分で自分の先が見えない人間の事ですから、ことによるとあるいはこれが私の心持を一転して新しい生涯に入《はい》る端緒《いとくち》になるかも知れないとも思ったのです。ところがいよいよ夫として朝夕｜妻《さい》と顔を合せてみると、私の果敢《はか》ない希望は手厳しい現実のために脆《もろ》くも破壊されてしまいました。私は妻と顔を合せているうちに、卒然《そつぜん》Ｋに脅《おびや》かされるのです。つまり妻が中間に立って、Ｋと私をどこまでも結び付けて離さないようにするのです。妻のどこにも不足を感じない私は、ただこの一点において彼女を遠ざけたがりました。すると女の胸にはすぐそれが映《うつ》ります。映るけれども、理由は解《わか》らないのです。私は時々妻からなぜそんなに考えているのだとか、何か気に入らない事があるのだろうとかいう詰問《きつもん》を受けました。笑って済ませる時はそれで差支《さしつか》えないのですが、時によると、妻の癇《かん》も高《こう》じて来ます。しまいには「あなたは私を嫌っていらっしゃるんでしょう」とか、「何でも私に隠していらっしゃる事があるに違いない」とかいう怨言《えんげん》も聞かなくてはなりません。私はそのたびに苦しみました。　私は一層《いっそ》思い切って、ありのままを妻に打ち明けようとした事が何度もあります。しかしいざという間際になると自分以外のある力が不意に来て私を抑《おさ》え付けるのです。私を理解してくれるあなたの事だから、説明する必要もあるまいと思いますが、話すべき筋だから話しておきます。その時分の私は妻に対して己《おの》れを飾る気はまるでなかったのです。もし私が亡友に対すると同じような善良な心で、妻の前に懺悔《ざんげ》の言葉を並べたなら、妻は嬉《うれ》し涙をこぼしても私の罪を許してくれたに違いないのです。それをあえてしない私に利害の打算があるはずはありません。私はただ妻の記憶に暗黒な一点を印《いん》するに忍びなかったから打ち明けなかったのです。純白なものに一雫《ひとしずく》の印気《インキ》でも容赦《ようしゃ》なく振り掛けるのは、私にとって大変な苦痛だったのだと解釈して下さい。　一年｜経《た》ってもＫを忘れる事のできなかった私の心は常に不安でした。私はこの不安を駆逐《くちく》するために書物に溺《おぼ》れようと力《つと》めました。私は猛烈な勢《いきおい》をもって勉強し始めたのです。そうしてその結果を世の中に公《おおやけ》にする日の来るのを待ちました。けれども無理に目的を拵《こしら》えて、無理にその目的の達せられる日を待つのは嘘《うそ》ですから不愉快です。私はどうしても書物のなかに心を埋《うず》めていられなくなりました。私はまた腕組みをして世の中を眺《なが》めだしたのです。　妻はそれを今日《こんにち》に困らないから心に弛《たる》みが出るのだと観察していたようでした。妻の家にも親子二人ぐらいは坐《すわ》っていてどうかこうか暮して行ける財産がある上に、私も職業を求めないで差支《さしつか》えのない境遇にいたのですから、そう思われるのももっともです。私も幾分かスポイルされた気味がありましょう。しかし私の動かなくなった原因の主なものは、全くそこにはなかったのです。叔父《おじ》に欺《あざむ》かれた当時の私は、他《ひと》の頼みにならない事をつくづくと感じたには相違ありませんが、他《ひと》を悪く取るだけあって、自分はまだ確かな気がしていました。世間はどうあろうともこの己《おれ》は立派な人間だという信念がどこかにあったのです。それがＫのために美事《みごと》に破壊されてしまって、自分もあの叔父と同じ人間だと意識した時、私は急にふらふらしました。他《ひと》に愛想《あいそ》を尽かした私は、自分にも愛想を尽かして動けなくなったのです。［＃５字下げ］五十三［＃「五十三」は中見出し］「書物の中に自分を生埋《いきう》めにする事のできなかった私は、酒に魂を浸《ひた》して、己《おの》れを忘れようと試みた時期もあります。私は酒が好きだとはいいません。けれども飲めば飲める質《たち》でしたから、ただ量を頼みに心を盛《も》り潰《つぶ》そうと力《つと》めたのです。この浅薄《せんぱく》な方便はしばらくするうちに私をなお厭世的《えんせいてき》にしました。私は爛酔《らんすい》の真最中《まっさいちゅう》にふと自分の位置に気が付くのです。自分はわざとこんな真似《まね》をして己れを偽《いつわ》っている愚物《ぐぶつ》だという事に気が付くのです。すると身振《みぶる》いと共に眼も心も醒《さ》めてしまいます。時にはいくら飲んでもこうした仮装状態にさえ入《はい》り込めないでむやみに沈んで行く場合も出て来ます。その上技巧で愉快を買った後《あと》には、きっと沈鬱《ちんうつ》な反動があるのです。私は自分の最も愛している妻《さい》とその母親に、いつでもそこを見せなければならなかったのです。しかも彼らは彼らに自然な立場から私を解釈して掛《かか》ります。　妻の母は時々｜気拙《きまず》い事を妻にいうようでした。それを妻は私に隠していました。しかし自分は自分で、単独に私を責めなければ気が済まなかったらしいのです。責めるといっても、決して強い言葉ではありません。妻から何かいわれたために、私が激した例《ためし》はほとんどなかったくらいですから。妻はたびたびどこが気に入らないのか遠慮なくいってくれと頼みました。それから私の未来のために酒を止《や》めろと忠告しました。ある時は泣いて「あなたはこの頃《ごろ》人間が違った」といいました。それだけならまだいいのですけれども、「Ｋさんが生きていたら、あなたもそんなにはならなかったでしょう」というのです。私はそうかも知れないと答えた事がありましたが、私の答えた意味と、妻の了解した意味とは全く違っていたのですから、私は心のうちで悲しかったのです。それでも私は妻に何事も説明する気にはなれませんでした。　私は時々妻に詫《あや》まりました。それは多く酒に酔って遅く帰った翌日《あくるひ》の朝でした。妻は笑いました。あるいは黙っていました。たまにぽろぽろと涙を落す事もありました。私はどっちにしても自分が不愉快で堪《たま》らなかったのです。だから私の妻に詫まるのは、自分に詫まるのとつまり同じ事になるのです。私はしまいに酒を止《や》めました。妻の忠告で止めたというより、自分で厭《いや》になったから止めたといった方が適当でしょう。　酒は止めたけれども、何もする気にはなりません。仕方がないから書物を読みます。しかし読めば読んだなりで、打《う》ち遣《や》って置きます。私は妻から何のために勉強するのかという質問をたびたび受けました。私はただ苦笑していました。しかし腹の底では、世の中で自分が最も信愛しているたった一人の人間すら、自分を理解していないのかと思うと、悲しかったのです。理解させる手段があるのに、理解させる勇気が出せないのだと思うとますます悲しかったのです。私は寂寞《せきばく》でした。どこからも切り離されて世の中にたった一人住んでいるような気のした事もよくありました。同時に私はＫの死因を繰り返し繰り返し考えたのです。その当座は頭がただ恋の一字で支配されていたせいでもありましょうが、私の観察はむしろ簡単でしかも直線的でした。Ｋは正《まさ》しく失恋のために死んだものとすぐ極《き》めてしまったのです。しかし段々落ち付いた気分で、同じ現象に向ってみると、そう容易《たやす》くは解決が着かないように思われて来ました。現実と理想の衝突、――それでもまだ不充分でした。私はしまいにＫが私のようにたった一人で淋《さむ》しくって仕方がなくなった結果、急に所決《しょけつ》したのではなかろうかと疑い出しました。そうしてまた慄《ぞっ》としたのです。私もＫの歩いた路《みち》を、Ｋと同じように辿《たど》っているのだという予覚《よかく》が、折々風のように私の胸を横過《よこぎ》り始めたからです。［＃５字下げ］五十四［＃「五十四」は中見出し］「その内｜妻《さい》の母が病気になりました。医者に見せると到底《とうてい》癒《なお》らないという診断でした。私は力の及ぶかぎり懇切に看護をしてやりました。これは病人自身のためでもありますし、また愛する妻のためでもありましたが、もっと大きな意味からいうと、ついに人間のためでした。私はそれまでにも何かしたくって堪《たま》らなかったのだけれども、何もする事ができないのでやむをえず懐手《ふところで》をしていたに違いありません。世間と切り離された私が、始めて自分から手を出して、幾分でも善《い》い事をしたという自覚を得たのはこの時でした。私は罪滅《つみほろぼ》しとでも名づけなければならない、一種の気分に支配されていたのです。母は死にました。私と妻《さい》はたった二人ぎりになりました。妻は私に向って、これから世の中で頼りにするものは一人しかなくなったといいました。自分自身さえ頼りにする事のできない私は、妻の顔を見て思わず涙ぐみました。そうして妻を不幸な女だと思いました。また不幸な女だと口へ出してもいいました。妻はなぜだと聞きます。妻には私の意味が解《わか》らないのです。私もそれを説明してやる事ができないのです。妻は泣きました。私が不断《ふだん》からひねくれた考えで彼女を観察しているために、そんな事もいうようになるのだと恨《うら》みました。　母の亡くなった後《あと》、私はできるだけ妻を親切に取り扱ってやりました。ただ、当人を愛していたからばかりではありません。私の親切には箇人《こじん》を離れてもっと広い背景があったようです。ちょうど妻の母の看護をしたと同じ意味で、私の心は動いたらしいのです。妻は満足らしく見えました。けれどもその満足のうちには、私を理解し得ないために起るぼんやりした稀薄《きはく》な点がどこかに含まれているようでした。しかし妻が私を理解し得たにしたところで、この物足りなさは増すとも減る気遣《きづか》いはなかったのです。女には大きな人道の立場から来る愛情よりも、多少義理をはずれても自分だけに集注される親切を嬉《うれ》しがる性質が、男よりも強いように思われますから。妻はある時、男の心と女の心とはどうしてもぴたりと一つになれないものだろうかといいました。私はただ若い時ならなれるだろうと曖昧《あいまい》な返事をしておきました。妻は自分の過去を振り返って眺《なが》めているようでしたが、やがて微《かす》かな溜息《ためいき》を洩《も》らしました。私の胸にはその時分から時々恐ろしい影が閃《ひらめ》きました。初めはそれが偶然｜外《そと》から襲って来るのです。私は驚きました。私はぞっとしました。しかししばらくしている中《うち》に、私の心がその物凄《ものすご》い閃きに応ずるようになりました。しまいには外から来ないでも、自分の胸の底に生れた時から潜《ひそ》んでいるもののごとくに思われ出して来たのです。私はそうした心持になるたびに、自分の頭がどうかしたのではなかろうかと疑《うたぐ》ってみました。けれども私は医者にも誰にも診《み》てもらう気にはなりませんでした。　私はただ人間の罪というものを深く感じたのです。その感じが私をＫの墓へ毎月《まいげつ》行かせます。その感じが私に妻の母の看護をさせます。そうしてその感じが妻に優しくしてやれと私に命じます。私はその感じのために、知らない路傍《ろぼう》の人から鞭《むち》うたれたいとまで思った事もあります、こうした階段を段々経過して行くうちに、人に鞭うたれるよりも、自分で自分を鞭うつべきだという気になります。自分で自分を鞭うつよりも、自分で自分を殺すべきだという考えが起ります。私は仕方がないから、死んだ気で生きて行こうと決心しました。　私がそう決心してから今日《こんにち》まで何年になるでしょう。私と妻とは元の通り仲好く暮して来ました。私と妻とは決して不幸ではありません、幸福でした。しかし私のもっている一点、私に取っては容易ならんこの一点が、妻には常に暗黒に見えたらしいのです。それを思うと、私は妻《さい》に対して非常に気の毒な気がします。［＃５字下げ］五十五［＃「五十五」は中見出し］「死んだつもりで生きて行こうと決心した私の心は、時々外界の刺戟《しげき》で躍《おど》り上がりました。しかし私がどの方面かへ切って出ようと思い立つや否《いな》や、恐ろしい力がどこからか出て来て、私の心をぐいと握り締めて少しも動けないようにするのです。そうしてその力が私にお前は何をする資格もない男だと抑《おさ》え付けるようにいって聞かせます。すると私はその一言《いちげん》で直《すぐ》ぐたりと萎《しお》れてしまいます。しばらくしてまた立ち上がろうとすると、また締め付けられます。私は歯を食いしばって、何で他《ひと》の邪魔をするのかと怒鳴り付けます。不可思議な力は冷《ひや》やかな声で笑います。自分でよく知っているくせにといいます。私はまたぐたりとなります。波瀾《はらん》も曲折もない単調な生活を続けて来た私の内面には、常にこうした苦しい戦争があったものと思って下さい。妻《さい》が見て歯痒《はがゆ》がる前に、私自身が何層倍《なんぞうばい》歯痒い思いを重ねて来たか知れないくらいです。私がこの牢屋《ろうや》の中《うち》に凝《じっ》としている事がどうしてもできなくなった時、またその牢屋をどうしても突き破る事ができなくなった時、必竟《ひっきょう》私にとって一番楽な努力で遂行《すいこう》できるものは自殺より外《ほか》にないと私は感ずるようになったのです。あなたはなぜといって眼を※［＃「目＋爭」、第3水準1-88-85］《みは》るかも知れませんが、いつも私の心を握り締めに来るその不可思議な恐ろしい力は、私の活動をあらゆる方面で食い留めながら、死の道だけを自由に私のために開けておくのです。動かずにいればともかくも、少しでも動く以上は、その道を歩いて進まなければ私には進みようがなくなったのです。私は今日《こんにち》に至るまですでに二、三度運命の導いて行く最も楽な方向へ進もうとした事があります。しかし私はいつでも妻に心を惹《ひ》かされました。そうしてその妻をいっしょに連れて行く勇気は無論ないのです。妻にすべてを打ち明ける事のできないくらいな私ですから、自分の運命の犠牲《ぎせい》として、妻の天寿《てんじゅ》を奪うなどという手荒《てあら》な所作《しょさ》は、考えてさえ恐ろしかったのです。私に私の宿命がある通り、妻には妻の廻《まわ》り合せがあります、二人を一束《ひとたば》にして火に燻《く》べるのは、無理という点から見ても、痛ましい極端としか私には思えませんでした。同時に私だけがいなくなった後《あと》の妻を想像してみるといかにも不憫《ふびん》でした。母の死んだ時、これから世の中で頼りにするものは私より外になくなったといった彼女の述懐《じゅっかい》を、私は腸《はらわた》に沁《し》み込むように記憶させられていたのです。私はいつも躊躇《ちゅうちょ》しました。妻の顔を見て、止《よ》してよかったと思う事もありました。そうしてまた凝《じっ》と竦《すく》んでしまいます。そうして妻から時々物足りなそうな眼で眺《なが》められるのです。記憶して下さい。私はこんな風《ふう》にして生きて来たのです。始めてあなたに鎌倉《かまくら》で会った時も、あなたといっしょに郊外を散歩した時も、私の気分に大した変りはなかったのです。私の後ろにはいつでも黒い影が括《く》ッ付《つ》いていました。私は妻《さい》のために、命を引きずって世の中を歩いていたようなものです。あなたが卒業して国へ帰る時も同じ事でした。九月になったらまたあなたに会おうと約束した私は、嘘《うそ》を吐《つ》いたのではありません。全く会う気でいたのです。秋が去って、冬が来て、その冬が尽きても、きっと会うつもりでいたのです。すると夏の暑い盛りに明治天皇《めいじてんのう》が崩御《ほうぎょ》になりました。その時私は明治の精神が天皇に始まって天皇に終ったような気がしました。最も強く明治の影響を受けた私どもが、その後《あと》に生き残っているのは必竟《ひっきょう》時勢遅れだという感じが烈《はげ》しく私の胸を打ちました。私は明白《あから》さまに妻にそういいました。妻は笑って取り合いませんでしたが、何を思ったものか、突然私に、では殉死《じゅんし》でもしたらよかろうと調戯《からか》いました。［＃５字下げ］五十六［＃「五十六」は中見出し］「私は殉死という言葉をほとんど忘れていました。平生《へいぜい》使う必要のない字だから、記憶の底に沈んだまま、腐れかけていたものと見えます。妻の笑談《じょうだん》を聞いて始めてそれを思い出した時、私は妻に向ってもし自分が殉死するならば、明治の精神に殉死するつもりだと答えました。私の答えも無論笑談に過ぎなかったのですが、私はその時何だか古い不要な言葉に新しい意義を盛り得たような心持がしたのです。それから約一カ月ほど経《た》ちました。御大葬《ごたいそう》の夜私はいつもの通り書斎に坐《すわ》って、相図《あいず》の号砲《ごうほう》を聞きました。私にはそれが明治が永久に去った報知のごとく聞こえました。後で考えると、それが乃木大将《のぎたいしょう》の永久に去った報知にもなっていたのです。私は号外を手にして、思わず妻に殉死だ殉死だといいました。私は新聞で乃木大将の死ぬ前に書き残して行ったものを読みました。西南戦争《せいなんせんそう》の時敵に旗を奪《と》られて以来、申し訳のために死のう死のうと思って、つい今日《こんにち》まで生きていたという意味の句を見た時、私は思わず指を折って、乃木さんが死ぬ覚悟をしながら生きながらえて来た年月《としつき》を勘定して見ました。西南戦争は明治十年ですから、明治四十五年までには三十五年の距離があります。乃木さんはこの三十五年の間《あいだ》死のう死のうと思って、死ぬ機会を待っていたらしいのです。私はそういう人に取って、生きていた三十五年が苦しいか、また刀を腹へ突き立てた一刹那《いっせつな》が苦しいか、どっちが苦しいだろうと考えました。それから二、三日して、私はとうとう自殺する決心をしたのです。私に乃木さんの死んだ理由がよく解《わか》らないように、あなたにも私の自殺する訳が明らかに呑《の》み込めないかも知れませんが、もしそうだとすると、それは時勢の推移から来る人間の相違だから仕方がありません。あるいは箇人《こじん》のもって生れた性格の相違といった方が確《たし》かかも知れません。私は私のできる限りこの不可思議な私というものを、あなたに解らせるように、今までの叙述で己《おの》れを尽《つく》したつもりです。私は妻《さい》を残して行きます。私がいなくなっても妻に衣食住の心配がないのは仕合《しあわ》せです。私は妻に残酷な驚怖《きょうふ》を与える事を好みません。私は妻に血の色を見せないで死ぬつもりです。妻の知らない間《ま》に、こっそりこの世からいなくなるようにします。私は死んだ後で、妻から頓死《とんし》したと思われたいのです。気が狂ったと思われても満足なのです。私が死のうと決心してから、もう十日以上になりますが、その大部分はあなたにこの長い自叙伝の一節を書き残すために使用されたものと思って下さい。始めはあなたに会って話をする気でいたのですが、書いてみると、かえってその方が自分を判然《はっきり》描《えが》き出す事ができたような心持がして嬉《うれ》しいのです。私は酔興《すいきょう》に書くのではありません。私を生んだ私の過去は、人間の経験の一部分として、私より外《ほか》に誰も語り得るものはないのですから、それを偽《いつわ》りなく書き残して置く私の努力は、人間を知る上において、あなたにとっても、外の人にとっても、徒労ではなかろうと思います。渡辺華山《わたなべかざん》は邯鄲《かんたん》という画《え》を描《か》くために、死期を一週間繰り延べたという話をつい先達《せんだっ》て聞きました。他《ひと》から見たら余計な事のようにも解釈できましょうが、当人にはまた当人相応の要求が心の中《うち》にあるのだからやむをえないともいわれるでしょう。私の努力も単にあなたに対する約束を果たすためばかりではありません。半《なか》ば以上は自分自身の要求に動かされた結果なのです。しかし私は今その要求を果たしました。もう何にもする事はありません。この手紙があなたの手に落ちる頃《ころ》には、私はもうこの世にはいないでしょう。とくに死んでいるでしょう。妻は十日ばかり前から市ヶ谷《いちがや》の叔母《おば》の所へ行きました。叔母が病気で手が足りないというから私が勧めてやったのです。私は妻の留守の間《あいだ》に、この長いものの大部分を書きました。時々妻が帰って来ると、私はすぐそれを隠しました。私は私の過去を善悪ともに他《ひと》の参考に供するつもりです。しかし妻だけはたった一人の例外だと承知して下さい。私は妻には何にも知らせたくないのです。妻が己《おの》れの過去に対してもつ記憶を、なるべく純白に保存しておいてやりたいのが私の唯一《ゆいいつ》の希望なのですから、私が死んだ後《あと》でも、妻が生きている以上は、あなた限りに打ち明けられた私の秘密として、すべてを腹の中にしまっておいて下さい。」"
                };

                var wordNameEntryDtos = await _wordService.GetWords(request);




                return Ok(wordNameEntryDtos);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // GET: api/word
        [HttpPost]
        public async Task<IActionResult> GetWords([FromBody] Request request)
        {
            try
            {
                var wordNameEntryDtos = await _wordService.GetWords(request);

                return Ok(wordNameEntryDtos);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }


    }
}
