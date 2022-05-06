[YouTube Video](https://youtu.be/mbmprym9SDM)



[hello everyone welcome back](https://youtu.be/mbmprym9SDM?t=00h00m03s)

[uh tonight i'm going to go back to](https://youtu.be/mbmprym9SDM?t=00h00m05s)

[material design in xaml there's been a](https://youtu.be/mbmprym9SDM?t=00h00m07s)

[couple issues flagged uh recently and](https://youtu.be/mbmprym9SDM?t=00h00m08s)

[uh would like to work on trying to get a](https://youtu.be/mbmprym9SDM?t=00h00m12s)

[faster cadence and some automation and](https://youtu.be/mbmprym9SDM?t=00h00m14s)

[some stuff cleaned up so](https://youtu.be/mbmprym9SDM?t=00h00m15s)

[figured i would start there](https://youtu.be/mbmprym9SDM?t=00h00m17s)

[and we'll have some fun and see where it](https://youtu.be/mbmprym9SDM?t=00h00m20s)

[goes from there](https://youtu.be/mbmprym9SDM?t=00h00m22s)

[okay so the first one i wanted to](https://youtu.be/mbmprym9SDM?t=00h00m24s)

[drop in on was this one that showed up](https://youtu.be/mbmprym9SDM?t=00h00m28s)

[earlier today now](https://youtu.be/mbmprym9SDM?t=00h00m30s)

[this one this one kind of caught me off](https://youtu.be/mbmprym9SDM?t=00h00m32s)

[guard and i think i](https://youtu.be/mbmprym9SDM?t=00h00m34s)

[i don't remember if i streamed the work](https://youtu.be/mbmprym9SDM?t=00h00m36s)

[for this or not](https://youtu.be/mbmprym9SDM?t=00h00m37s)

[one second](https://youtu.be/mbmprym9SDM?t=00h00m39s)

[my](https://youtu.be/mbmprym9SDM?t=00h00m41s)

[my light is very very bright](https://youtu.be/mbmprym9SDM?t=00h00m42s)

[okay](https://youtu.be/mbmprym9SDM?t=00h00m45s)

[better now i'm not no i'm not just](https://youtu.be/mbmprym9SDM?t=00h00m47s)

[completely white it out](https://youtu.be/mbmprym9SDM?t=00h00m48s)

[uh okay so i had put in uh](https://youtu.be/mbmprym9SDM?t=00h00m51s)

[a little bit of code to support](https://youtu.be/mbmprym9SDM?t=00h00m55s)

[horizontal scroll inside of wpf this is](https://youtu.be/mbmprym9SDM?t=00h00m56s)

[something that is not enabled by default](https://youtu.be/mbmprym9SDM?t=00h00m59s)

[which can be a little bit obnoxious](https://youtu.be/mbmprym9SDM?t=00h01m01s)

[um and um](https://youtu.be/mbmprym9SDM?t=00h01m03s)

[the laxus i'm probably butchering that](https://youtu.be/mbmprym9SDM?t=00h01m06s)

[name i apologize um commented that using](https://youtu.be/mbmprym9SDM?t=00h01m08s)

[uh the logitech mx master three mouse](https://youtu.be/mbmprym9SDM?t=00h01m12s)

[with a horizontal scroll wheel which is](https://youtu.be/mbmprym9SDM?t=00h01m15s)

[a pretty cool thing ends up running into](https://youtu.be/mbmprym9SDM?t=00h01m17s)

[a problem here and i had initially asked](https://youtu.be/mbmprym9SDM?t=00h01m20s)

[for feedback on what the wpram was](https://youtu.be/mbmprym9SDM?t=00h01m23s)

[before i realized that it's](https://youtu.be/mbmprym9SDM?t=00h01m25s)

[it's kind of it's right there in front](https://youtu.be/mbmprym9SDM?t=00h01m28s)

[of me](https://youtu.be/mbmprym9SDM?t=00h01m29s)

[and](https://youtu.be/mbmprym9SDM?t=00h01m30s)

[this one actually took me a few minutes](https://youtu.be/mbmprym9SDM?t=00h01m32s)

[of staring at it before i figured out](https://youtu.be/mbmprym9SDM?t=00h01m33s)

[what the problem was](https://youtu.be/mbmprym9SDM?t=00h01m35s)

[so if it's not obvious to people](https://youtu.be/mbmprym9SDM?t=00h01m38s)

[let's walk let's walk through the report](https://youtu.be/mbmprym9SDM?t=00h01m40s)

[because i think there's there's enough](https://youtu.be/mbmprym9SDM?t=00h01m42s)

[here in order to to figure it out](https://youtu.be/mbmprym9SDM?t=00h01m43s)

[so](https://youtu.be/mbmprym9SDM?t=00h01m46s)

[um this is actually one of my favorite](https://youtu.be/mbmprym9SDM?t=00h01m47s)

[favorite things to do in the world is i](https://youtu.be/mbmprym9SDM?t=00h01m49s)

[i love when i am able to diagnose a](https://youtu.be/mbmprym9SDM?t=00h01m51s)

[problem without actually ever firing up](https://youtu.be/mbmprym9SDM?t=00h01m53s)

[a debugger um just from like exception](https://youtu.be/mbmprym9SDM?t=00h01m55s)

[stack traces and that kind of thing so i](https://youtu.be/mbmprym9SDM?t=00h01m58s)

[i love the mystery of it all it's like a](https://youtu.be/mbmprym9SDM?t=00h02m00s)

[good like sherlock holmes novel](https://youtu.be/mbmprym9SDM?t=00h02m03s)

[um so what we know we know that it](https://youtu.be/mbmprym9SDM?t=00h02m05s)

[through a system overflow exception](https://youtu.be/mbmprym9SDM?t=00h02m08s)

[and we know that there was an arithmetic](https://youtu.be/mbmprym9SDM?t=00h02m10s)

[operation that resulted in an overflow](https://youtu.be/mbmprym9SDM?t=00h02m13s)

[great](https://youtu.be/mbmprym9SDM?t=00h02m15s)

[um real quick for people who may not be](https://youtu.be/mbmprym9SDM?t=00h02m16s)

[familiar with the concept of what an](https://youtu.be/mbmprym9SDM?t=00h02m19s)

[overflow is](https://youtu.be/mbmprym9SDM?t=00h02m20s)

[quick demonstration](https://youtu.be/mbmprym9SDM?t=00h02m22s)

[so](https://youtu.be/mbmprym9SDM?t=00h02m24s)

[where'd he go come here come back](https://youtu.be/mbmprym9SDM?t=00h02m25s)

[so windows calculator](https://youtu.be/mbmprym9SDM?t=00h02m27s)

[if you go over and set it into](https://youtu.be/mbmprym9SDM?t=00h02m29s)

[programmer mode you get this pretty cool](https://youtu.be/mbmprym9SDM?t=00h02m31s)

[idea so let's just imagine that we have](https://youtu.be/mbmprym9SDM?t=00h02m33s)

[a simple number we're going to keep this](https://youtu.be/mbmprym9SDM?t=00h02m36s)

[at 255.](https://youtu.be/mbmprym9SDM?t=00h02m38s)

[so and you'll note down here it actually](https://youtu.be/mbmprym9SDM?t=00h02m40s)

[shows us the binary representation of](https://youtu.be/mbmprym9SDM?t=00h02m42s)

[255. so for my purposes we're just going](https://youtu.be/mbmprym9SDM?t=00h02m44s)

[to use the first eight bits](https://youtu.be/mbmprym9SDM?t=00h02m47s)

[this is pretty easy right if i turn this](https://youtu.be/mbmprym9SDM?t=00h02m49s)

[bit off it subtracts it by one and goes](https://youtu.be/mbmprym9SDM?t=00h02m51s)

[down to 254. if i turn this bit off it](https://youtu.be/mbmprym9SDM?t=00h02m53s)

[goes down by two if i turn this bit off](https://youtu.be/mbmprym9SDM?t=00h02m55s)

[it goes down by four](https://youtu.be/mbmprym9SDM?t=00h02m58s)

[not surprising this bit goes down by](https://youtu.be/mbmprym9SDM?t=00h03m00s)

[eight](https://youtu.be/mbmprym9SDM?t=00h03m01s)

[um and you can start to](https://youtu.be/mbmprym9SDM?t=00h03m02s)

[see and for people who may not be uh](https://youtu.be/mbmprym9SDM?t=00h03m04s)

[familiar with binary that's effectively](https://youtu.be/mbmprym9SDM?t=00h03m06s)

[how this works the first bit is worth](https://youtu.be/mbmprym9SDM?t=00h03m08s)

[one second one's two four eight sixteen](https://youtu.be/mbmprym9SDM?t=00h03m10s)

[etc all the way up so you just add up](https://youtu.be/mbmprym9SDM?t=00h03m13s)

[the the number of bits that are on and](https://youtu.be/mbmprym9SDM?t=00h03m15s)

[that's your decimal value which is great](https://youtu.be/mbmprym9SDM?t=00h03m18s)

[overflow occurs when you run out of bits](https://youtu.be/mbmprym9SDM?t=00h03m20s)

[and specifically when you run out of](https://youtu.be/mbmprym9SDM?t=00h03m24s)

[this issue of if i if i only have eight](https://youtu.be/mbmprym9SDM?t=00h03m26s)

[bits to work with and i add one to this](https://youtu.be/mbmprym9SDM?t=00h03m28s)

[and i go to](https://youtu.be/mbmprym9SDM?t=00h03m31s)

[say](https://youtu.be/mbmprym9SDM?t=00h03m33s)

[00:03:36,000 --> 00:03:40,560](https://youtu.be/mbmprym9SDM?t=00h03m34s)

you'll note i've now exceeded the number

[of bits i'm now using one more bit than](https://youtu.be/mbmprym9SDM?t=00h03m38s)

[what i had](https://youtu.be/mbmprym9SDM?t=00h03m40s)

[and mathematicians they can always add](https://youtu.be/mbmprym9SDM?t=00h03m42s)

[one to anything that's great computer](https://youtu.be/mbmprym9SDM?t=00h03m43s)

[scientist we can't always add one to](https://youtu.be/mbmprym9SDM?t=00h03m45s)

[everything we work with fixed number](https://youtu.be/mbmprym9SDM?t=00h03m47s)

[ranges so we only have eight bits to](https://youtu.be/mbmprym9SDM?t=00h03m48s)

[work with in order to get to the number](https://youtu.be/mbmprym9SDM?t=00h03m51s)

[256 we went over the top](https://youtu.be/mbmprym9SDM?t=00h03m53s)

[um and so this actually runs runs a muck](https://youtu.be/mbmprym9SDM?t=00h03m56s)

[of that kind of overflow of hey i don't](https://youtu.be/mbmprym9SDM?t=00h03m59s)

[have enough bits left over for what](https://youtu.be/mbmprym9SDM?t=00h04m02s)

[you're trying to do](https://youtu.be/mbmprym9SDM?t=00h04m03s)

[the interesting part though is if we](https://youtu.be/mbmprym9SDM?t=00h04m05s)

[look at this stack trace](https://youtu.be/mbmprym9SDM?t=00h04m06s)

[it shows that](https://youtu.be/mbmprym9SDM?t=00h04m09s)

[right here so this double](https://youtu.be/mbmprym9SDM?t=00h04m10s)

[alligator brace c double underscore](https://youtu.be/mbmprym9SDM?t=00h04m13s)

[whenever you see something like this in](https://youtu.be/mbmprym9SDM?t=00h04m15s)

[a stack trace look for something that's](https://youtu.be/mbmprym9SDM?t=00h04m16s)

[either a local function or a lambda](https://youtu.be/mbmprym9SDM?t=00h04m18s)

[and we can and the thing over here will](https://youtu.be/mbmprym9SDM?t=00h04m22s)

[tell you what function uh that that](https://youtu.be/mbmprym9SDM?t=00h04m24s)

[lambda or local function is inside of](https://youtu.be/mbmprym9SDM?t=00h04m28s)

[so in this case we know that we're](https://youtu.be/mbmprym9SDM?t=00h04m31s)

[inside of on support horizontal change](https://youtu.be/mbmprym9SDM?t=00h04m32s)

[and we are looking for some sort of](https://youtu.be/mbmprym9SDM?t=00h04m36s)

[lambda inside of there](https://youtu.be/mbmprym9SDM?t=00h04m38s)

[and if we look down here](https://youtu.be/mbmprym9SDM?t=00h04m40s)

[uh he was kind enough to include the](https://youtu.be/mbmprym9SDM?t=00h04m43s)

[external code which i'm guessing means](https://youtu.be/mbmprym9SDM?t=00h04m45s)

[uh source link is working appropriately](https://youtu.be/mbmprym9SDM?t=00h04m47s)

[and we can see here that okay](https://youtu.be/mbmprym9SDM?t=00h04m51s)

[if we](https://youtu.be/mbmprym9SDM?t=00h04m53s)

[find](https://youtu.be/mbmprym9SDM?t=00h04m54s)

[where was it](https://youtu.be/mbmprym9SDM?t=00h04m56s)

[we find on support horizontal change](https://youtu.be/mbmprym9SDM?t=00h04m58s)

[let's actually we're going to jump here](https://youtu.be/mbmprym9SDM?t=00h05m01s)

[we'll go into the we'll go into the](https://youtu.be/mbmprym9SDM?t=00h05m03s)

[actual source code rather than the](https://youtu.be/mbmprym9SDM?t=00h05m05s)

[decompiled source just make sure it](https://youtu.be/mbmprym9SDM?t=00h05m06s)

[looks right](https://youtu.be/mbmprym9SDM?t=00h05m07s)

[so inside here we can see that we are](https://youtu.be/mbmprym9SDM?t=00h05m08s)

[going to be inside of one of these one](https://youtu.be/mbmprym9SDM?t=00h05m10s)

[of these lambdas](https://youtu.be/mbmprym9SDM?t=00h05m13s)

[and inside of here we can see that](https://youtu.be/mbmprym9SDM?t=00h05m15s)

[there's only there's only a couple](https://youtu.be/mbmprym9SDM?t=00h05m16s)

[things and it gets a little confusing](https://youtu.be/mbmprym9SDM?t=00h05m18s)

[because we have a local function](https://youtu.be/mbmprym9SDM?t=00h05m19s)

[and multiple lambdas so we've got a](https://youtu.be/mbmprym9SDM?t=00h05m22s)

[lambda here local function of location](https://youtu.be/mbmprym9SDM?t=00h05m25s)

[local function invocation lambda](https://youtu.be/mbmprym9SDM?t=00h05m27s)

[right there and there great great](https://youtu.be/mbmprym9SDM?t=00h05m30s)

[um and then inside of here just to make](https://youtu.be/mbmprym9SDM?t=00h05m32s)

[things a little more confusing](https://youtu.be/mbmprym9SDM?t=00h05m35s)

[sup robert yep more wpf](https://youtu.be/mbmprym9SDM?t=00h05m37s)

[uh we have](https://youtu.be/mbmprym9SDM?t=00h05m39s)

[this local function registering for an](https://youtu.be/mbmprym9SDM?t=00h05m41s)

[event which is another local function](https://youtu.be/mbmprym9SDM?t=00h05m43s)

[callback](https://youtu.be/mbmprym9SDM?t=00h05m45s)

[inside of here which is then itself yet](https://youtu.be/mbmprym9SDM?t=00h05m46s)

[one more local function all the way to](https://youtu.be/mbmprym9SDM?t=00h05m49s)

[get us into into here](https://youtu.be/mbmprym9SDM?t=00h05m51s)

[now we can we could go through and look](https://youtu.be/mbmprym9SDM?t=00h05m53s)

[at like the decompiled source to figure](https://youtu.be/mbmprym9SDM?t=00h05m55s)

[out which one of those local functions](https://youtu.be/mbmprym9SDM?t=00h05m56s)

[was](https://youtu.be/mbmprym9SDM?t=00h05m58s)

[double uh alligator brace c double](https://youtu.be/mbmprym9SDM?t=00h05m59s)

[underscore display class 18 underscore](https://youtu.be/mbmprym9SDM?t=00h06m01s)

[one](https://youtu.be/mbmprym9SDM?t=00h06m04s)

[or we could look at the next line of the](https://youtu.be/mbmprym9SDM?t=00h06m05s)

[stack trace and know well it has to be](https://youtu.be/mbmprym9SDM?t=00h06m07s)

[the one that contains a call to imp](https://youtu.be/mbmprym9SDM?t=00h06m09s)

[pointer to in 32.](https://youtu.be/mbmprym9SDM?t=00h06m11s)

[so we look in here the only call](https://youtu.be/mbmprym9SDM?t=00h06m14s)

[to in 32](https://youtu.be/mbmprym9SDM?t=00h06m17s)

[is right there](https://youtu.be/mbmprym9SDM?t=00h06m19s)

[so that kind of narrows down which of](https://youtu.be/mbmprym9SDM?t=00h06m21s)

[our local functions we're interested in](https://youtu.be/mbmprym9SDM?t=00h06m22s)

[and we know that this guy caused an](https://youtu.be/mbmprym9SDM?t=00h06m24s)

[overflow and you know this code here is](https://youtu.be/mbmprym9SDM?t=00h06m26s)

[slightly different](https://youtu.be/mbmprym9SDM?t=00h06m29s)

[than the code shown here](https://youtu.be/mbmprym9SDM?t=00h06m32s)

[um this looks like uh](https://youtu.be/mbmprym9SDM?t=00h06m36s)

[uh jetbrains is writer to me and writer](https://youtu.be/mbmprym9SDM?t=00h06m38s)

[is hopefully showing you the decompiled](https://youtu.be/mbmprym9SDM?t=00h06m42s)

[source](https://youtu.be/mbmprym9SDM?t=00h06m44s)

[which is a little bit more verbose than](https://youtu.be/mbmprym9SDM?t=00h06m45s)

[than what may have originally been](https://youtu.be/mbmprym9SDM?t=00h06m48s)

[written](https://youtu.be/mbmprym9SDM?t=00h06m49s)

[d compilers always have to kind of guess](https://youtu.be/mbmprym9SDM?t=00h06m52s)

[um](https://youtu.be/mbmprym9SDM?t=00h06m55s)

[to reverse engineer what the original](https://youtu.be/mbmprym9SDM?t=00h06m57s)

[code was there because it's it's not a](https://youtu.be/mbmprym9SDM?t=00h06m58s)

[two-way street](https://youtu.be/mbmprym9SDM?t=00h07m00s)

[so you can see here it is taking wp per](https://youtu.be/mbmprym9SDM?t=00h07m02s)

[am and](https://youtu.be/mbmprym9SDM?t=00h07m06s)

[right shifting 16 bits which lines up](https://youtu.be/mbmprym9SDM?t=00h07m07s)

[with what we have here but then you'll](https://youtu.be/mbmprym9SDM?t=00h07m10s)

[note we've got some extra parents here](https://youtu.be/mbmprym9SDM?t=00h07m11s)

[that help make things a little more](https://youtu.be/mbmprym9SDM?t=00h07m13s)

[apparent in the code](https://youtu.be/mbmprym9SDM?t=00h07m15s)

[we've got this little doohickey here](https://youtu.be/mbmprym9SDM?t=00h07m17s)

[that we're anding it against](https://youtu.be/mbmprym9SDM?t=00h07m19s)

[uh and then we're casting it back to a](https://youtu.be/mbmprym9SDM?t=00h07m21s)

[short](https://youtu.be/mbmprym9SDM?t=00h07m23s)

[and that gets then up cast into an int](https://youtu.be/mbmprym9SDM?t=00h07m24s)

[so](https://youtu.be/mbmprym9SDM?t=00h07m28s)

[what this is effectively doing is an n32](https://youtu.be/mbmprym9SDM?t=00h07m29s)

[is 32 bits wide](https://youtu.be/mbmprym9SDM?t=00h07m33s)

[we're shifting to the left 16 bits](https://youtu.be/mbmprym9SDM?t=00h07m34s)

[leaving us uh with only zeros in the](https://youtu.be/mbmprym9SDM?t=00h07m38s)

[upper 16 bits and values in the lower](https://youtu.be/mbmprym9SDM?t=00h07m41s)

[16.](https://youtu.be/mbmprym9SDM?t=00h07m44s)

[then we are adding them together to make](https://youtu.be/mbmprym9SDM?t=00h07m45s)

[sure that uh](https://youtu.be/mbmprym9SDM?t=00h07m47s)

[whatever was up there is trimmed off and](https://youtu.be/mbmprym9SDM?t=00h07m49s)

[we are just the size of a short](https://youtu.be/mbmprym9SDM?t=00h07m51s)

[and then we up cast that short into an](https://youtu.be/mbmprym9SDM?t=00h07m53s)

[int](https://youtu.be/mbmprym9SDM?t=00h07m56s)

[and this is where the problems come](https://youtu.be/mbmprym9SDM?t=00h07m57s)

[so specifically what's biting us is this](https://youtu.be/mbmprym9SDM?t=00h08m00s)

[call to in 2 in 32 we haven't even](https://youtu.be/mbmprym9SDM?t=00h08m02s)

[gotten to the rest of this mess yet](https://youtu.be/mbmprym9SDM?t=00h08m05s)

[but what's happening if we look at the](https://youtu.be/mbmprym9SDM?t=00h08m07s)

[screenshot](https://youtu.be/mbmprym9SDM?t=00h08m10s)

[if we see this guy here this value 0x ff](https://youtu.be/mbmprym9SDM?t=00h08m12s)

[e2 0 000](https://youtu.be/mbmprym9SDM?t=00h08m16s)

[we can look at what would so if we just](https://youtu.be/mbmprym9SDM?t=00h08m19s)

[if we just cheat for a moment and go int](https://youtu.be/mbmprym9SDM?t=00h08m22s)

[w gets 0x](https://youtu.be/mbmprym9SDM?t=00h08m24s)

[ff](https://youtu.be/mbmprym9SDM?t=00h08m27s)

[e 2](https://youtu.be/mbmprym9SDM?t=00h08m29s)

[1 2 3 4.](https://youtu.be/mbmprym9SDM?t=00h08m32s)

[you'll note we immediately get a compile](https://youtu.be/mbmprym9SDM?t=00h08m34s)

[error](https://youtu.be/mbmprym9SDM?t=00h08m36s)

[because it's it's acknowledging that](https://youtu.be/mbmprym9SDM?t=00h08m37s)

[this number is too big to be an int](https://youtu.be/mbmprym9SDM?t=00h08m39s)

[that's kind of unfortunate](https://youtu.be/mbmprym9SDM?t=00h08m44s)

[um and the reason this happens is](https://youtu.be/mbmprym9SDM?t=00h08m46s)

[because of something called two's](https://youtu.be/mbmprym9SDM?t=00h08m49s)

[complement](https://youtu.be/mbmprym9SDM?t=00h08m50s)

[compliment](https://youtu.be/mbmprym9SDM?t=00h08m54s)

[binary probably should have found a](https://youtu.be/mbmprym9SDM?t=00h08m57s)

[reasonable explanation to choose](https://youtu.be/mbmprym9SDM?t=00h08m59s)

[compliment here](https://youtu.be/mbmprym9SDM?t=00h09m00s)

[this is this one here is probably good](https://youtu.be/mbmprym9SDM?t=00h09m06s)

[enough so here let me move this let me](https://youtu.be/mbmprym9SDM?t=00h09m08s)

[move let me bring wikipedia over to the](https://youtu.be/mbmprym9SDM?t=00h09m10s)

[middle](https://youtu.be/mbmprym9SDM?t=00h09m12s)

[so the idea with uh two's complement so](https://youtu.be/mbmprym9SDM?t=00h09m13s)

[we're gonna we're gonna pretend like](https://youtu.be/mbmprym9SDM?t=00h09m16s)

[we're only playing with three bits here](https://youtu.be/mbmprym9SDM?t=00h09m17s)

[just to keep the math symbol](https://youtu.be/mbmprym9SDM?t=00h09m19s)

[so um is when you're working](https://youtu.be/mbmprym9SDM?t=00h09m22s)

[in binary numbers computers speak ones](https://youtu.be/mbmprym9SDM?t=00h09m25s)

[and zeros](https://youtu.be/mbmprym9SDM?t=00h09m27s)

[that's that's effectively what they know](https://youtu.be/mbmprym9SDM?t=00h09m28s)

[and the problem is if you want to](https://youtu.be/mbmprym9SDM?t=00h09m31s)

[represent negative numbers you have to](https://youtu.be/mbmprym9SDM?t=00h09m32s)

[have some way to indicate an uh a minus](https://youtu.be/mbmprym9SDM?t=00h09m34s)

[sign just fine](https://youtu.be/mbmprym9SDM?t=00h09m37s)

[the the issue being that this minus sign](https://youtu.be/mbmprym9SDM?t=00h09m39s)

[here](https://youtu.be/mbmprym9SDM?t=00h09m42s)

[uh if you just took one of your bits and](https://youtu.be/mbmprym9SDM?t=00h09m43s)

[said okay if that bit is a one it'll be](https://youtu.be/mbmprym9SDM?t=00h09m46s)

[a negative if it's a 0 it'll be a](https://youtu.be/mbmprym9SDM?t=00h09m48s)

[positive](https://youtu.be/mbmprym9SDM?t=00h09m50s)

[the the issue there is then you end up](https://youtu.be/mbmprym9SDM?t=00h09m51s)

[wasting a little bit because then you](https://youtu.be/mbmprym9SDM?t=00h09m53s)

[have with that representation](https://youtu.be/mbmprym9SDM?t=00h09m55s)

[both a positive and a negative 0.](https://youtu.be/mbmprym9SDM?t=00h09m57s)

[with 2's complement what we end up doing](https://youtu.be/mbmprym9SDM?t=00h10m01s)

[is a little bit of math in order to](https://youtu.be/mbmprym9SDM?t=00h10m03s)

[flip uh](https://youtu.be/mbmprym9SDM?t=00h10m07s)

[flip it so that there is only one](https://youtu.be/mbmprym9SDM?t=00h10m08s)

[representation of zero so you'll note](https://youtu.be/mbmprym9SDM?t=00h10m10s)

[here with three bits](https://youtu.be/mbmprym9SDM?t=00h10m12s)

[we're able to represent all of the](https://youtu.be/mbmprym9SDM?t=00h10m14s)

[numbers from zero to seven so eight](https://youtu.be/mbmprym9SDM?t=00h10m15s)

[possible numbers here](https://youtu.be/mbmprym9SDM?t=00h10m18s)

[and if we used one of these bits for a](https://youtu.be/mbmprym9SDM?t=00h10m20s)

[positive and a negative we would then](https://youtu.be/mbmprym9SDM?t=00h10m22s)

[cut the number of values we were able uh](https://youtu.be/mbmprym9SDM?t=00h10m24s)

[to display in half because one of those](https://youtu.be/mbmprym9SDM?t=00h10m27s)

[bits would be used for the](https://youtu.be/mbmprym9SDM?t=00h10m29s)

[um the negative sign](https://youtu.be/mbmprym9SDM?t=00h10m30s)

[with two's complement we're actually](https://youtu.be/mbmprym9SDM?t=00h10m33s)

[still able to represent seven numbers](https://youtu.be/mbmprym9SDM?t=00h10m35s)

[it's just that we're going to give plus](https://youtu.be/mbmprym9SDM?t=00h10m38s)

[one uh negative values all the way down](https://youtu.be/mbmprym9SDM?t=00h10m40s)

[so](https://youtu.be/mbmprym9SDM?t=00h10m42s)

[i won't bore people with the math behind](https://youtu.be/mbmprym9SDM?t=00h10m43s)

[it but that it that is the rationale of](https://youtu.be/mbmprym9SDM?t=00h10m46s)

[how this works](https://youtu.be/mbmprym9SDM?t=00h10m48s)

[because of that it means that there are](https://youtu.be/mbmprym9SDM?t=00h10m50s)

[certain values in binary which is](https://youtu.be/mbmprym9SDM?t=00h10m52s)

[effectively what we're getting when we](https://youtu.be/mbmprym9SDM?t=00h10m55s)

[look at this thing in hex](https://youtu.be/mbmprym9SDM?t=00h10m56s)

[um you'll know the the windows](https://youtu.be/mbmprym9SDM?t=00h10m58s)

[calculator is actually rather nice and](https://youtu.be/mbmprym9SDM?t=00h11m00s)

[actually we can do this uh ff e2 so](https://youtu.be/mbmprym9SDM?t=00h11m02s)

[let's just ignore the bottom bits](https://youtu.be/mbmprym9SDM?t=00h11m05s)

[because we really don't care about them](https://youtu.be/mbmprym9SDM?t=00h11m07s)

[so pretend and this will be a short not](https://youtu.be/mbmprym9SDM?t=00h11m09s)

[an int should have the same problem](https://youtu.be/mbmprym9SDM?t=00h11m12s)

[so if i go hex i can type in ff](https://youtu.be/mbmprym9SDM?t=00h11m17s)

[e2](https://youtu.be/mbmprym9SDM?t=00h11m21s)

[and we can see](https://youtu.be/mbmprym9SDM?t=00h11m23s)

[what all of these](https://youtu.be/mbmprym9SDM?t=00h11m24s)

[bits end up looking like so with](https://youtu.be/mbmprym9SDM?t=00h11m26s)

[uh in binary](https://youtu.be/mbmprym9SDM?t=00h11m29s)

[when you're displaying things in hex](https://youtu.be/mbmprym9SDM?t=00h11m31s)

[uh every two digits of hex](https://youtu.be/mbmprym9SDM?t=00h11m34s)

[is eight bits worth of binary](https://youtu.be/mbmprym9SDM?t=00h11m36s)

[so we have four digits in hex that is 16](https://youtu.be/mbmprym9SDM?t=00h11m41s)

[bits in binder](https://youtu.be/mbmprym9SDM?t=00h11m44s)

[and what we're trying to do is just](https://youtu.be/mbmprym9SDM?t=00h11m47s)

[shift these 16 bits over and only](https://youtu.be/mbmprym9SDM?t=00h11m49s)

[extract those those parts out](https://youtu.be/mbmprym9SDM?t=00h11m51s)

[and the problem is is in our attempt to](https://youtu.be/mbmprym9SDM?t=00h11m54s)

[do that this guy ends up throwing an](https://youtu.be/mbmprym9SDM?t=00h11m56s)

[exception and we can see here if we](https://youtu.be/mbmprym9SDM?t=00h11m58s)

[hover on this thing this thing says](https://youtu.be/mbmprym9SDM?t=00h11m59s)

[overflow exceptions like oh okay let's](https://youtu.be/mbmprym9SDM?t=00h12m01s)

[take a let's take a quick look at what](https://youtu.be/mbmprym9SDM?t=00h12m03s)

[that is](https://youtu.be/mbmprym9SDM?t=00h12m05s)

[we look down here system overflow](https://youtu.be/mbmprym9SDM?t=00h12m08s)

[exception on a 64-bit platform the value](https://youtu.be/mbmprym9SDM?t=00h12m10s)

[of this instance is too large or too](https://youtu.be/mbmprym9SDM?t=00h12m14s)

[small to be represented as a 32-bit](https://youtu.be/mbmprym9SDM?t=00h12m16s)

[signed integer](https://youtu.be/mbmprym9SDM?t=00h12m19s)

[so](https://youtu.be/mbmprym9SDM?t=00h12m21s)

[unfortunately](https://youtu.be/mbmprym9SDM?t=00h12m22s)

[in my testing i never ran into this](https://youtu.be/mbmprym9SDM?t=00h12m23s)

[but apparently](https://youtu.be/mbmprym9SDM?t=00h12m26s)

[on some systems this w param that comes](https://youtu.be/mbmprym9SDM?t=00h12m28s)

[in](https://youtu.be/mbmprym9SDM?t=00h12m31s)

[can exist as a number bigger than what](https://youtu.be/mbmprym9SDM?t=00h12m32s)

[can fit inside of a](https://youtu.be/mbmprym9SDM?t=00h12m35s)

[assigned or two's complement binary](https://youtu.be/mbmprym9SDM?t=00h12m39s)

[number](https://youtu.be/mbmprym9SDM?t=00h12m41s)

[so because of that](https://youtu.be/mbmprym9SDM?t=00h12m43s)

[we need to](https://youtu.be/mbmprym9SDM?t=00h12m45s)

[appropriately handle that and in this](https://youtu.be/mbmprym9SDM?t=00h12m46s)

[case it's going to be simple it's going](https://youtu.be/mbmprym9SDM?t=00h12m48s)

[to be we're just going to use extra bits](https://youtu.be/mbmprym9SDM?t=00h12m49s)

[i think that's the easiest](https://youtu.be/mbmprym9SDM?t=00h12m53s)

[um and](https://youtu.be/mbmprym9SDM?t=00h12m56s)

[actually real quick before we before we](https://youtu.be/mbmprym9SDM?t=00h12m57s)

[get too carried away let's write a quick](https://youtu.be/mbmprym9SDM?t=00h12m59s)

[test](https://youtu.be/mbmprym9SDM?t=00h13m00s)

[i think i think we can test this](https://youtu.be/mbmprym9SDM?t=00h13m02s)

[i think this is uh](https://youtu.be/mbmprym9SDM?t=00h13m04s)

[i don't know where i'm gonna put this so](https://youtu.be/mbmprym9SDM?t=00h13m06s)

[i'm just gonna put it here](https://youtu.be/mbmprym9SDM?t=00h13m07s)

[uh let's see so this will be](https://youtu.be/mbmprym9SDM?t=00h13m10s)

[fact](https://youtu.be/mbmprym9SDM?t=00h13m12s)

[uh let's see](https://youtu.be/mbmprym9SDM?t=00h13m14s)

[public void test numbers](https://youtu.be/mbmprym9SDM?t=00h13m15s)

[so we're gonna because it's really hard](https://youtu.be/mbmprym9SDM?t=00h13m18s)

[to actually test](https://youtu.be/mbmprym9SDM?t=00h13m20s)

[a callback from a uh a windproc function](https://youtu.be/mbmprym9SDM?t=00h13m22s)

[rather than going to the effort of](https://youtu.be/mbmprym9SDM?t=00h13m27s)

[trying to hook this and and do all of](https://youtu.be/mbmprym9SDM?t=00h13m28s)

[that stuff](https://youtu.be/mbmprym9SDM?t=00h13m31s)

[we're just gonna test this here](https://youtu.be/mbmprym9SDM?t=00h13m33s)

[okay so first thing we need is an int](https://youtu.be/mbmprym9SDM?t=00h13m36s)

[pointer](https://youtu.be/mbmprym9SDM?t=00h13m38s)

[uh ptr gets new](https://youtu.be/mbmprym9SDM?t=00h13m39s)

[and pointer](https://youtu.be/mbmprym9SDM?t=00h13m42s)

[will you let me initialize you with an](https://youtu.be/mbmprym9SDM?t=00h13m43s)

[in value](https://youtu.be/mbmprym9SDM?t=00h13m45s)

[ah you'll let me initialize you with a](https://youtu.be/mbmprym9SDM?t=00h13m46s)

[long value that'll work](https://youtu.be/mbmprym9SDM?t=00h13m48s)

[zero x f](https://youtu.be/mbmprym9SDM?t=00h13m50s)

[e](https://youtu.be/mbmprym9SDM?t=00h13m52s)

[two](https://youtu.be/mbmprym9SDM?t=00h13m53s)

[one two three four](https://youtu.be/mbmprym9SDM?t=00h13m54s)

[l](https://youtu.be/mbmprym9SDM?t=00h13m56s)

[so the l here um allows us if we if we](https://youtu.be/mbmprym9SDM?t=00h13m57s)

[leave the l off](https://youtu.be/mbmprym9SDM?t=00h14m01s)

[the compiler wants to interpret this as](https://youtu.be/mbmprym9SDM?t=00h14m02s)

[a oh it'll figure it out](https://youtu.be/mbmprym9SDM?t=00h14m04s)

[oh it figured out that it was an](https://youtu.be/mbmprym9SDM?t=00h14m06s)

[unsigned integer perfect](https://youtu.be/mbmprym9SDM?t=00h14m08s)

[perfect](https://youtu.be/mbmprym9SDM?t=00h14m10s)

[yeah and it ended up calling it a long](https://youtu.be/mbmprym9SDM?t=00h14m12s)

[so that'll work](https://youtu.be/mbmprym9SDM?t=00h14m15s)

[so even though i'm able to type this](https://youtu.be/mbmprym9SDM?t=00h14m16s)

[here just be aware that this is now](https://youtu.be/mbmprym9SDM?t=00h14m18s)

[invoking the long overload](https://youtu.be/mbmprym9SDM?t=00h14m20s)

[and it's when i hover on it it is](https://youtu.be/mbmprym9SDM?t=00h14m23s)

[showing it as a u in 32. so](https://youtu.be/mbmprym9SDM?t=00h14m25s)

[unsigned just calling back to the the](https://youtu.be/mbmprym9SDM?t=00h14m28s)

[two's complement if you were to deal](https://youtu.be/mbmprym9SDM?t=00h14m31s)

[with if binary is unsigned it](https://youtu.be/mbmprym9SDM?t=00h14m33s)

[effectively means you you ignore](https://youtu.be/mbmprym9SDM?t=00h14m36s)

[negative values those don't exist and](https://youtu.be/mbmprym9SDM?t=00h14m38s)

[you just do straight counting in binary](https://youtu.be/mbmprym9SDM?t=00h14m40s)

[unsigned is easy to work with](https://youtu.be/mbmprym9SDM?t=00h14m43s)

[at least binary-wise okay and then what](https://youtu.be/mbmprym9SDM?t=00h14m46s)

[we want to do is we want to do just this](https://youtu.be/mbmprym9SDM?t=00h14m49s)

[maneuver here](https://youtu.be/mbmprym9SDM?t=00h14m51s)

[right](https://youtu.be/mbmprym9SDM?t=00h14m53s)

[so](https://youtu.be/mbmprym9SDM?t=00h14m54s)

[when that value comes through we want](https://youtu.be/mbmprym9SDM?t=00h14m55s)

[ptr 2 and 32 blah blah blah blah blah](https://youtu.be/mbmprym9SDM?t=00h14m58s)

[we want uh so let's see we expect tilt](https://youtu.be/mbmprym9SDM?t=00h15m02s)

[to be equal to](https://youtu.be/mbmprym9SDM?t=00h15m05s)

[uh zero](https://youtu.be/mbmprym9SDM?t=00h15m08s)

[x](https://youtu.be/mbmprym9SDM?t=00h15m10s)

[f f](https://youtu.be/mbmprym9SDM?t=00h15m11s)

[e](https://youtu.be/mbmprym9SDM?t=00h15m12s)

[2. and to be clear just be because this](https://youtu.be/mbmprym9SDM?t=00h15m13s)

[is an int](https://youtu.be/mbmprym9SDM?t=00h15m16s)

[preceding zeros right so we can we can](https://youtu.be/mbmprym9SDM?t=00h15m18s)

[break this up like this](https://youtu.be/mbmprym9SDM?t=00h15m20s)

[just to make that look a little easier](https://youtu.be/mbmprym9SDM?t=00h15m21s)

[and then](https://youtu.be/mbmprym9SDM?t=00h15m24s)

[tilt](https://youtu.be/mbmprym9SDM?t=00h15m25s)

[right so this is this is the test we](https://youtu.be/mbmprym9SDM?t=00h15m27s)

[expect to pass and right now i would](https://youtu.be/mbmprym9SDM?t=00h15m29s)

[expect this thing to get](https://youtu.be/mbmprym9SDM?t=00h15m30s)

[the same overflow exception](https://youtu.be/mbmprym9SDM?t=00h15m33s)

[sorry i changed branches right before](https://youtu.be/mbmprym9SDM?t=00h15m40s)

[starting the stream and so i'm](https://youtu.be/mbmprym9SDM?t=00h15m41s)

[almost assuredly in a situation where it](https://youtu.be/mbmprym9SDM?t=00h15m44s)

[is going to](https://youtu.be/mbmprym9SDM?t=00h15m46s)

[go crazy where's my test when you go](https://youtu.be/mbmprym9SDM?t=00h15m48s)

[there you are come back](https://youtu.be/mbmprym9SDM?t=00h15m49s)

[uh you sit there](https://youtu.be/mbmprym9SDM?t=00h15m51s)

[sit there and be happy run the test](https://youtu.be/mbmprym9SDM?t=00h15m53s)

[okay so it ran the test](https://youtu.be/mbmprym9SDM?t=00h16m02s)

[what did it run it under](https://youtu.be/mbmprym9SDM?t=00h16m04s)

[i'd like to see the output okay so](https://youtu.be/mbmprym9SDM?t=00h16m07s)

[system overflow exception](https://youtu.be/mbmprym9SDM?t=00h16m09s)

[so perfect problem replicated i believe](https://youtu.be/mbmprym9SDM?t=00h16m11s)

[the simple fix here](https://youtu.be/mbmprym9SDM?t=00h16m15s)

[is we just convert this to an n64 and](https://youtu.be/mbmprym9SDM?t=00h16m16s)

[then everything should work so we're](https://youtu.be/mbmprym9SDM?t=00h16m19s)

[going to shift it down 16 bits we're](https://youtu.be/mbmprym9SDM?t=00h16m22s)

[going to still strip everything else off](https://youtu.be/mbmprym9SDM?t=00h16m24s)

[and i think it works](https://youtu.be/mbmprym9SDM?t=00h16m29s)

[but](https://youtu.be/mbmprym9SDM?t=00h16m32s)

[this is why we write a test](https://youtu.be/mbmprym9SDM?t=00h16m33s)

[because now when it tries to convert the](https://youtu.be/mbmprym9SDM?t=00h16m37s)

[pointer to a numeric value](https://youtu.be/mbmprym9SDM?t=00h16m39s)

[it will end up with](https://youtu.be/mbmprym9SDM?t=00h16m41s)

[extra bits](https://youtu.be/mbmprym9SDM?t=00h16m45s)

[let's see](https://youtu.be/mbmprym9SDM?t=00h16m46s)

[uh](https://youtu.be/mbmprym9SDM?t=00h16m51s)

[this is interesting it's blowing up on](https://youtu.be/mbmprym9SDM?t=00h16m55s)

[the constructor before it even gets to](https://youtu.be/mbmprym9SDM?t=00h16m57s)

[me](https://youtu.be/mbmprym9SDM?t=00h16m58s)

[what](https://youtu.be/mbmprym9SDM?t=00h17m01s)

[you're telling me i can't instantiate](https://youtu.be/mbmprym9SDM?t=00h17m03s)

[something as big as what i'm being given](https://youtu.be/mbmprym9SDM?t=00h17m05s)

[[Music]](https://youtu.be/mbmprym9SDM?t=00h17m10s)

[[Laughter]](https://youtu.be/mbmprym9SDM?t=00h17m12s)

[love it](https://youtu.be/mbmprym9SDM?t=00h17m18s)

[love it](https://youtu.be/mbmprym9SDM?t=00h17m19s)

[so](https://youtu.be/mbmprym9SDM?t=00h17m20s)

[that is epic](https://youtu.be/mbmprym9SDM?t=00h17m25s)

[that is epic you can't actually](https://youtu.be/mbmprym9SDM?t=00h17m29s)

[instantiate an end pointer with that](https://youtu.be/mbmprym9SDM?t=00h17m33s)

[value](https://youtu.be/mbmprym9SDM?t=00h17m35s)

[well then](https://youtu.be/mbmprym9SDM?t=00h17m38s)

[that's exciting](https://youtu.be/mbmprym9SDM?t=00h17m39s)

[so](https://youtu.be/mbmprym9SDM?t=00h17m41s)

[unsafe](https://youtu.be/mbmprym9SDM?t=00h17m44s)

[uh](https://youtu.be/mbmprym9SDM?t=00h17m47s)

[let's see here how do i get that into a](https://youtu.be/mbmprym9SDM?t=00h17m48s)

[void pointer](https://youtu.be/mbmprym9SDM?t=00h17m51s)

[uh let's see](https://youtu.be/mbmprym9SDM?t=00h17m53s)

[fixed](https://youtu.be/mbmprym9SDM?t=00h17m55s)

[void star](https://youtu.be/mbmprym9SDM?t=00h17m57s)

[uh boo gets i don't think that quite](https://youtu.be/mbmprym9SDM?t=00h17m59s)

[works because in order to get a pointer](https://youtu.be/mbmprym9SDM?t=00h18m02s)

[to it i have to get it onto the stack](https://youtu.be/mbmprym9SDM?t=00h18m04s)

[let's just bring you up real quick](https://youtu.be/mbmprym9SDM?t=00h18m08s)

[uh let's see](https://youtu.be/mbmprym9SDM?t=00h18m11s)

[object](https://youtu.be/mbmprym9SDM?t=00h18m13s)

[box gets](https://youtu.be/mbmprym9SDM?t=00h18m16s)

[i think this works](https://youtu.be/mbmprym9SDM?t=00h18m22s)

[uh](https://youtu.be/mbmprym9SDM?t=00h18m29s)

[that'll get me into there](https://youtu.be/mbmprym9SDM?t=00h18m31s)

[uh](https://youtu.be/mbmprym9SDM?t=00h18m34s)

[what is your problem](https://youtu.be/mbmprym9SDM?t=00h18m39s)

[unsafe code may only appear if complying](https://youtu.be/mbmprym9SDM?t=00h18m42s)

[with okay you are quickly becoming a](https://youtu.be/mbmprym9SDM?t=00h18m44s)

[pain in the neck](https://youtu.be/mbmprym9SDM?t=00h18m46s)

[uh](https://youtu.be/mbmprym9SDM?t=00h18m48s)

[what's the flag for unsafe](https://youtu.be/mbmprym9SDM?t=00h18m49s)

[i would like to turn unsafe code on](https://youtu.be/mbmprym9SDM?t=00h18m52s)

[pretty please](https://youtu.be/mbmprym9SDM?t=00h18m54s)

[uh](https://youtu.be/mbmprym9SDM?t=00h18m56s)

[something about build](https://youtu.be/mbmprym9SDM?t=00h18m57s)

[boom](https://youtu.be/mbmprym9SDM?t=00h19m01s)

[turn on unsafe](https://youtu.be/mbmprym9SDM?t=00h19m02s)

[as the name implies it allows you to do](https://youtu.be/mbmprym9SDM?t=00h19m04s)

[unsafe things](https://youtu.be/mbmprym9SDM?t=00h19m06s)

[okay so that fixes problem one uh](https://youtu.be/mbmprym9SDM?t=00h19m07s)

[can i just cast you](https://youtu.be/mbmprym9SDM?t=00h19m15s)

[uh](https://youtu.be/mbmprym9SDM?t=00h19m18s)

[okay i can't remember i do this so](https://youtu.be/mbmprym9SDM?t=00h19m21s)

[infrequently c sharp](https://youtu.be/mbmprym9SDM?t=00h19m24s)

[uh](https://youtu.be/mbmprym9SDM?t=00h19m26s)

[convert long to](https://youtu.be/mbmprym9SDM?t=00h19m27s)

[void pointer](https://youtu.be/mbmprym9SDM?t=00h19m30s)

[uh](https://youtu.be/mbmprym9SDM?t=00h19m33s)

[just want to](https://youtu.be/mbmprym9SDM?t=00h19m37s)

[yes](https://youtu.be/mbmprym9SDM?t=00h19m40s)

[type identifier void identifier](https://youtu.be/mbmprym9SDM?t=00h19m42s)

[blah blah blah blah blah blah blah blah](https://youtu.be/mbmprym9SDM?t=00h19m44s)

[i just want to point you at a thing](https://youtu.be/mbmprym9SDM?t=00h19m47s)

[oh oh address of that's right](https://youtu.be/mbmprym9SDM?t=00h19m51s)

[that's right](https://youtu.be/mbmprym9SDM?t=00h19m55s)

[something more akin to that](https://youtu.be/mbmprym9SDM?t=00h19m57s)

[um](https://youtu.be/mbmprym9SDM?t=00h20m03s)

[managed object type](https://youtu.be/mbmprym9SDM?t=00h20m04s)

[can i get away with](https://youtu.be/mbmprym9SDM?t=00h20m07s)

[that](https://youtu.be/mbmprym9SDM?t=00h20m09s)

[i cannot take the address i would give](https://youtu.be/mbmprym9SDM?t=00h20m11s)

[an expression uh there's a grumble](https://youtu.be/mbmprym9SDM?t=00h20m13s)

[grumble grumble grumble](https://youtu.be/mbmprym9SDM?t=00h20m15s)

[um](https://youtu.be/mbmprym9SDM?t=00h20m18s)

[so](https://youtu.be/mbmprym9SDM?t=00h20m27s)

[far](https://youtu.be/mbmprym9SDM?t=00h20m32s)

[gets](https://youtu.be/mbmprym9SDM?t=00h20m35s)

[addressed of](https://youtu.be/mbmprym9SDM?t=00h20m37s)

[boxed](https://youtu.be/mbmprym9SDM?t=00h20m38s)

[to manage type of oh my word because](https://youtu.be/mbmprym9SDM?t=00h20m44s)

[this expects](https://youtu.be/mbmprym9SDM?t=00h20m47s)

[a foo and in this case foo is going to](https://youtu.be/mbmprym9SDM?t=00h20m49s)

[be a](https://youtu.be/mbmprym9SDM?t=00h20m52s)

[yeah yeah](https://youtu.be/mbmprym9SDM?t=00h20m53s)

[oh](https://youtu.be/mbmprym9SDM?t=00h20m59s)

[wait seriously it's just simple](https://youtu.be/mbmprym9SDM?t=00h21m00s)

[box](https://youtu.be/mbmprym9SDM?t=00h21m07s)

[oh this is putting it in](https://youtu.be/mbmprym9SDM?t=00h21m08s)

[oh hey look at that](https://youtu.be/mbmprym9SDM?t=00h21m15s)

[that looks kind of like what i want](https://youtu.be/mbmprym9SDM?t=00h21m18s)

[unbox](https://youtu.be/mbmprym9SDM?t=00h21m27s)

[boxed](https://youtu.be/mbmprym9SDM?t=00h21m31s)

[no way this bites me](https://youtu.be/mbmprym9SDM?t=00h21m33s)

[uh let's see so take you out of a fixed](https://youtu.be/mbmprym9SDM?t=00h21m36s)

[statement sure](https://youtu.be/mbmprym9SDM?t=00h21m39s)

[okay](https://youtu.be/mbmprym9SDM?t=00h21m43s)

[i guess we should probably go back and](https://youtu.be/mbmprym9SDM?t=00h21m49s)

[make sure we fail for the right reason](https://youtu.be/mbmprym9SDM?t=00h21m51s)

[uh](https://youtu.be/mbmprym9SDM?t=00h21m56s)

[type must be a pointer](https://youtu.be/mbmprym9SDM?t=00h21m57s)

[of course](https://youtu.be/mbmprym9SDM?t=00h22m03s)

[okay this is quickly becoming very](https://youtu.be/mbmprym9SDM?t=00h22m06s)

[difficult to test](https://youtu.be/mbmprym9SDM?t=00h22m08s)

[um okay what were the other things that](https://youtu.be/mbmprym9SDM?t=00h22m10s)

[you did so you'll accept a long](https://youtu.be/mbmprym9SDM?t=00h22m14s)

[which will blow up on anything that's](https://youtu.be/mbmprym9SDM?t=00h22m16s)

[too big to be an it](https://youtu.be/mbmprym9SDM?t=00h22m17s)

[it contained in a 64-bit signed integer](https://youtu.be/mbmprym9SDM?t=00h22m28s)

[on a 32-bit fat from the values to those](https://youtu.be/mbmprym9SDM?t=00h22m38s)

[is this uh](https://youtu.be/mbmprym9SDM?t=00h22m47s)

[test](https://youtu.be/mbmprym9SDM?t=00h22m49s)

[uh](https://youtu.be/mbmprym9SDM?t=00h22m51s)

[i'm wondering if](https://youtu.be/mbmprym9SDM?t=00h22m52s)

[if i force this down to here if i can](https://youtu.be/mbmprym9SDM?t=00h22m54s)

[get away with this](https://youtu.be/mbmprym9SDM?t=00h22m58s)

[i'm wondering if it's the artifact of my](https://youtu.be/mbmprym9SDM?t=00h23m00s)

[test runner](https://youtu.be/mbmprym9SDM?t=00h23m02s)

[uh](https://youtu.be/mbmprym9SDM?t=00h23m04s)

[yeah okay test runner is down in 64-bit](https://youtu.be/mbmprym9SDM?t=00h23m05s)

[mode because i'm thinking the failure](https://youtu.be/mbmprym9SDM?t=00h23m07s)

[cases anytime that code was executed on](https://youtu.be/mbmprym9SDM?t=00h23m09s)

[a 64-bit system](https://youtu.be/mbmprym9SDM?t=00h23m12s)

[well let me rephrase it 64-bit system](https://youtu.be/mbmprym9SDM?t=00h23m15s)

[with somebody using horizontal scroll](https://youtu.be/mbmprym9SDM?t=00h23m21s)

[okay](https://youtu.be/mbmprym9SDM?t=00h23m26s)

[now we're failing for the right reasons](https://youtu.be/mbmprym9SDM?t=00h23m26s)

[okay so once you get your okay so this](https://youtu.be/mbmprym9SDM?t=00h23m29s)

[this the original code does work](https://youtu.be/mbmprym9SDM?t=00h23m31s)

[once you get your test runner out of](https://youtu.be/mbmprym9SDM?t=00h23m34s)

[32-bit mode](https://youtu.be/mbmprym9SDM?t=00h23m36s)

[uh okay so](https://youtu.be/mbmprym9SDM?t=00h23m38s)

[now the question comes this guy here we](https://youtu.be/mbmprym9SDM?t=00h23m42s)

[expected it to be](https://youtu.be/mbmprym9SDM?t=00h23m45s)

[um](https://youtu.be/mbmprym9SDM?t=00h23m48s)

[that](https://youtu.be/mbmprym9SDM?t=00h23m50s)

[and we ended up with very much not that](https://youtu.be/mbmprym9SDM?t=00h23m53s)

[and i assume what we're running into is](https://youtu.be/mbmprym9SDM?t=00h23m55s)

[two's complement issue again](https://youtu.be/mbmprym9SDM?t=00h23m57s)

[because you'll note this goes down to a](https://youtu.be/mbmprym9SDM?t=00h24m00s)

[signed number](https://youtu.be/mbmprym9SDM?t=00h24m01s)

[i might need to double check because i](https://youtu.be/mbmprym9SDM?t=00h24m05s)

[may just be wrong with my assertion here](https://youtu.be/mbmprym9SDM?t=00h24m07s)

[yes this is minus 30 whereas the other](https://youtu.be/mbmprym9SDM?t=00h24m14s)

[one should have been](https://youtu.be/mbmprym9SDM?t=00h24m18s)

[let me just check because i think](https://youtu.be/mbmprym9SDM?t=00h24m21s)

[the original bug was when it was left](https://youtu.be/mbmprym9SDM?t=00h24m24s)

[if i scroll left on any place it won't](https://youtu.be/mbmprym9SDM?t=00h24m28s)

[be a problem but if i scroll right even](https://youtu.be/mbmprym9SDM?t=00h24m30s)

[a little bit](https://youtu.be/mbmprym9SDM?t=00h24m32s)

[trying to remember how this works](https://youtu.be/mbmprym9SDM?t=00h24m38s)

[because i think on a scroll of right](https://youtu.be/mbmprym9SDM?t=00h24m40s)

[the horizontal so let's see on a scroll](https://youtu.be/mbmprym9SDM?t=00h24m46s)

[of right it was crashing](https://youtu.be/mbmprym9SDM?t=00h24m48s)

[should right produce a negative value](https://youtu.be/mbmprym9SDM?t=00h24m52s)

[horizontal offset](https://youtu.be/mbmprym9SDM?t=00h24m54s)

[goes negative](https://youtu.be/mbmprym9SDM?t=00h24m56s)

[that is correct because the horizontal](https://youtu.be/mbmprym9SDM?t=00h24m57s)

[offset of negative would end up moving](https://youtu.be/mbmprym9SDM?t=00h24m59s)

[would end up scrolling the content to](https://youtu.be/mbmprym9SDM?t=00h25m02s)

[the right](https://youtu.be/mbmprym9SDM?t=00h25m04s)

[so that i believe is correct](https://youtu.be/mbmprym9SDM?t=00h25m06s)

[got it okay so i think the simple](https://youtu.be/mbmprym9SDM?t=00h25m12s)

[solution here is this](https://youtu.be/mbmprym9SDM?t=00h25m14s)

[we convert to an n64 and then we stop](https://youtu.be/mbmprym9SDM?t=00h25m16s)

[blowing up](https://youtu.be/mbmprym9SDM?t=00h25m18s)

[and the problem goes away so let's do](https://youtu.be/mbmprym9SDM?t=00h25m21s)

[this](https://youtu.be/mbmprym9SDM?t=00h25m23s)

[go in](https://youtu.be/mbmprym9SDM?t=00h25m25s)

[here](https://youtu.be/mbmprym9SDM?t=00h25m26s)

[wondering if i should](https://youtu.be/mbmprym9SDM?t=00h25m28s)

[because i could break this little bit of](https://youtu.be/mbmprym9SDM?t=00h25m31s)

[math out somewhere else to handle it but](https://youtu.be/mbmprym9SDM?t=00h25m32s)

[i don't think it's that big of an issue](https://youtu.be/mbmprym9SDM?t=00h25m34s)

[i don't think it's that big of an issue](https://youtu.be/mbmprym9SDM?t=00h25m45s)

[we're gonna let her go](https://youtu.be/mbmprym9SDM?t=00h25m46s)

[okay so let's come in here and let's do](https://youtu.be/mbmprym9SDM?t=00h25m47s)

[create branch](https://youtu.be/mbmprym9SDM?t=00h25m51s)

[[Music]](https://youtu.be/mbmprym9SDM?t=00h25m54s)

[okay so issue number two six six eight](https://youtu.be/mbmprym9SDM?t=00h25m55s)

[so i go fix two six six eight](https://youtu.be/mbmprym9SDM?t=00h26m00s)

[wrong button](https://youtu.be/mbmprym9SDM?t=00h26m05s)

[x two six six eight](https://youtu.be/mbmprym9SDM?t=00h26m07s)

[and then we only want](https://youtu.be/mbmprym9SDM?t=00h26m10s)

[this change here so](https://youtu.be/mbmprym9SDM?t=00h26m12s)

[that's a little tiny let's go a little](https://youtu.be/mbmprym9SDM?t=00h26m15s)

[smaller](https://youtu.be/mbmprym9SDM?t=00h26m16s)

[uh](https://youtu.be/mbmprym9SDM?t=00h26m18s)

[there we go so](https://youtu.be/mbmprym9SDM?t=00h26m24s)

[32 64.](https://youtu.be/mbmprym9SDM?t=00h26m25s)

[that's what we expect](https://youtu.be/mbmprym9SDM?t=00h26m27s)

[uh the unsafe change to the test project](https://youtu.be/mbmprym9SDM?t=00h26m29s)

[we do not want that](https://youtu.be/mbmprym9SDM?t=00h26m31s)

[so](https://youtu.be/mbmprym9SDM?t=00h26m34s)

[fixing issue when](https://youtu.be/mbmprym9SDM?t=00h26m36s)

[how about](https://youtu.be/mbmprym9SDM?t=00h26m39s)

[fixes](https://youtu.be/mbmprym9SDM?t=00h26m41s)

[well](https://youtu.be/mbmprym9SDM?t=00h26m43s)

[fix crash on 64-bit](https://youtu.be/mbmprym9SDM?t=00h26m44s)

[uh](https://youtu.be/mbmprym9SDM?t=00h26m49s)

[process so that's actually something](https://youtu.be/mbmprym9SDM?t=00h26m50s)

[worth worth noting is](https://youtu.be/mbmprym9SDM?t=00h26m53s)

[right now](https://youtu.be/mbmprym9SDM?t=00h26m55s)

[uh](https://youtu.be/mbmprym9SDM?t=00h26m56s)

[64-bit operating systems are pretty much](https://youtu.be/mbmprym9SDM?t=00h26m57s)

[ubiquitous you kind of have to work hard](https://youtu.be/mbmprym9SDM?t=00h26m59s)

[to get um](https://youtu.be/mbmprym9SDM?t=00h27m01s)

[sorry once again my colleagues seem to](https://youtu.be/mbmprym9SDM?t=00h27m05s)

[enjoy](https://youtu.be/mbmprym9SDM?t=00h27m07s)

[i need to mute them](https://youtu.be/mbmprym9SDM?t=00h27m11s)

[they often sit in the chat and then](https://youtu.be/mbmprym9SDM?t=00h27m13s)

[heckle me on side channels which is](https://youtu.be/mbmprym9SDM?t=00h27m14s)

[great fun and i enjoy it thank you bruce](https://youtu.be/mbmprym9SDM?t=00h27m16s)

[um](https://youtu.be/mbmprym9SDM?t=00h27m19s)

[so even though the 64-bit operating](https://youtu.be/mbmprym9SDM?t=00h27m22s)

[system is more or less ubiquitous](https://youtu.be/mbmprym9SDM?t=00h27m24s)

[especially for wpf like](https://youtu.be/mbmprym9SDM?t=00h27m25s)

[i don't even know if there is a](https://youtu.be/mbmprym9SDM?t=00h27m28s)

[supported version of windows that's](https://youtu.be/mbmprym9SDM?t=00h27m29s)

[32-bit anymore](https://youtu.be/mbmprym9SDM?t=00h27m31s)

[there might not be however your](https://youtu.be/mbmprym9SDM?t=00h27m33s)

[processes can still run 32-bit or x86](https://youtu.be/mbmprym9SDM?t=00h27m35s)

[so the the bitness of the operating](https://youtu.be/mbmprym9SDM?t=00h27m39s)

[system is](https://youtu.be/mbmprym9SDM?t=00h27m42s)

[not as important](https://youtu.be/mbmprym9SDM?t=00h27m43s)

[as the whether your app is running 32 or](https://youtu.be/mbmprym9SDM?t=00h27m45s)

[64 bit](https://youtu.be/mbmprym9SDM?t=00h27m48s)

[so we we saw that a little bit even with](https://youtu.be/mbmprym9SDM?t=00h27m49s)

[my test runner where it was failing](https://youtu.be/mbmprym9SDM?t=00h27m52s)

[until toggling](https://youtu.be/mbmprym9SDM?t=00h27m54s)

[the processor architecture for any cpu](https://youtu.be/mbmprym9SDM?t=00h27m57s)

[projects when i left it at auto it was](https://youtu.be/mbmprym9SDM?t=00h28m00s)

[falling into x86 not x64 and as soon as](https://youtu.be/mbmprym9SDM?t=00h28m02s)

[i flipped a deck 64 then our code ended](https://youtu.be/mbmprym9SDM?t=00h28m05s)

[up working](https://youtu.be/mbmprym9SDM?t=00h28m07s)

[so](https://youtu.be/mbmprym9SDM?t=00h28m08s)

[worth being aware of that so i'm i'm](https://youtu.be/mbmprym9SDM?t=00h28m09s)

[willing to bet this user](https://youtu.be/mbmprym9SDM?t=00h28m12s)

[was uh](https://youtu.be/mbmprym9SDM?t=00h28m14s)

[running under an app that was set at 64.](https://youtu.be/mbmprym9SDM?t=00h28m17s)

[or at least the app start it could be](https://youtu.be/mbmprym9SDM?t=00h28m19s)

[any cpu and the app ran is 64-bit](https://youtu.be/mbmprym9SDM?t=00h28m20s)

[okay so let's see fixes](https://youtu.be/mbmprym9SDM?t=00h28m24s)

[this because this will pick it up](https://youtu.be/mbmprym9SDM?t=00h28m28s)

[and](https://youtu.be/mbmprym9SDM?t=00h28m30s)

[there we go](https://youtu.be/mbmprym9SDM?t=00h28m32s)

[okay i want to try something too because](https://youtu.be/mbmprym9SDM?t=00h28m33s)

[i was shown something the other day](https://youtu.be/mbmprym9SDM?t=00h28m36s)

[and i'm actually curious what get](https://youtu.be/mbmprym9SDM?t=00h28m39s)

[cracking does so if i take this](https://youtu.be/mbmprym9SDM?t=00h28m41s)

[and i drag this down onto here](https://youtu.be/mbmprym9SDM?t=00h28m45s)

[it doesn't start a pull request wait oh](https://youtu.be/mbmprym9SDM?t=00h28m51s)

[push it and start pull request that's](https://youtu.be/mbmprym9SDM?t=00h28m56s)

[exactly what i want](https://youtu.be/mbmprym9SDM?t=00h28m59s)

[and then ask me where to push to so go](https://youtu.be/mbmprym9SDM?t=00h29m02s)

[ahead and do my fork sure](https://youtu.be/mbmprym9SDM?t=00h29m04s)

[and then start a pull](https://youtu.be/mbmprym9SDM?t=00h29m05s)

[get](https://youtu.be/mbmprym9SDM?t=00h29m09s)

[cracking you impress me you impressed me](https://youtu.be/mbmprym9SDM?t=00h29m10s)

[get kraken i approve that was that was](https://youtu.be/mbmprym9SDM?t=00h29m14s)

[very easy](https://youtu.be/mbmprym9SDM?t=00h29m16s)

[okay](https://youtu.be/mbmprym9SDM?t=00h29m18s)

[um](https://youtu.be/mbmprym9SDM?t=00h29m19s)

[send it](https://youtu.be/mbmprym9SDM?t=00h29m22s)

[can't get much easier than that](https://youtu.be/mbmprym9SDM?t=00h29m29s)

[okay so let's leave a quick comment on](https://youtu.be/mbmprym9SDM?t=00h29m32s)

[the issue](https://youtu.be/mbmprym9SDM?t=00h29m33s)

[fix in](https://youtu.be/mbmprym9SDM?t=00h29m43s)

[tonight's](https://youtu.be/mbmprym9SDM?t=00h29m45s)

[uh](https://youtu.be/mbmprym9SDM?t=00h29m46s)

[nightly](https://youtu.be/mbmprym9SDM?t=00h29m47s)

[release](https://youtu.be/mbmprym9SDM?t=00h29m49s)

[comment](https://youtu.be/mbmprym9SDM?t=00h29m52s)

[okay and then we're gonna just slap this](https://youtu.be/mbmprym9SDM?t=00h29m54s)

[guy into the milestone](https://youtu.be/mbmprym9SDM?t=00h29m56s)

[we'll let that guy run](https://youtu.be/mbmprym9SDM?t=00h29m58s)

[and let's check over here so because](https://youtu.be/mbmprym9SDM?t=00h30m00s)

[there's a couple pr so there's a an icon](https://youtu.be/mbmprym9SDM?t=00h30m02s)

[update great](https://youtu.be/mbmprym9SDM?t=00h30m05s)

[slap it in squash merge squash merge](https://youtu.be/mbmprym9SDM?t=00h30m07s)

[done](https://youtu.be/mbmprym9SDM?t=00h30m09s)

[so i honestly i don't even check these](https://youtu.be/mbmprym9SDM?t=00h30m11s)

[anymore they've been so consistent on](https://youtu.be/mbmprym9SDM?t=00h30m13s)

[on doing it](https://youtu.be/mbmprym9SDM?t=00h30m16s)

[um](https://youtu.be/mbmprym9SDM?t=00h30m18s)

[what happened here](https://youtu.be/mbmprym9SDM?t=00h30m20s)

[image filter](https://youtu.be/mbmprym9SDM?t=00h30m22s)

[used to be tied to image multiple](https://youtu.be/mbmprym9SDM?t=00h30m24s)

[outline and now it's tied to image auto](https://youtu.be/mbmprym9SDM?t=00h30m27s)

[adjust](https://youtu.be/mbmprym9SDM?t=00h30m30s)

[great](https://youtu.be/mbmprym9SDM?t=00h30m32s)

[the the material design icon people make](https://youtu.be/mbmprym9SDM?t=00h30m35s)

[changes constantly which is why i have](https://youtu.be/mbmprym9SDM?t=00h30m38s)

[automated that process](https://youtu.be/mbmprym9SDM?t=00h30m40s)

[okay so let's jump back here let's let's](https://youtu.be/mbmprym9SDM?t=00h30m42s)

[go let's go find](https://youtu.be/mbmprym9SDM?t=00h30m44s)

[uh let's see tab control](https://youtu.be/mbmprym9SDM?t=00h30m46s)

[uh let's see first of all thanks for](https://youtu.be/mbmprym9SDM?t=00h30m49s)

[creating an amazing toolkit you're](https://youtu.be/mbmprym9SDM?t=00h30m51s)

[welcome i just maintain it though](https://youtu.be/mbmprym9SDM?t=00h30m52s)

[uh when using tab control with shadow](https://youtu.be/mbmprym9SDM?t=00h30m55s)

[assist step two in the tab control a tab](https://youtu.be/mbmprym9SDM?t=00h30m57s)

[item that contains a scroll viewer and](https://youtu.be/mbmprym9SDM?t=00h31m00s)

[card the card will appear in front of](https://youtu.be/mbmprym9SDM?t=00h31m03s)

[the tab controls header](https://youtu.be/mbmprym9SDM?t=00h31m05s)

[ah](https://youtu.be/mbmprym9SDM?t=00h31m09s)

[i see so if you have a card](https://youtu.be/mbmprym9SDM?t=00h31m15s)

[it's going to float on top](https://youtu.be/mbmprym9SDM?t=00h31m17s)

[is the the problem here and so because](https://youtu.be/mbmprym9SDM?t=00h31m20s)

[the tab](https://youtu.be/mbmprym9SDM?t=00h31m22s)

[or the the tab content floats on top](https://youtu.be/mbmprym9SDM?t=00h31m23s)

[this is probably an easy one](https://youtu.be/mbmprym9SDM?t=00h31m28s)

[when using a toolbar closed on the tab](https://youtu.be/mbmprym9SDM?t=00h31m30s)

[control the same shadow issue will occur](https://youtu.be/mbmprym9SDM?t=00h31m32s)

[this however can easily be fixed by](https://youtu.be/mbmprym9SDM?t=00h31m35s)

[adding panels the index](https://youtu.be/mbmprym9SDM?t=00h31m37s)

[this was discussed in issue 647.](https://youtu.be/mbmprym9SDM?t=00h31m39s)

[when using the tab control setting the](https://youtu.be/mbmprym9SDM?t=00h31m43s)

[panel uh](https://youtu.be/mbmprym9SDM?t=00h31m44s)

[i'm using a tab control](https://youtu.be/mbmprym9SDM?t=00h31m47s)

[setting panel z index on the tab control](https://youtu.be/mbmprym9SDM?t=00h31m50s)

[tab i know tab content will not fix the](https://youtu.be/mbmprym9SDM?t=00h31m52s)

[issue](https://youtu.be/mbmprym9SDM?t=00h31m54s)

[um](https://youtu.be/mbmprym9SDM?t=00h31m55s)

[app item header and content](https://youtu.be/mbmprym9SDM?t=00h31m56s)

[in here](https://youtu.be/mbmprym9SDM?t=00h31m58s)

[i think he is correct though](https://youtu.be/mbmprym9SDM?t=00h32m00s)

[rather than setting the](https://youtu.be/mbmprym9SDM?t=00h32m03s)

[rather than setting the](https://youtu.be/mbmprym9SDM?t=00h32m12s)

[the panel index for this or the z index](https://youtu.be/mbmprym9SDM?t=00h32m14s)

[of the panel i usually prefer to just](https://youtu.be/mbmprym9SDM?t=00h32m16s)

[reorder the xaml where possible](https://youtu.be/mbmprym9SDM?t=00h32m19s)

[tends to make things a lot easier so z](https://youtu.be/mbmprym9SDM?t=00h32m21s)

[and x in wpf can be set](https://youtu.be/mbmprym9SDM?t=00h32m24s)

[in a number of ways one is with this uh](https://youtu.be/mbmprym9SDM?t=00h32m27s)

[attached property if you want to](https://youtu.be/mbmprym9SDM?t=00h32m30s)

[explicitly control it](https://youtu.be/mbmprym9SDM?t=00h32m31s)

[the other option](https://youtu.be/mbmprym9SDM?t=00h32m33s)

[is](https://youtu.be/mbmprym9SDM?t=00h32m35s)

[uh just reordering your xaml because](https://youtu.be/mbmprym9SDM?t=00h32m36s)

[your z index will](https://youtu.be/mbmprym9SDM?t=00h32m39s)

[just increment up for each element in](https://youtu.be/mbmprym9SDM?t=00h32m42s)

[the xaml so let's](https://youtu.be/mbmprym9SDM?t=00h32m44s)

[let's take a crack at this one real](https://youtu.be/mbmprym9SDM?t=00h32m46s)

[quick](https://youtu.be/mbmprym9SDM?t=00h32m47s)

[so first of all i'm pretty sure this is](https://youtu.be/mbmprym9SDM?t=00h32m48s)

[a bug](https://youtu.be/mbmprym9SDM?t=00h32m50s)

[the thing is the tab control is new to](https://youtu.be/mbmprym9SDM?t=00h32m52s)

[this library it did not exist in this](https://youtu.be/mbmprym9SDM?t=00h32m55s)

[library for a long time](https://youtu.be/mbmprym9SDM?t=00h32m57s)

[the reason is](https://youtu.be/mbmprym9SDM?t=00h32m59s)

[because the](https://youtu.be/mbmprym9SDM?t=00h33m00s)

[um](https://youtu.be/mbmprym9SDM?t=00h33m04s)

[there's another library called](https://youtu.be/mbmprym9SDM?t=00h33m05s)

[draggables that was expected to be the](https://youtu.be/mbmprym9SDM?t=00h33m06s)

[the useful option if people wanted a](https://youtu.be/mbmprym9SDM?t=00h33m09s)

[style tab control](https://youtu.be/mbmprym9SDM?t=00h33m12s)

[the problem is draggables has not been](https://youtu.be/mbmprym9SDM?t=00h33m13s)

[updated in a while and doesn't support a](https://youtu.be/mbmprym9SDM?t=00h33m15s)

[lot of](https://youtu.be/mbmprym9SDM?t=00h33m18s)

[like.net5.net six etc etc](https://youtu.be/mbmprym9SDM?t=00h33m19s)

[okay so](https://youtu.be/mbmprym9SDM?t=00h33m26s)

[let's start with writing](https://youtu.be/mbmprym9SDM?t=00h33m29s)

[let's write a little test i think so](https://youtu.be/mbmprym9SDM?t=00h33m33s)

[we're gonna go ui tests](https://youtu.be/mbmprym9SDM?t=00h33m36s)

[oh actually](https://youtu.be/mbmprym9SDM?t=00h33m39s)

[before i get carried away writing a ui](https://youtu.be/mbmprym9SDM?t=00h33m41s)

[test](https://youtu.be/mbmprym9SDM?t=00h33m43s)

[the last time we ran into a small issue](https://youtu.be/mbmprym9SDM?t=00h33m44s)

[with my xaml test library which is what](https://youtu.be/mbmprym9SDM?t=00h33m46s)

[i used to write ui tests and i'm](https://youtu.be/mbmprym9SDM?t=00h33m48s)

[wondering](https://youtu.be/mbmprym9SDM?t=00h33m49s)

[should we do some xaml test stuff](https://youtu.be/mbmprym9SDM?t=00h33m51s)

[instead](https://youtu.be/mbmprym9SDM?t=00h33m52s)

[that kind of sounds fun to me](https://youtu.be/mbmprym9SDM?t=00h33m55s)

[yeah my stream the ammo test stuff it is](https://youtu.be/mbmprym9SDM?t=00h33m58s)

[uh](https://youtu.be/mbmprym9SDM?t=00h34m01s)

[okay](https://youtu.be/mbmprym9SDM?t=00h34m04s)

[let's jump in here uh](https://youtu.be/mbmprym9SDM?t=00h34m07s)

[okay so](https://youtu.be/mbmprym9SDM?t=00h34m09s)

[am i caught up](https://youtu.be/mbmprym9SDM?t=00h34m10s)

[yeah we got all of this](https://youtu.be/mbmprym9SDM?t=00h34m12s)

[we got all this stuff set okay so xaml](https://youtu.be/mbmprym9SDM?t=00h34m17s)

[test so for those people who haven't](https://youtu.be/mbmprym9SDM?t=00h34m20s)

[seen xaml test before it is what is](https://youtu.be/mbmprym9SDM?t=00h34m22s)

[powering](https://youtu.be/mbmprym9SDM?t=00h34m24s)

[these tests here i largely wrote it](https://youtu.be/mbmprym9SDM?t=00h34m25s)

[for](https://youtu.be/mbmprym9SDM?t=00h34m28s)

[um](https://youtu.be/mbmprym9SDM?t=00h34m30s)

[for building out tests for the material](https://youtu.be/mbmprym9SDM?t=00h34m32s)

[design in xaml library because the issue](https://youtu.be/mbmprym9SDM?t=00h34m34s)

[is this library is a style and theming](https://youtu.be/mbmprym9SDM?t=00h34m36s)

[library](https://youtu.be/mbmprym9SDM?t=00h34m39s)

[which unfortunately means it's really](https://youtu.be/mbmprym9SDM?t=00h34m40s)

[hard to write tests because half the](https://youtu.be/mbmprym9SDM?t=00h34m41s)

[time the bugs are thing doesn't look](https://youtu.be/mbmprym9SDM?t=00h34m43s)

[right](https://youtu.be/mbmprym9SDM?t=00h34m46s)

[and it's really hard to write good tests](https://youtu.be/mbmprym9SDM?t=00h34m47s)

[over ui objects you've got the issue of](https://youtu.be/mbmprym9SDM?t=00h34m50s)

[your test have to run](https://youtu.be/mbmprym9SDM?t=00h34m52s)

[as an sta thread something with a ui to](https://youtu.be/mbmprym9SDM?t=00h34m55s)

[go with it](https://youtu.be/mbmprym9SDM?t=00h34m58s)

[and then more importantly you really](https://youtu.be/mbmprym9SDM?t=00h34m59s)

[don't want to just like fire up the](https://youtu.be/mbmprym9SDM?t=00h35m01s)

[controls and run them that way because](https://youtu.be/mbmprym9SDM?t=00h35m02s)

[you aren't getting the full ui rendering](https://youtu.be/mbmprym9SDM?t=00h35m04s)

[stack](https://youtu.be/mbmprym9SDM?t=00h35m06s)

[and so you kind of get this well it's](https://youtu.be/mbmprym9SDM?t=00h35m07s)

[kind of an okay test not quite as good](https://youtu.be/mbmprym9SDM?t=00h35m09s)

[so what xaml test does](https://youtu.be/mbmprym9SDM?t=00h35m12s)

[is it actually starts a full wpf app](https://youtu.be/mbmprym9SDM?t=00h35m15s)

[shell](https://youtu.be/mbmprym9SDM?t=00h35m17s)

[and then lets you drop in xaml content](https://youtu.be/mbmprym9SDM?t=00h35m18s)

[and run tests against it but because](https://youtu.be/mbmprym9SDM?t=00h35m20s)

[it's running in a full wpf app you get](https://youtu.be/mbmprym9SDM?t=00h35m22s)

[all the wpf stuff which is great](https://youtu.be/mbmprym9SDM?t=00h35m25s)

[that's how stuff like this is ending up](https://youtu.be/mbmprym9SDM?t=00h35m28s)

[working so](https://youtu.be/mbmprym9SDM?t=00h35m30s)

[this load xaml method is actually a](https://youtu.be/mbmprym9SDM?t=00h35m32s)

[helper one that just exists in the](https://youtu.be/mbmprym9SDM?t=00h35m34s)

[material design stuff](https://youtu.be/mbmprym9SDM?t=00h35m35s)

[um so i i built on top of xaml test i](https://youtu.be/mbmprym9SDM?t=00h35m37s)

[built a couple extra helper methods um](https://youtu.be/mbmprym9SDM?t=00h35m40s)

[into the material design test project](https://youtu.be/mbmprym9SDM?t=00h35m42s)

[that will](https://youtu.be/mbmprym9SDM?t=00h35m45s)

[stand up kind of a default](https://youtu.be/mbmprym9SDM?t=00h35m46s)

[app.xaml with the appropriate you know](https://youtu.be/mbmprym9SDM?t=00h35m48s)

[bundled theme and the default styling](https://youtu.be/mbmprym9SDM?t=00h35m50s)

[stuff](https://youtu.be/mbmprym9SDM?t=00h35m52s)

[uh it brings in the appropriate needed](https://youtu.be/mbmprym9SDM?t=00h35m53s)

[dlls to make it all work great](https://youtu.be/mbmprym9SDM?t=00h35m55s)

[and then it'll stand up a](https://youtu.be/mbmprym9SDM?t=00h35m58s)

[a default window for you with all of the](https://youtu.be/mbmprym9SDM?t=00h36m00s)

[stuff in it which is great that's what](https://youtu.be/mbmprym9SDM?t=00h36m02s)

[you want](https://youtu.be/mbmprym9SDM?t=00h36m05s)

[and then from there](https://youtu.be/mbmprym9SDM?t=00h36m07s)

[writing the test becomes easy uses](https://youtu.be/mbmprym9SDM?t=00h36m10s)

[called load xaml it does the whole app](https://youtu.be/mbmprym9SDM?t=00h36m12s)

[spin up the startup and and gives you a](https://youtu.be/mbmprym9SDM?t=00h36m14s)

[a material designy looking window um as](https://youtu.be/mbmprym9SDM?t=00h36m17s)

[its shell and then](https://youtu.be/mbmprym9SDM?t=00h36m20s)

[in this case we just write the test](https://youtu.be/mbmprym9SDM?t=00h36m22s)

[which is hey let's dump the color zone](https://youtu.be/mbmprym9SDM?t=00h36m24s)

[in](https://youtu.be/mbmprym9SDM?t=00h36m25s)

[and let's just grab the theme colors out](https://youtu.be/mbmprym9SDM?t=00h36m26s)

[and make sure we got the right theme](https://youtu.be/mbmprym9SDM?t=00h36m28s)

[color](https://youtu.be/mbmprym9SDM?t=00h36m30s)

[boom](https://youtu.be/mbmprym9SDM?t=00h36m33s)

[so these theme colors dive into the](https://youtu.be/mbmprym9SDM?t=00h36m35s)

[app resources to make sure that those](https://youtu.be/mbmprym9SDM?t=00h36m39s)

[get pulled out and then this just rips](https://youtu.be/mbmprym9SDM?t=00h36m41s)

[through the color zone modes and says](https://youtu.be/mbmprym9SDM?t=00h36m43s)

[hey when i set the particular mode let's](https://youtu.be/mbmprym9SDM?t=00h36m45s)

[make sure it's pulling the right](https://youtu.be/mbmprym9SDM?t=00h36m48s)

[resource brush](https://youtu.be/mbmprym9SDM?t=00h36m49s)

[simple simple simple](https://youtu.be/mbmprym9SDM?t=00h36m51s)

[makes it easy but](https://youtu.be/mbmprym9SDM?t=00h36m53s)

[there are it is not a perfect library](https://youtu.be/mbmprym9SDM?t=00h36m55s)

[and more importantly there was a couple](https://youtu.be/mbmprym9SDM?t=00h36m59s)

[things that bit me last time that i was](https://youtu.be/mbmprym9SDM?t=00h37m01s)

[both excited and unexcited about](https://youtu.be/mbmprym9SDM?t=00h37m03s)

[so for example if we launch this app](https://youtu.be/mbmprym9SDM?t=00h37m06s)

[right here](https://youtu.be/mbmprym9SDM?t=00h37m09s)

[if i launch this so](https://youtu.be/mbmprym9SDM?t=00h37m10s)

[hang on stop it don't get involved](https://youtu.be/mbmprym9SDM?t=00h37m12s)

[if i launch this with debugging](https://youtu.be/mbmprym9SDM?t=00h37m15s)

[launch with debug launch with debug](https://youtu.be/mbmprym9SDM?t=00h37m20s)

[launch with debug](https://youtu.be/mbmprym9SDM?t=00h37m22s)

[come on](https://youtu.be/mbmprym9SDM?t=00h37m29s)

[thinking thinking thinking thinking](https://youtu.be/mbmprym9SDM?t=00h37m31s)

[thinking](https://youtu.be/mbmprym9SDM?t=00h37m33s)

[it's not over on a different screen is](https://youtu.be/mbmprym9SDM?t=00h37m34s)

[it](https://youtu.be/mbmprym9SDM?t=00h37m36s)

[i assume it's just recompiling the](https://youtu.be/mbmprym9SDM?t=00h37m37s)

[project since i didn't compile it](https://youtu.be/mbmprym9SDM?t=00h37m38s)

[come on let's go you can do it you can](https://youtu.be/mbmprym9SDM?t=00h37m42s)

[do it](https://youtu.be/mbmprym9SDM?t=00h37m44s)

[come on](https://youtu.be/mbmprym9SDM?t=00h37m51s)

[come on let's go](https://youtu.be/mbmprym9SDM?t=00h37m55s)

[launch](https://youtu.be/mbmprym9SDM?t=00h37m58s)

[okay](https://youtu.be/mbmprym9SDM?t=00h38m00s)

[this should fire up](https://youtu.be/mbmprym9SDM?t=00h38m02s)

[and hopefully](https://youtu.be/mbmprym9SDM?t=00h38m05s)

[yes so it is at a break point](https://youtu.be/mbmprym9SDM?t=00h38m08s)

[unfortunately the window is being set to](https://youtu.be/mbmprym9SDM?t=00h38m09s)

[top most but you'll note this window net](https://youtu.be/mbmprym9SDM?t=00h38m11s)

[here is hung](https://youtu.be/mbmprym9SDM?t=00h38m13s)

[okay and the reason it's hung is because](https://youtu.be/mbmprym9SDM?t=00h38m15s)

[i'm at a break point](https://youtu.be/mbmprym9SDM?t=00h38m17s)

[if i](https://youtu.be/mbmprym9SDM?t=00h38m19s)

[let it go](https://youtu.be/mbmprym9SDM?t=00h38m20s)

[oh i'm probably going to hit it on the](https://youtu.be/mbmprym9SDM?t=00h38m22s)

[next pass here in just a second](https://youtu.be/mbmprym9SDM?t=00h38m23s)

[turn the breakpoint off](https://youtu.be/mbmprym9SDM?t=00h38m27s)

[what xaml test actually does is it lets](https://youtu.be/mbmprym9SDM?t=00h38m29s)

[you debug into the the app shell so](https://youtu.be/mbmprym9SDM?t=00h38m32s)

[let's grab one of the samples so like](https://youtu.be/mbmprym9SDM?t=00h38m35s)

[dialog host](https://youtu.be/mbmprym9SDM?t=00h38m37s)

[closing with event view model uh](https://youtu.be/mbmprym9SDM?t=00h38m40s)

[sure let's just](https://youtu.be/mbmprym9SDM?t=00h38m43s)

[bind here](https://youtu.be/mbmprym9SDM?t=00h38m45s)

[uh that'll work](https://youtu.be/mbmprym9SDM?t=00h38m47s)

[and then](https://youtu.be/mbmprym9SDM?t=00h38m48s)

[i assume these are going to be in dialog](https://youtu.be/mbmprym9SDM?t=00h38m50s)

[host tests](https://youtu.be/mbmprym9SDM?t=00h38m52s)

[closing event counter](https://youtu.be/mbmprym9SDM?t=00h38m54s)

[closing event counter okay so this this](https://youtu.be/mbmprym9SDM?t=00h38m57s)

[is going to be important i am going to](https://youtu.be/mbmprym9SDM?t=00h39m01s)

[debug this test here](https://youtu.be/mbmprym9SDM?t=00h39m03s)

[this test is going to load this user](https://youtu.be/mbmprym9SDM?t=00h39m07s)

[control into a different process](https://youtu.be/mbmprym9SDM?t=00h39m10s)

[into that other wpf app shell that](https://youtu.be/mbmprym9SDM?t=00h39m13s)

[window is running in a completely](https://youtu.be/mbmprym9SDM?t=00h39m16s)

[separate process](https://youtu.be/mbmprym9SDM?t=00h39m18s)

[from from my my test runner and i'll](https://youtu.be/mbmprym9SDM?t=00h39m19s)

[show that](https://youtu.be/mbmprym9SDM?t=00h39m22s)

[in just a second so i'm going to put a](https://youtu.be/mbmprym9SDM?t=00h39m23s)

[put a break](https://youtu.be/mbmprym9SDM?t=00h39m25s)

[point here](https://youtu.be/mbmprym9SDM?t=00h39m26s)

[okay](https://youtu.be/mbmprym9SDM?t=00h39m32s)

[you'll know i have hit this break point](https://youtu.be/mbmprym9SDM?t=00h39m33s)

[uh if we look](https://youtu.be/mbmprym9SDM?t=00h39m38s)

[uh task manager](https://youtu.be/mbmprym9SDM?t=00h39m41s)

[we should have a xaml test](https://youtu.be/mbmprym9SDM?t=00h39m43s)

[i've got a xaml test process running](https://youtu.be/mbmprym9SDM?t=00h39m47s)

[this is a separate process that's out](https://youtu.be/mbmprym9SDM?t=00h39m50s)

[there](https://youtu.be/mbmprym9SDM?t=00h39m52s)

[and if i go through](https://youtu.be/mbmprym9SDM?t=00h39m54s)

[and look at let's see what window would](https://youtu.be/mbmprym9SDM?t=00h39m57s)

[show it to me](https://youtu.be/mbmprym9SDM?t=00h39m59s)

[windows](https://youtu.be/mbmprym9SDM?t=00h40m00s)

[actually we should be able to do it from](https://youtu.be/mbmprym9SDM?t=00h40m02s)

[just the immediate window so how about](https://youtu.be/mbmprym9SDM?t=00h40m03s)

[process](https://youtu.be/mbmprym9SDM?t=00h40m06s)

[system](https://youtu.be/mbmprym9SDM?t=00h40m10s)

[diagnostic](https://youtu.be/mbmprym9SDM?t=00h40m15s)

[process](https://youtu.be/mbmprym9SDM?t=00h40m18s)

[don't know why this is giving me](https://youtu.be/mbmprym9SDM?t=00h40m24s)

[why this would give me such problems](https://youtu.be/mbmprym9SDM?t=00h40m28s)

[uh](https://youtu.be/mbmprym9SDM?t=00h40m30s)

[debug windows](https://youtu.be/mbmprym9SDM?t=00h40m32s)

[let's look at](https://youtu.be/mbmprym9SDM?t=00h40m34s)

[where can we see what we're attached to](https://youtu.be/mbmprym9SDM?t=00h40m36s)

[processes ahaha that'll work](https://youtu.be/mbmprym9SDM?t=00h40m39s)

[so you can see right now i am in the](https://youtu.be/mbmprym9SDM?t=00h40m42s)

[xaml test.exe](https://youtu.be/mbmprym9SDM?t=00h40m45s)

[not my test host process](https://youtu.be/mbmprym9SDM?t=00h40m48s)

[so the xaml test library when it starts](https://youtu.be/mbmprym9SDM?t=00h40m51s)

[up that external process](https://youtu.be/mbmprym9SDM?t=00h40m54s)

[if you are running with the debugger](https://youtu.be/mbmprym9SDM?t=00h40m56s)

[attached to your test host it will](https://youtu.be/mbmprym9SDM?t=00h40m58s)

[automatically attach that debugger to](https://youtu.be/mbmprym9SDM?t=00h41m00s)

[the xaml test](https://youtu.be/mbmprym9SDM?t=00h41m02s)

[project pretty cool](https://youtu.be/mbmprym9SDM?t=00h41m04s)

[that's pretty cool my book](https://youtu.be/mbmprym9SDM?t=00h41m07s)

[but the problem is sometimes you don't](https://youtu.be/mbmprym9SDM?t=00h41m10s)

[want that behavior sometimes it's nice](https://youtu.be/mbmprym9SDM?t=00h41m11s)

[to pause your test](https://youtu.be/mbmprym9SDM?t=00h41m13s)

[leave that remote app running so that](https://youtu.be/mbmprym9SDM?t=00h41m15s)

[you can interact with it click some](https://youtu.be/mbmprym9SDM?t=00h41m17s)

[buttons play with stuff maybe attach](https://youtu.be/mbmprym9SDM?t=00h41m19s)

[snoop do whatever right](https://youtu.be/mbmprym9SDM?t=00h41m21s)

[so](https://youtu.be/mbmprym9SDM?t=00h41m23s)

[one of the things i would like to do on](https://youtu.be/mbmprym9SDM?t=00h41m24s)

[this guy let's close you let's cause you](https://youtu.be/mbmprym9SDM?t=00h41m26s)

[before we get too carried away let's](https://youtu.be/mbmprym9SDM?t=00h41m28s)

[let's jump over here because we've got](https://youtu.be/mbmprym9SDM?t=00h41m30s)

[so i've logged a couple issues of things](https://youtu.be/mbmprym9SDM?t=00h41m37s)

[that i would like to fix](https://youtu.be/mbmprym9SDM?t=00h41m40s)

[oh and there is this one here](https://youtu.be/mbmprym9SDM?t=00h41m42s)

[uh](https://youtu.be/mbmprym9SDM?t=00h41m44s)

[uh](https://youtu.be/mbmprym9SDM?t=00h41m45s)

[i'm trying to test set up here](https://youtu.be/mbmprym9SDM?t=00h41m46s)

[oh i didn't even notice this one](https://youtu.be/mbmprym9SDM?t=00h41m50s)

[i will i will go back and look at this](https://youtu.be/mbmprym9SDM?t=00h41m57s)

[this is somebody else who works on some](https://youtu.be/mbmprym9SDM?t=00h41m59s)

[of the material design options so i will](https://youtu.be/mbmprym9SDM?t=00h42m01s)

[i will check that i must have missed the](https://youtu.be/mbmprym9SDM?t=00h42m04s)

[email when that issue got logged](https://youtu.be/mbmprym9SDM?t=00h42m05s)

[um but this is what the issue i was](https://youtu.be/mbmprym9SDM?t=00h42m08s)

[contemplating fixing so add option to](https://youtu.be/mbmprym9SDM?t=00h42m10s)

[disable debugger attached](https://youtu.be/mbmprym9SDM?t=00h42m12s)

[right now it just always blindly](https://youtu.be/mbmprym9SDM?t=00h42m14s)

[attaches if your test uh harness has a](https://youtu.be/mbmprym9SDM?t=00h42m16s)

[debugger attached it just blindly](https://youtu.be/mbmprym9SDM?t=00h42m19s)

[attaches the debugger](https://youtu.be/mbmprym9SDM?t=00h42m20s)

[and i'd like a switch to say don't do](https://youtu.be/mbmprym9SDM?t=00h42m22s)

[that all the time](https://youtu.be/mbmprym9SDM?t=00h42m24s)

[okay so let's find where that actually](https://youtu.be/mbmprym9SDM?t=00h42m26s)

[is occurring so](https://youtu.be/mbmprym9SDM?t=00h42m30s)

[i actually know that this g was the](https://youtu.be/mbmprym9SDM?t=00h42m32s)

[latest thing that got merged in so the](https://youtu.be/mbmprym9SDM?t=00h42m34s)

[easy way to find it is going to be look](https://youtu.be/mbmprym9SDM?t=00h42m37s)

[at the pull requests](https://youtu.be/mbmprym9SDM?t=00h42m39s)

[and we can see the changes for the code](https://youtu.be/mbmprym9SDM?t=00h42m43s)

[here](https://youtu.be/mbmprym9SDM?t=00h42m45s)

[[Music]](https://youtu.be/mbmprym9SDM?t=00h42m47s)

[i think it's inside of app is where](https://youtu.be/mbmprym9SDM?t=00h42m49s)

[a lot of this](https://youtu.be/mbmprym9SDM?t=00h42m52s)

[a lot of this bit is occurring](https://youtu.be/mbmprym9SDM?t=00h42m54s)

[yeah so debugger is attached so](https://youtu.be/mbmprym9SDM?t=00h42m57s)

[app.cs let's go look at that](https://youtu.be/mbmprym9SDM?t=00h43m00s)

[[Music]](https://youtu.be/mbmprym9SDM?t=00h43m03s)

[okay](https://youtu.be/mbmprym9SDM?t=00h43m06s)

[so this xaml test project is a little](https://youtu.be/mbmprym9SDM?t=00h43m07s)

[weird because it is both itself a](https://youtu.be/mbmprym9SDM?t=00h43m10s)

[library and a xc](https://youtu.be/mbmprym9SDM?t=00h43m13s)

[so](https://youtu.be/mbmprym9SDM?t=00h43m16s)

[i abuse it a little bit](https://youtu.be/mbmprym9SDM?t=00h43m18s)

[we have](https://youtu.be/mbmprym9SDM?t=00h43m19s)

[okay first things first](https://youtu.be/mbmprym9SDM?t=00h43m20s)

[file scope namespace because i can't](https://youtu.be/mbmprym9SDM?t=00h43m23s)

[resist](https://youtu.be/mbmprym9SDM?t=00h43m24s)

[okay use debugger so this is where we](https://youtu.be/mbmprym9SDM?t=00h43m26s)

[want to](https://youtu.be/mbmprym9SDM?t=00h43m29s)

[to toggle it so this is where it is](https://youtu.be/mbmprym9SDM?t=00h43m31s)

[starting up the remote process and it's](https://youtu.be/mbmprym9SDM?t=00h43m32s)

[building up the um process start info](https://youtu.be/mbmprym9SDM?t=00h43m35s)

[object and in this case what we want to](https://youtu.be/mbmprym9SDM?t=00h43m38s)

[do is](https://youtu.be/mbmprym9SDM?t=00h43m42s)

[go through and not always attach this](https://youtu.be/mbmprym9SDM?t=00h43m45s)

[so i i think what we want to do is have](https://youtu.be/mbmprym9SDM?t=00h43m47s)

[some sort of](https://youtu.be/mbmprym9SDM?t=00h43m50s)

[trying to decide](https://youtu.be/mbmprym9SDM?t=00h43m54s)

[it doesn't make so](https://youtu.be/mbmprym9SDM?t=00h43m58s)

[uh](https://youtu.be/mbmprym9SDM?t=00h44m03s)

[i think what i want is something almost](https://youtu.be/mbmprym9SDM?t=00h44m04s)

[like a an optional boolean here](https://youtu.be/mbmprym9SDM?t=00h44m06s)

[uh](https://youtu.be/mbmprym9SDM?t=00h44m10s)

[allow](https://youtu.be/mbmprym9SDM?t=00h44m12s)

[debugger attach](https://youtu.be/mbmprym9SDM?t=00h44m14s)

[that way there's a way to turn it off](https://youtu.be/mbmprym9SDM?t=00h44m20s)

[i think that's what i want](https://youtu.be/mbmprym9SDM?t=00h44m24s)

[because i'm trying i want it to make](https://youtu.be/mbmprym9SDM?t=00h44m27s)

[sense for i don't want it to indicate](https://youtu.be/mbmprym9SDM?t=00h44m29s)

[that it will always attach](https://youtu.be/mbmprym9SDM?t=00h44m31s)

[um](https://youtu.be/mbmprym9SDM?t=00h44m34s)

[and why did i do use debugger is this](https://youtu.be/mbmprym9SDM?t=00h44m38s)

[used somewhere else](https://youtu.be/mbmprym9SDM?t=00h44m40s)

[it is it is down here](https://youtu.be/mbmprym9SDM?t=00h44m42s)

[because this is what actually leverages](https://youtu.be/mbmprym9SDM?t=00h44m44s)

[it](https://youtu.be/mbmprym9SDM?t=00h44m46s)

[so actually what we're going to do is](https://youtu.be/mbmprym9SDM?t=00h44m47s)

[we're going to change this to be](https://youtu.be/mbmprym9SDM?t=00h44m48s)

[allowed debugger attach and](https://youtu.be/mbmprym9SDM?t=00h44m51s)

[i think it's as simple as that the hard](https://youtu.be/mbmprym9SDM?t=00h44m55s)

[part is there's not a great way of being](https://youtu.be/mbmprym9SDM?t=00h44m57s)

[able to](https://youtu.be/mbmprym9SDM?t=00h44m59s)

[um to test this](https://youtu.be/mbmprym9SDM?t=00h45m03s)

[which is disappointing](https://youtu.be/mbmprym9SDM?t=00h45m05s)

[beyond i've got an api for it](https://youtu.be/mbmprym9SDM?t=00h45m08s)

[and this guy down here](https://youtu.be/mbmprym9SDM?t=00h45m11s)

[allow debugger attach](https://youtu.be/mbmprym9SDM?t=00h45m14s)

[let that flow on flow through](https://youtu.be/mbmprym9SDM?t=00h45m16s)

[okay so we'll just add that real quick](https://youtu.be/mbmprym9SDM?t=00h45m19s)

[so create branch](https://youtu.be/mbmprym9SDM?t=00h45m21s)

[fix and then this is 64.](https://youtu.be/mbmprym9SDM?t=00h45m24s)

[okay stage all changes](https://youtu.be/mbmprym9SDM?t=00h45m29s)

[allow](https://youtu.be/mbmprym9SDM?t=00h45m32s)

[disabling debugger](https://youtu.be/mbmprym9SDM?t=00h45m34s)

[catch](https://youtu.be/mbmprym9SDM?t=00h45m37s)

[fixes pound 64.](https://youtu.be/mbmprym9SDM?t=00h45m39s)

[uh](https://youtu.be/mbmprym9SDM?t=00h45m42s)

[allows a flag](https://youtu.be/mbmprym9SDM?t=00h45m45s)

[to](https://youtu.be/mbmprym9SDM?t=00h45m48s)

[disable](https://youtu.be/mbmprym9SDM?t=00h45m49s)

[debugger attach](https://youtu.be/mbmprym9SDM?t=00h45m51s)

[uh](https://youtu.be/mbmprym9SDM?t=00h45m54s)

[even](https://youtu.be/mbmprym9SDM?t=00h45m55s)

[when](https://youtu.be/mbmprym9SDM?t=00h45m57s)

[a debugger is attached](https://youtu.be/mbmprym9SDM?t=00h45m58s)

[to the host process boom](https://youtu.be/mbmprym9SDM?t=00h46m02s)

[we'll do that](https://youtu.be/mbmprym9SDM?t=00h46m07s)

[and then oh i got i gotta just lever](https://youtu.be/mbmprym9SDM?t=00h46m08s)

[okay](https://youtu.be/mbmprym9SDM?t=00h46m10s)

[i have to](https://youtu.be/mbmprym9SDM?t=00h46m11s)

[let's let's just take a moment to](https://youtu.be/mbmprym9SDM?t=00h46m13s)

[appreciate how cool this is i have a](https://youtu.be/mbmprym9SDM?t=00h46m14s)

[local branch fix 64 that is not pushed](https://youtu.be/mbmprym9SDM?t=00h46m17s)

[this is local to my system it hasn't](https://youtu.be/mbmprym9SDM?t=00h46m21s)

[gone anywhere](https://youtu.be/mbmprym9SDM?t=00h46m22s)

[i drag that onto master](https://youtu.be/mbmprym9SDM?t=00h46m24s)

[and it immediately gives me the option](https://youtu.be/mbmprym9SDM?t=00h46m27s)

[of hey let's go ahead and push this and](https://youtu.be/mbmprym9SDM?t=00h46m29s)

[create a pull request](https://youtu.be/mbmprym9SDM?t=00h46m30s)

[that's a lot of operations all at once](https://youtu.be/mbmprym9SDM?t=00h46m32s)

[now the only thing i wish](https://youtu.be/mbmprym9SDM?t=00h46m34s)

[that](https://youtu.be/mbmprym9SDM?t=00h46m38s)

[i don't need to wish it exists right](https://youtu.be/mbmprym9SDM?t=00h46m39s)

[here on the contacts menu boom](https://youtu.be/mbmprym9SDM?t=00h46m41s)

[get cracking](https://youtu.be/mbmprym9SDM?t=00h46m45s)

[once again i applaud you](https://youtu.be/mbmprym9SDM?t=00h46m48s)

[i applaud you](https://youtu.be/mbmprym9SDM?t=00h46m50s)

[i i don't know if you could make that](https://youtu.be/mbmprym9SDM?t=00h46m52s)

[easier it pushed the branch and opened](https://youtu.be/mbmprym9SDM?t=00h46m54s)

[the pull request and i don't have to](https://youtu.be/mbmprym9SDM?t=00h46m55s)

[think](https://youtu.be/mbmprym9SDM?t=00h46m57s)

[yeah that's pretty good that's pretty](https://youtu.be/mbmprym9SDM?t=00h47m00s)

[good and because i only have one remote](https://youtu.be/mbmprym9SDM?t=00h47m01s)

[um unlike the other one when i did it](https://youtu.be/mbmprym9SDM?t=00h47m04s)

[where i have multiple remotes and it had](https://youtu.be/mbmprym9SDM?t=00h47m06s)

[to ask me which one i wanted to push to](https://youtu.be/mbmprym9SDM?t=00h47m08s)

[in this case because there's only one it](https://youtu.be/mbmprym9SDM?t=00h47m10s)

[just made the assumption that it's the](https://youtu.be/mbmprym9SDM?t=00h47m12s)

[one that's there](https://youtu.be/mbmprym9SDM?t=00h47m14s)

[that's pretty good that's pretty good](https://youtu.be/mbmprym9SDM?t=00h47m16s)

[okay um](https://youtu.be/mbmprym9SDM?t=00h47m19s)

[okay so this was another one](https://youtu.be/mbmprym9SDM?t=00h47m21s)

[uh](https://youtu.be/mbmprym9SDM?t=00h47m24s)

[that i couldn't do so hang on i kind of](https://youtu.be/mbmprym9SDM?t=00h47m25s)

[want to look at this so what did i do](https://youtu.be/mbmprym9SDM?t=00h47m26s)

[wrong](https://youtu.be/mbmprym9SDM?t=00h47m28s)

[grpc exception so](https://youtu.be/mbmprym9SDM?t=00h47m30s)

[so i app start remote](https://youtu.be/mbmprym9SDM?t=00h47m35s)

[this is n unit](https://youtu.be/mbmprym9SDM?t=00h47m42s)

[that's fine i think n unit this is the](https://youtu.be/mbmprym9SDM?t=00h47m45s)

[way one would expect it](https://youtu.be/mbmprym9SDM?t=00h47m48s)

[so when it goes to start the remote](https://youtu.be/mbmprym9SDM?t=00h47m50s)

[it's being pointed at this](https://youtu.be/mbmprym9SDM?t=00h47m54s)

[at this app here](https://youtu.be/mbmprym9SDM?t=00h48m04s)

[so this is pro so i suspect the issue](https://youtu.be/mbmprym9SDM?t=00h48m10s)

[um](https://youtu.be/mbmprym9SDM?t=00h48m14s)

[unavailable failed to connect to all](https://youtu.be/mbmprym9SDM?t=00h48m18s)

[addresses](https://youtu.be/mbmprym9SDM?t=00h48m19s)

[this is probably an indication so i](https://youtu.be/mbmprym9SDM?t=00h48m26s)

[think we can fix this](https://youtu.be/mbmprym9SDM?t=00h48m28s)

[well](https://youtu.be/mbmprym9SDM?t=00h48m30s)

[i don't think we can fix this what i](https://youtu.be/mbmprym9SDM?t=00h48m31s)

[think is happening](https://youtu.be/mbmprym9SDM?t=00h48m33s)

[is the app that's being started up is](https://youtu.be/mbmprym9SDM?t=00h48m35s)

[crashing on startup for some reason it](https://youtu.be/mbmprym9SDM?t=00h48m37s)

[could be a number of different things](https://youtu.be/mbmprym9SDM?t=00h48m40s)

[that cause it](https://youtu.be/mbmprym9SDM?t=00h48m42s)

[but because it's crashing on startup](https://youtu.be/mbmprym9SDM?t=00h48m44s)

[that is not apparent](https://youtu.be/mbmprym9SDM?t=00h48m47s)

[and so you end up with when it tries to](https://youtu.be/mbmprym9SDM?t=00h48m50s)

[go out because you'll note this setup](https://youtu.be/mbmprym9SDM?t=00h48m52s)

[here is occurring and it's trying to](https://youtu.be/mbmprym9SDM?t=00h48m54s)

[reach out to the application that it got](https://youtu.be/mbmprym9SDM?t=00h48m56s)

[great](https://youtu.be/mbmprym9SDM?t=00h48m58s)

[like this is this is this is roughly the](https://youtu.be/mbmprym9SDM?t=00h48m59s)

[steps that you would do with xaml test](https://youtu.be/mbmprym9SDM?t=00h49m01s)

[is you would start an application](https://youtu.be/mbmprym9SDM?t=00h49m03s)

[and then you would reach out and grab](https://youtu.be/mbmprym9SDM?t=00h49m05s)

[the main window or all the windows in it](https://youtu.be/mbmprym9SDM?t=00h49m07s)

[right over them it's whatever](https://youtu.be/mbmprym9SDM?t=00h49m09s)

[usually main windows where people start](https://youtu.be/mbmprym9SDM?t=00h49m11s)

[um](https://youtu.be/mbmprym9SDM?t=00h49m13s)

[should i call application initialize i](https://youtu.be/mbmprym9SDM?t=00h49m15s)

[didn't understand exactly if this should](https://youtu.be/mbmprym9SDM?t=00h49m17s)

[be called when using start remote i](https://youtu.be/mbmprym9SDM?t=00h49m19s)

[don't think so i don't think so let's so](https://youtu.be/mbmprym9SDM?t=00h49m21s)

[one](https://youtu.be/mbmprym9SDM?t=00h49m23s)

[clearly i haven't documented this well](https://youtu.be/mbmprym9SDM?t=00h49m24s)

[enough](https://youtu.be/mbmprym9SDM?t=00h49m26s)

[um let's come in here](https://youtu.be/mbmprym9SDM?t=00h49m28s)

[because for example this this is the](https://youtu.be/mbmprym9SDM?t=00h49m32s)

[this is the example](https://youtu.be/mbmprym9SDM?t=00h49m35s)

[that most people](https://youtu.be/mbmprym9SDM?t=00h49m37s)

[should follow right i have a test](https://youtu.be/mbmprym9SDM?t=00h49m39s)

[project this one here i have a wpf app](https://youtu.be/mbmprym9SDM?t=00h49m41s)

[which this is a very this is a very](https://youtu.be/mbmprym9SDM?t=00h49m45s)

[simplistic wpf app](https://youtu.be/mbmprym9SDM?t=00h49m47s)

[nothing fancy](https://youtu.be/mbmprym9SDM?t=00h49m49s)

[um](https://youtu.be/mbmprym9SDM?t=00h49m52s)

[and you just call start remote and it](https://youtu.be/mbmprym9SDM?t=00h49m58s)

[does the needful for you](https://youtu.be/mbmprym9SDM?t=00h50m00s)

[so](https://youtu.be/mbmprym9SDM?t=00h50m02s)

[if we come in here](https://youtu.be/mbmprym9SDM?t=00h50m03s)

[i](https://youtu.be/mbmprym9SDM?t=00h50m06s)

[you shouldn't need to call initialize](https://youtu.be/mbmprym9SDM?t=00h50m07s)

[i'm actually surprised that that was](https://youtu.be/mbmprym9SDM?t=00h50m11s)

[even a choice](https://youtu.be/mbmprym9SDM?t=00h50m13s)

[oh](https://youtu.be/mbmprym9SDM?t=00h50m18s)

[i guess that is a question you might](https://youtu.be/mbmprym9SDM?t=00h50m20s)

[need to call it depending on what you](https://youtu.be/mbmprym9SDM?t=00h50m22s)

[need](https://youtu.be/mbmprym9SDM?t=00h50m24s)

[you might need to call it depending on](https://youtu.be/mbmprym9SDM?t=00h50m27s)

[what you need](https://youtu.be/mbmprym9SDM?t=00h50m29s)

[so](https://youtu.be/mbmprym9SDM?t=00h50m32s)

[so one this is this is expected to be](https://youtu.be/mbmprym9SDM?t=00h50m33s)

[used to populate like xaml resources as](https://youtu.be/mbmprym9SDM?t=00h50m35s)

[well as](https://youtu.be/mbmprym9SDM?t=00h50m38s)

[[Music]](https://youtu.be/mbmprym9SDM?t=00h50m41s)

[dependent assemblies so if there is](https://youtu.be/mbmprym9SDM?t=00h50m47s)

[additional assemblies that you need to](https://youtu.be/mbmprym9SDM?t=00h50m49s)

[load](https://youtu.be/mbmprym9SDM?t=00h50m52s)

[it's a little disappointing that it](https://youtu.be/mbmprym9SDM?t=00h50m54s)

[doesn't automatically just load them](https://youtu.be/mbmprym9SDM?t=00h50m55s)

[it should well you shouldn't need to](https://youtu.be/mbmprym9SDM?t=00h51m00s)

[necessarily load all the assemblies](https://youtu.be/mbmprym9SDM?t=00h51m02s)

[if you're launching an app and the app](https://youtu.be/mbmprym9SDM?t=00h51m05s)

[has them referenced they should](https://youtu.be/mbmprym9SDM?t=00h51m07s)

[automatically exist there](https://youtu.be/mbmprym9SDM?t=00h51m09s)

[so you shouldn't necessarily need to](https://youtu.be/mbmprym9SDM?t=00h51m12s)

[call it](https://youtu.be/mbmprym9SDM?t=00h51m14s)

[for example this this works](https://youtu.be/mbmprym9SDM?t=00h51m16s)

[here right so let's](https://youtu.be/mbmprym9SDM?t=00h51m19s)

[proof is in the pudding let's run my own](https://youtu.be/mbmprym9SDM?t=00h51m21s)

[test](https://youtu.be/mbmprym9SDM?t=00h51m22s)

[okay my own test fails that's that's not](https://youtu.be/mbmprym9SDM?t=00h51m37s)

[that's not a that's not a very ringing](https://youtu.be/mbmprym9SDM?t=00h51m40s)

[endorsement](https://youtu.be/mbmprym9SDM?t=00h51m42s)

[um](https://youtu.be/mbmprym9SDM?t=00h51m44s)

[well then](https://youtu.be/mbmprym9SDM?t=00h51m50s)

[okay my assertion that this just works](https://youtu.be/mbmprym9SDM?t=00h51m54s)

[out the gate is a failure and i'm now](https://youtu.be/mbmprym9SDM?t=00h51m57s)

[slightly interested in how my ci cd is](https://youtu.be/mbmprym9SDM?t=00h52m01s)

[passing](https://youtu.be/mbmprym9SDM?t=00h52m03s)

[please tell me i run run all my tests as](https://youtu.be/mbmprym9SDM?t=00h52m07s)

[part of my build](https://youtu.be/mbmprym9SDM?t=00h52m10s)

[the tests run](https://youtu.be/mbmprym9SDM?t=00h52m15s)

[huh](https://youtu.be/mbmprym9SDM?t=00h52m18s)

[how](https://youtu.be/mbmprym9SDM?t=00h52m20s)

[okay let's let's](https://youtu.be/mbmprym9SDM?t=00h52m26s)

[and apparently my other thing just](https://youtu.be/mbmprym9SDM?t=00h52m31s)

[passed](https://youtu.be/mbmprym9SDM?t=00h52m33s)

[let's](https://youtu.be/mbmprym9SDM?t=00h52m36s)

[let's just check that](https://youtu.be/mbmprym9SDM?t=00h52m37s)

[it claims all the test paths](https://youtu.be/mbmprym9SDM?t=00h52m39s)

[it claims all of the tests just passed](https://youtu.be/mbmprym9SDM?t=00h52m46s)

[build test](https://youtu.be/mbmprym9SDM?t=00h52m50s)

[632 tests passed](https://youtu.be/mbmprym9SDM?t=00h52m54s)

[okay how many tests does this thing cut](https://youtu.be/mbmprym9SDM?t=00h52m58s)

[that that sounds like a 632 test okay so](https://youtu.be/mbmprym9SDM?t=00h53m00s)

[it ran them all and they all passed](https://youtu.be/mbmprym9SDM?t=00h53m03s)

[okay well it's good that it](https://youtu.be/mbmprym9SDM?t=00h53m05s)

[passes there but then fails on my box](https://youtu.be/mbmprym9SDM?t=00h53m09s)

[what](https://youtu.be/mbmprym9SDM?t=00h53m11s)

[that is](https://youtu.be/mbmprym9SDM?t=00h53m14s)

[interesting](https://youtu.be/mbmprym9SDM?t=00h53m15s)

[to say the least](https://youtu.be/mbmprym9SDM?t=00h53m17s)

[okay so we've got well okay well we've](https://youtu.be/mbmprym9SDM?t=00h53m21s)

[got reproduction for the bug](https://youtu.be/mbmprym9SDM?t=00h53m23s)

[because this is exactly what is there](https://youtu.be/mbmprym9SDM?t=00h53m25s)

[and now let's figure out why it's](https://youtu.be/mbmprym9SDM?t=00h53m27s)

[failing](https://youtu.be/mbmprym9SDM?t=00h53m30s)

[so my assertion on the app is failing to](https://youtu.be/mbmprym9SDM?t=00h53m32s)

[start](https://youtu.be/mbmprym9SDM?t=00h53m35s)

[uh so let's let's actually leverage our](https://youtu.be/mbmprym9SDM?t=00h53m37s)

[new little](https://youtu.be/mbmprym9SDM?t=00h53m39s)

[uh](https://youtu.be/mbmprym9SDM?t=00h53m41s)

[allow debugger attach](https://youtu.be/mbmprym9SDM?t=00h53m42s)

[false](https://youtu.be/mbmprym9SDM?t=00h53m45s)

[[Music]](https://youtu.be/mbmprym9SDM?t=00h53m48s)

[let's run a debug](https://youtu.be/mbmprym9SDM?t=00h53m49s)

[okay so the app the app started](https://youtu.be/mbmprym9SDM?t=00h54m05s)

[oh](https://youtu.be/mbmprym9SDM?t=00h54m11s)

[okay so the app launched](https://youtu.be/mbmprym9SDM?t=00h54m12s)

[i got to here](https://youtu.be/mbmprym9SDM?t=00h54m15s)

[oh](https://youtu.be/mbmprym9SDM?t=00h54m21s)

[interesting](https://youtu.be/mbmprym9SDM?t=00h54m23s)

[interesting so the debugger attaches](https://youtu.be/mbmprym9SDM?t=00h54m25s)

[actually causing the problem](https://youtu.be/mbmprym9SDM?t=00h54m28s)

[okay so maybe this is timing related](https://youtu.be/mbmprym9SDM?t=00h54m36s)

[maybe this is timing related](https://youtu.be/mbmprym9SDM?t=00h54m40s)

[so](https://youtu.be/mbmprym9SDM?t=00h54m48s)

[so that](https://youtu.be/mbmprym9SDM?t=00h54m52s)

[that just went green](https://youtu.be/mbmprym9SDM?t=00h54m54s)

[wait what](https://youtu.be/mbmprym9SDM?t=00h54m57s)

[didn't we](https://youtu.be/mbmprym9SDM?t=00h54m59s)

[oh no](https://youtu.be/mbmprym9SDM?t=00h55m02s)

[this](https://youtu.be/mbmprym9SDM?t=00h55m05s)

[this is not good](https://youtu.be/mbmprym9SDM?t=00h55m06s)

[this is not good](https://youtu.be/mbmprym9SDM?t=00h55m10s)

[hahaha](https://youtu.be/mbmprym9SDM?t=00h55m18s)

[so a loud debugger attach of true](https://youtu.be/mbmprym9SDM?t=00h55m20s)

[and debugging](https://youtu.be/mbmprym9SDM?t=00h55m24s)

[results in](https://youtu.be/mbmprym9SDM?t=00h55m26s)

[and it's specifically okay](https://youtu.be/mbmprym9SDM?t=00h55m32s)

[yeah so it is crashing and attach in the](https://youtu.be/mbmprym9SDM?t=00h55m34s)

[visual studio attach](https://youtu.be/mbmprym9SDM?t=00h55m37s)

[line 40.](https://youtu.be/mbmprym9SDM?t=00h55m41s)

[uh why are you not going there](https://youtu.be/mbmprym9SDM?t=00h55m44s)

[attach](https://youtu.be/mbmprym9SDM?t=00h55m50s)

[so you should not fail](https://youtu.be/mbmprym9SDM?t=00h55m52s)

[but you are](https://youtu.be/mbmprym9SDM?t=00h55m58s)

[so the message filter indicated the](https://youtu.be/mbmprym9SDM?t=00h56m07s)

[application is busy](https://youtu.be/mbmprym9SDM?t=00h56m09s)

[retry later okay well so this thing's](https://youtu.be/mbmprym9SDM?t=00h56m11s)

[clearly not retrying](https://youtu.be/mbmprym9SDM?t=00h56m14s)

[process get process id so in](https://youtu.be/mbmprym9SDM?t=00h56m17s)

[nc sharp when if you see get underscore](https://youtu.be/mbmprym9SDM?t=00h56m20s)

[process id](https://youtu.be/mbmprym9SDM?t=00h56m24s)

[this is actually what](https://youtu.be/mbmprym9SDM?t=00h56m25s)

[auto properties end up compiling into](https://youtu.be/mbmprym9SDM?t=00h56m28s)

[or i guess properties in general](https://youtu.be/mbmprym9SDM?t=00h56m32s)

[so](https://youtu.be/mbmprym9SDM?t=00h56m35s)

[that's this method here where is a](https://youtu.be/mbmprym9SDM?t=00h56m38s)

[proper a process id](https://youtu.be/mbmprym9SDM?t=00h56m40s)

[parent local processes get dte process](https://youtu.be/mbmprym9SDM?t=00h56m49s)

[process id so this is a first or default](https://youtu.be/mbmprym9SDM?t=00h56m54s)

[call](https://youtu.be/mbmprym9SDM?t=00h56m57s)

[um](https://youtu.be/mbmprym9SDM?t=00h57m01s)

[okay so i think we need to do a couple](https://youtu.be/mbmprym9SDM?t=00h57m02s)

[things here](https://youtu.be/mbmprym9SDM?t=00h57m04s)

[so the nice part](https://youtu.be/mbmprym9SDM?t=00h57m08s)

[uh](https://youtu.be/mbmprym9SDM?t=00h57m11s)

[chin undercover thanks for the follow i](https://youtu.be/mbmprym9SDM?t=00h57m13s)

[appreciate it](https://youtu.be/mbmprym9SDM?t=00h57m15s)

[playing with my xaml test library i](https://youtu.be/mbmprym9SDM?t=00h57m17s)

[guess i i never actually even shared a](https://youtu.be/mbmprym9SDM?t=00h57m19s)

[link](https://youtu.be/mbmprym9SDM?t=00h57m21s)

[well let's just fix that real quick](https://youtu.be/mbmprym9SDM?t=00h57m22s)

[uh copy link](https://youtu.be/mbmprym9SDM?t=00h57m24s)

[there's a link to the project](https://youtu.be/mbmprym9SDM?t=00h57m27s)

[there was an issue reported that i](https://youtu.be/mbmprym9SDM?t=00h57m29s)

[thought was not an issue](https://youtu.be/mbmprym9SDM?t=00h57m31s)

[and](https://youtu.be/mbmprym9SDM?t=00h57m33s)

[hey we merged this](https://youtu.be/mbmprym9SDM?t=00h57m34s)

[didn't i oh i didn't actually hit the](https://youtu.be/mbmprym9SDM?t=00h57m37s)

[merge button](https://youtu.be/mbmprym9SDM?t=00h57m39s)

[um](https://youtu.be/mbmprym9SDM?t=00h57m40s)

[i should hit the merge button](https://youtu.be/mbmprym9SDM?t=00h57m42s)

[there was an issue i thought was a](https://youtu.be/mbmprym9SDM?t=00h57m45s)

[non-issue and it turns out it is a](https://youtu.be/mbmprym9SDM?t=00h57m48s)

[real issue](https://youtu.be/mbmprym9SDM?t=00h57m52s)

[and](https://youtu.be/mbmprym9SDM?t=00h57m53s)

[now i'm trying to figure out how to fix](https://youtu.be/mbmprym9SDM?t=00h57m55s)

[it](https://youtu.be/mbmprym9SDM?t=00h57m56s)

[and it appears](https://youtu.be/mbmprym9SDM?t=00h57m58s)

[watch squash merch it appears that this](https://youtu.be/mbmprym9SDM?t=00h58m00s)

[is related to](https://youtu.be/mbmprym9SDM?t=00h58m03s)

[see was there a stack trace here there's](https://youtu.be/mbmprym9SDM?t=00h58m05s)

[not a stacked race](https://youtu.be/mbmprym9SDM?t=00h58m07s)

[but we did see this exact issue occur](https://youtu.be/mbmprym9SDM?t=00h58m09s)

[and it feels very timing related](https://youtu.be/mbmprym9SDM?t=00h58m12s)

[yeah i'm thinking this issue here](https://youtu.be/mbmprym9SDM?t=00h58m17s)

[get attached visual studio so this is](https://youtu.be/mbmprym9SDM?t=00h58m21s)

[something that shouldn't](https://youtu.be/mbmprym9SDM?t=00h58m24s)

[matter](https://youtu.be/mbmprym9SDM?t=00h58m26s)

[because this will end up returning it so](https://youtu.be/mbmprym9SDM?t=00h58m33s)

[we know we got past this because get](https://youtu.be/mbmprym9SDM?t=00h58m35s)

[attached visual studio process if it](https://youtu.be/mbmprym9SDM?t=00h58m36s)

[returns null you drop out of here](https://youtu.be/mbmprym9SDM?t=00h58m38s)

[and i'm kind of thinking](https://youtu.be/mbmprym9SDM?t=00h58m43s)

[so i've got a small little weight class](https://youtu.be/mbmprym9SDM?t=00h58m47s)

[that's already built in](https://youtu.be/mbmprym9SDM?t=00h58m49s)

[that can wait for boolean conditions to](https://youtu.be/mbmprym9SDM?t=00h58m51s)

[occur](https://youtu.be/mbmprym9SDM?t=00h58m53s)

[oh look telescope namespace boom done](https://youtu.be/mbmprym9SDM?t=00h58m55s)

[um](https://youtu.be/mbmprym9SDM?t=00h58m57s)

[i'm thinking i might just leverage this](https://youtu.be/mbmprym9SDM?t=00h59m03s)

[it's a very simplistic try catch retry](https://youtu.be/mbmprym9SDM?t=00h59m09s)

[it's not nearly as advanced as something](https://youtu.be/mbmprym9SDM?t=00h59m13s)

[like the the poly library](https://youtu.be/mbmprym9SDM?t=00h59m15s)

[for people who are](https://youtu.be/mbmprym9SDM?t=00h59m18s)

[interested](https://youtu.be/mbmprym9SDM?t=00h59m20s)

[uh let's see](https://youtu.be/mbmprym9SDM?t=00h59m22s)

[paulie retry](https://youtu.be/mbmprym9SDM?t=00h59m23s)

[c sharp something something something](https://youtu.be/mbmprym9SDM?t=00h59m25s)

[uh](https://youtu.be/mbmprym9SDM?t=00h59m29s)

[where is it boom this guy](https://youtu.be/mbmprym9SDM?t=00h59m30s)

[yeah for people who are interested in it](https://youtu.be/mbmprym9SDM?t=00h59m34s)

[paulie is paulie is a wonderful library](https://youtu.be/mbmprym9SDM?t=00h59m36s)

[if you're interested in having uh right](https://youtu.be/mbmprym9SDM?t=00h59m39s)

[let me phrase implementing like retry](https://youtu.be/mbmprym9SDM?t=00h59m42s)

[circuit breaker timeout bulkhead](https://youtu.be/mbmprym9SDM?t=00h59m44s)

[isolation they've got a whole bunch rate](https://youtu.be/mbmprym9SDM?t=00h59m46s)

[limiting](https://youtu.be/mbmprym9SDM?t=00h59m47s)

[um](https://youtu.be/mbmprym9SDM?t=00h59m49s)

[and actually they've got some really](https://youtu.be/mbmprym9SDM?t=00h59m51s)

[great samples down here i thought about](https://youtu.be/mbmprym9SDM?t=00h59m52s)

[taking the dependency on poly for this](https://youtu.be/mbmprym9SDM?t=00h59m54s)

[library just for this](https://youtu.be/mbmprym9SDM?t=00h59m56s)

[a lot of people use it for](https://youtu.be/mbmprym9SDM?t=00h59m58s)

[networking related stuff because there's](https://youtu.be/mbmprym9SDM?t=01h00m00s)

[nice built-in helpers for like asp.net](https://youtu.be/mbmprym9SDM?t=01h00m02s)

[core](https://youtu.be/mbmprym9SDM?t=01h00m05s)

[http client that kind of that kind of](https://youtu.be/mbmprym9SDM?t=01h00m06s)

[fun stuff](https://youtu.be/mbmprym9SDM?t=01h00m08s)

[um](https://youtu.be/mbmprym9SDM?t=01h00m09s)

[but](https://youtu.be/mbmprym9SDM?t=01h00m11s)

[yeah](https://youtu.be/mbmprym9SDM?t=01h00m13s)

[but i i rolled my own for this library](https://youtu.be/mbmprym9SDM?t=01h00m16s)

[just to keep the dependency tree light](https://youtu.be/mbmprym9SDM?t=01h00m18s)

[and i'm kind of thinking](https://youtu.be/mbmprym9SDM?t=01h00m21s)

[we're going to do something like this](https://youtu.be/mbmprym9SDM?t=01h00m24s)

[because i i think what i want](https://youtu.be/mbmprym9SDM?t=01h00m25s)

[is a wait for](https://youtu.be/mbmprym9SDM?t=01h00m28s)

[um and we're just gonna pause it there](https://youtu.be/mbmprym9SDM?t=01h00m33s)

[so it wants to take in a lambda and i](https://youtu.be/mbmprym9SDM?t=01h00m36s)

[could put all of this in a lambda](https://youtu.be/mbmprym9SDM?t=01h00m38s)

[but i think what i almost want to do is](https://youtu.be/mbmprym9SDM?t=01h00m41s)

[static](https://youtu.be/mbmprym9SDM?t=01h00m45s)

[bool](https://youtu.be/mbmprym9SDM?t=01h00m46s)

[uh](https://youtu.be/mbmprym9SDM?t=01h00m48s)

[copy not paste](https://youtu.be/mbmprym9SDM?t=01h00m50s)

[uh implementation](https://youtu.be/mbmprym9SDM?t=01h00m52s)

[process](https://youtu.be/mbmprym9SDM?t=01h00m56s)

[location](https://youtu.be/mbmprym9SDM?t=01h00m58s)

[process](https://youtu.be/mbmprym9SDM?t=01h00m59s)

[and then this guy goes here](https://youtu.be/mbmprym9SDM?t=01h01m03s)

[this guy goes here](https://youtu.be/mbmprym9SDM?t=01h01m05s)

[and then](https://youtu.be/mbmprym9SDM?t=01h01m11s)

[this guy](https://youtu.be/mbmprym9SDM?t=01h01m13s)

[goes here](https://youtu.be/mbmprym9SDM?t=01h01m15s)

[and this is gonna want a](https://youtu.be/mbmprym9SDM?t=01h01m18s)

[thingy passed into it so we'll go with](https://youtu.be/mbmprym9SDM?t=01h01m21s)

[application process](https://youtu.be/mbmprym9SDM?t=01h01m24s)

[and then i don't know if i want to](https://youtu.be/mbmprym9SDM?t=01h01m26s)

[specify a retry policy but i do want to](https://youtu.be/mbmprym9SDM?t=01h01m28s)

[do a message](https://youtu.be/mbmprym9SDM?t=01h01m31s)

[uh let's see](https://youtu.be/mbmprym9SDM?t=01h01m33s)

[failed to attach](https://youtu.be/mbmprym9SDM?t=01h01m36s)

[visual studio](https://youtu.be/mbmprym9SDM?t=01h01m41s)

[to the](https://youtu.be/mbmprym9SDM?t=01h01m44s)

[xaml](https://youtu.be/mbmprym9SDM?t=01h01m46s)

[test](https://youtu.be/mbmprym9SDM?t=01h01m48s)

[post](https://youtu.be/mbmprym9SDM?t=01h01m50s)

[process](https://youtu.be/mbmprym9SDM?t=01h01m50s)

[okay and what is your problem here](https://youtu.be/mbmprym9SDM?t=01h01m53s)

[oh because this wants a](https://youtu.be/mbmprym9SDM?t=01h01m57s)

[task of boolean](https://youtu.be/mbmprym9SDM?t=01h01m59s)

[task](https://youtu.be/mbmprym9SDM?t=01h02m01s)

[i'm trying to remember what is the](https://youtu.be/mbmprym9SDM?t=01h02m07s)

[it does do so the the retry allows for](https://youtu.be/mbmprym9SDM?t=01h02m14s)

[specifying some amount of delay](https://youtu.be/mbmprym9SDM?t=01h02m17s)

[into it](https://youtu.be/mbmprym9SDM?t=01h02m21s)

[so the the the minimum number of](https://youtu.be/mbmprym9SDM?t=01h02m22s)

[attempts and then a timeout](https://youtu.be/mbmprym9SDM?t=01h02m24s)

[if i recall correctly it will do like](https://youtu.be/mbmprym9SDM?t=01h02m28s)

[three tries over five seconds or](https://youtu.be/mbmprym9SDM?t=01h02m31s)

[something like that](https://youtu.be/mbmprym9SDM?t=01h02m33s)

[uh let's see](https://youtu.be/mbmprym9SDM?t=01h02m35s)

[should we try](https://youtu.be/mbmprym9SDM?t=01h02m41s)

[what is the default oh](https://youtu.be/mbmprym9SDM?t=01h02m44s)

[the default yeah so retry with a minimum](https://youtu.be/mbmprym9SDM?t=01h02m46s)

[of three attempts or for two seconds](https://youtu.be/mbmprym9SDM?t=01h02m50s)

[i think we're gonna](https://youtu.be/mbmprym9SDM?t=01h02m53s)

[we're actually gonna bump that up](https://youtu.be/mbmprym9SDM?t=01h02m54s)

[um because i would like it to try a](https://youtu.be/mbmprym9SDM?t=01h02m57s)

[little longer than that knowing how much](https://youtu.be/mbmprym9SDM?t=01h03m00s)

[effort goes into it so](https://youtu.be/mbmprym9SDM?t=01h03m02s)

[a retry will be a new retry](https://youtu.be/mbmprym9SDM?t=01h03m05s)

[and we're going to say i want you to try](https://youtu.be/mbmprym9SDM?t=01h03m09s)

[at least five times](https://youtu.be/mbmprym9SDM?t=01h03m11s)

[with a time span of 15 seconds](https://youtu.be/mbmprym9SDM?t=01h03m13s)

[uh](https://youtu.be/mbmprym9SDM?t=01h03m22s)

[[Music]](https://youtu.be/mbmprym9SDM?t=01h03m23s)

[retry does not have a parent oh i'm](https://youtu.be/mbmprym9SDM?t=01h03m27s)

[missing a closing paren](https://youtu.be/mbmprym9SDM?t=01h03m30s)

[and then this should become an async i'm](https://youtu.be/mbmprym9SDM?t=01h03m33s)

[a little surprised i didn't give myself](https://youtu.be/mbmprym9SDM?t=01h03m36s)

[a synchronous overload](https://youtu.be/mbmprym9SDM?t=01h03m38s)

[every single one of these is async](https://youtu.be/mbmprym9SDM?t=01h03m40s)

[okay](https://youtu.be/mbmprym9SDM?t=01h03m46s)

[uh](https://youtu.be/mbmprym9SDM?t=01h03m48s)

[i guess having this be async is not it's](https://youtu.be/mbmprym9SDM?t=01h03m56s)

[not that bad of a thing](https://youtu.be/mbmprym9SDM?t=01h03m58s)

[uh let's see](https://youtu.be/mbmprym9SDM?t=01h04m01s)

[sync](https://youtu.be/mbmprym9SDM?t=01h04m03s)

[because it does need to do a task.delay](https://youtu.be/mbmprym9SDM?t=01h04m05s)

[in order to do the](https://youtu.be/mbmprym9SDM?t=01h04m08s)

[retry that's not bad and then return](https://youtu.be/mbmprym9SDM?t=01h04m10s)

[there i think that's better](https://youtu.be/mbmprym9SDM?t=01h04m17s)

[uh](https://youtu.be/mbmprym9SDM?t=01h04m21s)

[can implicitly convert](https://youtu.be/mbmprym9SDM?t=01h04m25s)

[oh i actually want the bool back out in](https://youtu.be/mbmprym9SDM?t=01h04m30s)

[this case](https://youtu.be/mbmprym9SDM?t=01h04m32s)

[oh interesting okay so this this may not](https://youtu.be/mbmprym9SDM?t=01h04m40s)

[necessarily be what i want because this](https://youtu.be/mbmprym9SDM?t=01h04m42s)

[will end up throwing a timeout exception](https://youtu.be/mbmprym9SDM?t=01h04m44s)

[what does the call there's only one](https://youtu.be/mbmprym9SDM?t=01h04m49s)

[color of this](https://youtu.be/mbmprym9SDM?t=01h04m51s)

[the caller's ignoring the return anyway](https://youtu.be/mbmprym9SDM?t=01h04m53s)

[okay so this bool is worthless so we're](https://youtu.be/mbmprym9SDM?t=01h04m56s)

[just gonna simple solution get rid of](https://youtu.be/mbmprym9SDM?t=01h04m59s)

[the bool](https://youtu.be/mbmprym9SDM?t=01h05m01s)

[and then we don't need the return and](https://youtu.be/mbmprym9SDM?t=01h05m03s)

[that makes life a lot easier](https://youtu.be/mbmprym9SDM?t=01h05m05s)

[okay it's either going to work or it's](https://youtu.be/mbmprym9SDM?t=01h05m08s)

[going to throw](https://youtu.be/mbmprym9SDM?t=01h05m09s)

[this is probably better for all all](https://youtu.be/mbmprym9SDM?t=01h05m12s)

[parties concerned](https://youtu.be/mbmprym9SDM?t=01h05m14s)

[okay](https://youtu.be/mbmprym9SDM?t=01h05m17s)

[and i think this might be better](https://youtu.be/mbmprym9SDM?t=01h05m22s)

[um](https://youtu.be/mbmprym9SDM?t=01h05m30s)

[air list](https://youtu.be/mbmprym9SDM?t=01h05m37s)

[file is locked this is one of the other](https://youtu.be/mbmprym9SDM?t=01h05m39s)

[things is occasionally this library](https://youtu.be/mbmprym9SDM?t=01h05m41s)

[can't get itself stuck](https://youtu.be/mbmprym9SDM?t=01h05m43s)

[where it gets it running now the xaml](https://youtu.be/mbmprym9SDM?t=01h05m45s)

[test thing does technically have a we'll](https://youtu.be/mbmprym9SDM?t=01h05m47s)

[call it a heartbeat](https://youtu.be/mbmprym9SDM?t=01h05m50s)

[so i can show that real quick](https://youtu.be/mbmprym9SDM?t=01h05m52s)

[where is your heartbeat](https://youtu.be/mbmprym9SDM?t=01h05m56s)

[uh](https://youtu.be/mbmprym9SDM?t=01h05m58s)

[there is](https://youtu.be/mbmprym9SDM?t=01h05m59s)

[where is that timer there's a timer that](https://youtu.be/mbmprym9SDM?t=01h06m03s)

[ticks and if it doesn't hear back in so](https://youtu.be/mbmprym9SDM?t=01h06m05s)

[much time it kills it](https://youtu.be/mbmprym9SDM?t=01h06m08s)

[uh](https://youtu.be/mbmprym9SDM?t=01h06m11s)

[xaml test app oh is the oh the test host](https://youtu.be/mbmprym9SDM?t=01h06m12s)

[is probably keeping it alive isn't it uh](https://youtu.be/mbmprym9SDM?t=01h06m14s)

[sort by name](https://youtu.be/mbmprym9SDM?t=01h06m18s)

[i guess t is a little further down isn't](https://youtu.be/mbmprym9SDM?t=01h06m19s)

[it](https://youtu.be/mbmprym9SDM?t=01h06m21s)

[uh](https://youtu.be/mbmprym9SDM?t=01h06m22s)

[huh](https://youtu.be/mbmprym9SDM?t=01h06m26s)

[i'm the only one missing it](https://youtu.be/mbmprym9SDM?t=01h06m32s)

[is it buried in here somewhere](https://youtu.be/mbmprym9SDM?t=01h06m36s)

[start with this kill that one](https://youtu.be/mbmprym9SDM?t=01h06m39s)

[cut down the visual studio process i](https://youtu.be/mbmprym9SDM?t=01h06m43s)

[have to look at by one](https://youtu.be/mbmprym9SDM?t=01h06m44s)

[and i bet you it is](https://youtu.be/mbmprym9SDM?t=01h06m47s)

[yeah](https://youtu.be/mbmprym9SDM?t=01h06m49s)

[there you are](https://youtu.be/mbmprym9SDM?t=01h06m51s)

[found you](https://youtu.be/mbmprym9SDM?t=01h06m52s)

[okay](https://youtu.be/mbmprym9SDM?t=01h06m55s)

[try this again](https://youtu.be/mbmprym9SDM?t=01h06m57s)

[let's give this guy another shot](https://youtu.be/mbmprym9SDM?t=01h07m02s)

[[Music]](https://youtu.be/mbmprym9SDM?t=01h07m06s)

[i'm gonna update this](https://youtu.be/mbmprym9SDM?t=01h07m10s)

[there stream stream info updated](https://youtu.be/mbmprym9SDM?t=01h07m14s)

[since xaml test is cool](https://youtu.be/mbmprym9SDM?t=01h07m18s)

[uh okay so now you should run your test](https://youtu.be/mbmprym9SDM?t=01h07m20s)

[huh](https://youtu.be/mbmprym9SDM?t=01h07m24s)

[and then work magically](https://youtu.be/mbmprym9SDM?t=01h07m27s)

[okay and then debug](https://youtu.be/mbmprym9SDM?t=01h07m29s)

[what are you squawking about now oh](https://youtu.be/mbmprym9SDM?t=01h07m31s)

[you're not awaited](https://youtu.be/mbmprym9SDM?t=01h07m32s)

[that is](https://youtu.be/mbmprym9SDM?t=01h07m35s)

[that is a problem](https://youtu.be/mbmprym9SDM?t=01h07m36s)

[sweet](https://youtu.be/mbmprym9SDM?t=01h07m38s)

[oh i just absolutely love being able to](https://youtu.be/mbmprym9SDM?t=01h07m44s)

[attack](https://youtu.be/mbmprym9SDM?t=01h07m46s)

[so in case it wasn't obvious what that](https://youtu.be/mbmprym9SDM?t=01h07m47s)

[that was so you'll note this this app](https://youtu.be/mbmprym9SDM?t=01h07m49s)

[test real quick](https://youtu.be/mbmprym9SDM?t=01h07m52s)

[all right this is inside of](https://youtu.be/mbmprym9SDM?t=01h07m53s)

[my test project this test app inside of](https://youtu.be/mbmprym9SDM?t=01h07m56s)

[the main window](https://youtu.be/mbmprym9SDM?t=01h07m59s)

[inside of his constructor this is going](https://youtu.be/mbmprym9SDM?t=01h08m01s)

[to get started as a separate process](https://youtu.be/mbmprym9SDM?t=01h08m03s)

[i can debug into my other app](https://youtu.be/mbmprym9SDM?t=01h08m08s)

[this is kind of cool](https://youtu.be/mbmprym9SDM?t=01h08m11s)

[i would love to know how to do a a](https://youtu.be/mbmprym9SDM?t=01h08m14s)

[debugger attached for for rider as well](https://youtu.be/mbmprym9SDM?t=01h08m16s)

[so if anyone has insight into what that](https://youtu.be/mbmprym9SDM?t=01h08m19s)

[would look like that would be cool](https://youtu.be/mbmprym9SDM?t=01h08m21s)

[that is so slick](https://youtu.be/mbmprym9SDM?t=01h08m26s)

[so slick](https://youtu.be/mbmprym9SDM?t=01h08m28s)

[okay cool](https://youtu.be/mbmprym9SDM?t=01h08m29s)

[cool](https://youtu.be/mbmprym9SDM?t=01h08m31s)

[okay so that fixes that with debug](https://youtu.be/mbmprym9SDM?t=01h08m32s)

[attached](https://youtu.be/mbmprym9SDM?t=01h08m35s)

[and then so i think that was probably](https://youtu.be/mbmprym9SDM?t=01h08m37s)

[the issue is the debugger was causing](https://youtu.be/mbmprym9SDM?t=01h08m39s)

[things to slow down and die and it was](https://youtu.be/mbmprym9SDM?t=01h08m41s)

[timing related](https://youtu.be/mbmprym9SDM?t=01h08m43s)

[i think that is probably](https://youtu.be/mbmprym9SDM?t=01h08m48s)

[the answer](https://youtu.be/mbmprym9SDM?t=01h08m52s)

[is that little retry loop in there](https://youtu.be/mbmprym9SDM?t=01h08m54s)

[because now if it fails to attach you'll](https://youtu.be/mbmprym9SDM?t=01h08m58s)

[get a much better exception](https://youtu.be/mbmprym9SDM?t=01h08m59s)

[um the other thing](https://youtu.be/mbmprym9SDM?t=01h09m03s)

[let me just look here](https://youtu.be/mbmprym9SDM?t=01h09m05s)

[uh is the log message one it may be](https://youtu.be/mbmprym9SDM?t=01h09m07s)

[worth](https://youtu.be/mbmprym9SDM?t=01h09m10s)

[adding something to that and i](https://youtu.be/mbmprym9SDM?t=01h09m11s)

[i am wondering if this api should be](https://youtu.be/mbmprym9SDM?t=01h09m14s)

[improved](https://youtu.be/mbmprym9SDM?t=01h09m15s)

[because this log message just like it is](https://youtu.be/mbmprym9SDM?t=01h09m18s)

[chatty](https://youtu.be/mbmprym9SDM?t=01h09m20s)

[and it's designed to be chatty it's](https://youtu.be/mbmprym9SDM?t=01h09m22s)

[basically if you set this delegate](https://youtu.be/mbmprym9SDM?t=01h09m24s)

[you're going to get the verbose logs](https://youtu.be/mbmprym9SDM?t=01h09m26s)

[just coming back at you and i](https://youtu.be/mbmprym9SDM?t=01h09m27s)

[intentionally did them as a callback](https://youtu.be/mbmprym9SDM?t=01h09m29s)

[delegate to make them quote-unquote easy](https://youtu.be/mbmprym9SDM?t=01h09m30s)

[but i'm wondering if that's not](https://youtu.be/mbmprym9SDM?t=01h09m34s)

[i'm wondering if people would prefer to](https://youtu.be/mbmprym9SDM?t=01h09m37s)

[pass in something like an eye logger](https://youtu.be/mbmprym9SDM?t=01h09m39s)

[instead](https://youtu.be/mbmprym9SDM?t=01h09m40s)

[i don't know](https://youtu.be/mbmprym9SDM?t=01h09m44s)

[i did it this way that way i was pretty](https://youtu.be/mbmprym9SDM?t=01h09m45s)

[agnostic of your testing framework](https://youtu.be/mbmprym9SDM?t=01h09m47s)

[and you could just pass a delegate and](https://youtu.be/mbmprym9SDM?t=01h09m50s)

[in your delegate you call your login](https://youtu.be/mbmprym9SDM?t=01h09m52s)

[framework](https://youtu.be/mbmprym9SDM?t=01h09m54s)

[well let's let's give this a shot](https://youtu.be/mbmprym9SDM?t=01h09m56s)

[let's pull this up](https://youtu.be/mbmprym9SDM?t=01h10m00s)

[okay so](https://youtu.be/mbmprym9SDM?t=01h10m01s)

[this is actually a great example here](https://youtu.be/mbmprym9SDM?t=01h10m03s)

[too so you will note we were working on](https://youtu.be/mbmprym9SDM?t=01h10m04s)

[the fix for issue 64.](https://youtu.be/mbmprym9SDM?t=01h10m08s)

[that pr has merged into master](https://youtu.be/mbmprym9SDM?t=01h10m12s)

[but i did all of my work on this other](https://youtu.be/mbmprym9SDM?t=01h10m15s)

[branch](https://youtu.be/mbmprym9SDM?t=01h10m17s)

[now there's a couple ways i could go](https://youtu.be/mbmprym9SDM?t=01h10m19s)

[about doing this](https://youtu.be/mbmprym9SDM?t=01h10m20s)

[uh the long way of doing it is you stash](https://youtu.be/mbmprym9SDM?t=01h10m22s)

[switch branches](https://youtu.be/mbmprym9SDM?t=01h10m26s)

[create a new branch](https://youtu.be/mbmprym9SDM?t=01h10m28s)

[fix](https://youtu.be/mbmprym9SDM?t=01h10m30s)

[01:10:33,199 --> 01:10:37,120](https://youtu.be/mbmprym9SDM?t=01h10m31s)

right and then you pop

[and then you work](https://youtu.be/mbmprym9SDM?t=01h10m35s)

[the long one](https://youtu.be/mbmprym9SDM?t=01h10m37s)

[that works](https://youtu.be/mbmprym9SDM?t=01h10m38s)

[okay uh let's go back and we'll do this](https://youtu.be/mbmprym9SDM?t=01h10m40s)

[the the hard way too so i whack this](https://youtu.be/mbmprym9SDM?t=01h10m42s)

[right so that's that's the long way of](https://youtu.be/mbmprym9SDM?t=01h10m46s)

[doing it the short way of doing it](https://youtu.be/mbmprym9SDM?t=01h10m48s)

[should right click](https://youtu.be/mbmprym9SDM?t=01h10m50s)

[create branch](https://youtu.be/mbmprym9SDM?t=01h10m52s)

[fix 65](https://youtu.be/mbmprym9SDM?t=01h10m53s)

[boom see](https://youtu.be/mbmprym9SDM?t=01h10m56s)

[get cracking makes a lot of things go](https://youtu.be/mbmprym9SDM?t=01h10m58s)

[quicker a lot of things go quicker](https://youtu.be/mbmprym9SDM?t=01h11m00s)

[so](https://youtu.be/mbmprym9SDM?t=01h11m03s)

[it automatically jumped me so in get](https://youtu.be/mbmprym9SDM?t=01h11m04s)

[cracking when you create a new branch](https://youtu.be/mbmprym9SDM?t=01h11m06s)

[it's not apparent it automatically tries](https://youtu.be/mbmprym9SDM?t=01h11m07s)

[to switch you to that branch](https://youtu.be/mbmprym9SDM?t=01h11m09s)

[just generally what you want there's a](https://youtu.be/mbmprym9SDM?t=01h11m11s)

[handful of times where it's annoying but](https://youtu.be/mbmprym9SDM?t=01h11m12s)

[most of the time that's exactly what you](https://youtu.be/mbmprym9SDM?t=01h11m14s)

[want](https://youtu.be/mbmprym9SDM?t=01h11m16s)

[okay so we check we always review our](https://youtu.be/mbmprym9SDM?t=01h11m17s)

[work](https://youtu.be/mbmprym9SDM?t=01h11m20s)

[we come down here we flatten this so](https://youtu.be/mbmprym9SDM?t=01h11m22s)

[that it was a little more readable we](https://youtu.be/mbmprym9SDM?t=01h11m24s)

[added in a weight with a retry and made](https://youtu.be/mbmprym9SDM?t=01h11m26s)

[a local function](https://youtu.be/mbmprym9SDM?t=01h11m28s)

[uh we flattened up the catch block not a](https://youtu.be/mbmprym9SDM?t=01h11m30s)

[big deal either way sure that looks](https://youtu.be/mbmprym9SDM?t=01h11m32s)

[great](https://youtu.be/mbmprym9SDM?t=01h11m34s)

[the weight class](https://youtu.be/mbmprym9SDM?t=01h11m35s)

[uh this is something also that's worth](https://youtu.be/mbmprym9SDM?t=01h11m37s)

[noting so you'll note i switch this to a](https://youtu.be/mbmprym9SDM?t=01h11m38s)

[file scope namespace in general newer](https://youtu.be/mbmprym9SDM?t=01h11m41s)

[c-sharp code should probably use file](https://youtu.be/mbmprym9SDM?t=01h11m44s)

[scope namespaces](https://youtu.be/mbmprym9SDM?t=01h11m45s)

[[Music]](https://youtu.be/mbmprym9SDM?t=01h11m48s)

[in this case](https://youtu.be/mbmprym9SDM?t=01h11m50s)

[if you have white space turned on](https://youtu.be/mbmprym9SDM?t=01h11m51s)

[switching to file scope namespace is](https://youtu.be/mbmprym9SDM?t=01h11m52s)

[obnoxious so if you are making these](https://youtu.be/mbmprym9SDM?t=01h11m54s)

[changes](https://youtu.be/mbmprym9SDM?t=01h11m56s)

[turn on ignore white space](https://youtu.be/mbmprym9SDM?t=01h11m57s)

[let's see uh justin bieber hi are you](https://youtu.be/mbmprym9SDM?t=01h11m59s)

[running as a separate process don't you](https://youtu.be/mbmprym9SDM?t=01h12m02s)

[want to run in a subdomain](https://youtu.be/mbmprym9SDM?t=01h12m04s)

[i think you mean as a child process](https://youtu.be/mbmprym9SDM?t=01h12m08s)

[if i if i am understanding correctly](https://youtu.be/mbmprym9SDM?t=01h12m12s)

[there is so](https://youtu.be/mbmprym9SDM?t=01h12m15s)

[the answer is yes ish and i kind of am](https://youtu.be/mbmprym9SDM?t=01h12m17s)

[and kind of not so inside of](https://youtu.be/mbmprym9SDM?t=01h12m21s)

[windows](https://youtu.be/mbmprym9SDM?t=01h12m25s)

[let's see if i can find a quick thing](https://youtu.be/mbmprym9SDM?t=01h12m26s)

[windows](https://youtu.be/mbmprym9SDM?t=01h12m28s)

[process](https://youtu.be/mbmprym9SDM?t=01h12m30s)

[jobs](https://youtu.be/mbmprym9SDM?t=01h12m31s)

[there is this](https://youtu.be/mbmprym9SDM?t=01h12m34s)

[yeah](https://youtu.be/mbmprym9SDM?t=01h12m36s)

[this this ugly this ugly guy here](https://youtu.be/mbmprym9SDM?t=01h12m37s)

[within windows the the way you would](https://youtu.be/mbmprym9SDM?t=01h12m43s)

[typically register up so that your](https://youtu.be/mbmprym9SDM?t=01h12m46s)

[process dies when the parent process](https://youtu.be/mbmprym9SDM?t=01h12m48s)

[dies](https://youtu.be/mbmprym9SDM?t=01h12m50s)

[is with a job and you can do this in](https://youtu.be/mbmprym9SDM?t=01h12m51s)

[c-sharp it's not cross-plat this is a](https://youtu.be/mbmprym9SDM?t=01h12m53s)

[window-specific-y thing](https://youtu.be/mbmprym9SDM?t=01h12m56s)

[um](https://youtu.be/mbmprym9SDM?t=01h12m59s)

[but it does mean that when you get](https://youtu.be/mbmprym9SDM?t=01h13m01s)

[terminated you can close as well and i](https://youtu.be/mbmprym9SDM?t=01h13m04s)

[think let me look](https://youtu.be/mbmprym9SDM?t=01h13m07s)

[and look real quick i think i actually](https://youtu.be/mbmprym9SDM?t=01h13m09s)

[have a](https://youtu.be/mbmprym9SDM?t=01h13m11s)

[a little bit of sample code for this](https://youtu.be/mbmprym9SDM?t=01h13m14s)

[but i need to look](https://youtu.be/mbmprym9SDM?t=01h13m17s)

[[Music]](https://youtu.be/mbmprym9SDM?t=01h13m19s)

[because i also have a bunch of stuff in](https://youtu.be/mbmprym9SDM?t=01h13m20s)

[here that is](https://youtu.be/mbmprym9SDM?t=01h13m22s)

[not public so we're just going to be a](https://youtu.be/mbmprym9SDM?t=01h13m23s)

[little patient](https://youtu.be/mbmprym9SDM?t=01h13m25s)

[to do](https://youtu.be/mbmprym9SDM?t=01h13m28s)

[got to just scan](https://youtu.be/mbmprym9SDM?t=01h13m30s)

[i wish there was a search function in](https://youtu.be/mbmprym9SDM?t=01h13m34s)

[here](https://youtu.be/mbmprym9SDM?t=01h13m36s)

[i'll put benchmarks](https://youtu.be/mbmprym9SDM?t=01h13m42s)

[maybe i don't have it](https://youtu.be/mbmprym9SDM?t=01h13m46s)

[i'm old enough now that i'm i think i'm](https://youtu.be/mbmprym9SDM?t=01h13m49s)

[past where i expected to find it](https://youtu.be/mbmprym9SDM?t=01h13m52s)

[yeah i don't see it um there is there is](https://youtu.be/mbmprym9SDM?t=01h14m00s)

[some code that i have uh](https://youtu.be/mbmprym9SDM?t=01h14m03s)

[it's based on an old code project thing](https://youtu.be/mbmprym9SDM?t=01h14m06s)

[that will actually do these nested jobs](https://youtu.be/mbmprym9SDM?t=01h14m08s)

[in c sharp for you to to terminate it](https://youtu.be/mbmprym9SDM?t=01h14m10s)

[it does involve a little uh](https://youtu.be/mbmprym9SDM?t=01h14m14s)

[p invoke stuff](https://youtu.be/mbmprym9SDM?t=01h14m17s)

[if your program crashes won't it kill](https://youtu.be/mbmprym9SDM?t=01h14m19s)

[the program that spawned it](https://youtu.be/mbmprym9SDM?t=01h14m21s)

[if the child crashes it won't kill the](https://youtu.be/mbmprym9SDM?t=01h14m22s)

[parent process if the parent crashes it](https://youtu.be/mbmprym9SDM?t=01h14m25s)

[if the parent crashes and you're](https://youtu.be/mbmprym9SDM?t=01h14m29s)

[attached with a a job it will kill the](https://youtu.be/mbmprym9SDM?t=01h14m30s)

[children normally what happens is when](https://youtu.be/mbmprym9SDM?t=01h14m33s)

[the](https://youtu.be/mbmprym9SDM?t=01h14m36s)

[uh parent terminates](https://youtu.be/mbmprym9SDM?t=01h14m37s)

[you you may or may not go down depending](https://youtu.be/mbmprym9SDM?t=01h14m40s)

[on how your process starts if you just](https://youtu.be/mbmprym9SDM?t=01h14m43s)

[do a blind](https://youtu.be/mbmprym9SDM?t=01h14m45s)

[process.start it won't necessarily](https://youtu.be/mbmprym9SDM?t=01h14m48s)

[terminate](https://youtu.be/mbmprym9SDM?t=01h14m52s)

[uh](https://youtu.be/mbmprym9SDM?t=01h14m53s)

[thanks for showing the white space](https://youtu.be/mbmprym9SDM?t=01h14m54s)

[setting for the diff i was just thinking](https://youtu.be/mbmprym9SDM?t=01h14m56s)

[about reverting that namespace change on](https://youtu.be/mbmprym9SDM?t=01h14m57s)

[a pr to reduce noise for the reviewer](https://youtu.be/mbmprym9SDM?t=01h14m59s)

[yeah](https://youtu.be/mbmprym9SDM?t=01h15m01s)

[so okay](https://youtu.be/mbmprym9SDM?t=01h15m02s)

[point of contention this is a kevin ism](https://youtu.be/mbmprym9SDM?t=01h15m05s)

[i personally believe that if i have to](https://youtu.be/mbmprym9SDM?t=01h15m08s)

[touch a file i should clean it up](https://youtu.be/mbmprym9SDM?t=01h15m10s)

[i i subscribe to the boy scout principle](https://youtu.be/mbmprym9SDM?t=01h15m12s)

[that says you always leave the code](https://youtu.be/mbmprym9SDM?t=01h15m14s)

[cleaner than when you found it](https://youtu.be/mbmprym9SDM?t=01h15m16s)

[however there is a](https://youtu.be/mbmprym9SDM?t=01h15m18s)

[alternate school of thought that says](https://youtu.be/mbmprym9SDM?t=01h15m20s)

[make as little changes as possible](https://youtu.be/mbmprym9SDM?t=01h15m22s)

[and only do like refactoring cleanup as](https://youtu.be/mbmprym9SDM?t=01h15m26s)

[as separate prs](https://youtu.be/mbmprym9SDM?t=01h15m28s)

[both sides have their pros and cons so](https://youtu.be/mbmprym9SDM?t=01h15m32s)

[on the side of the make changes as small](https://youtu.be/mbmprym9SDM?t=01h15m35s)

[as possible and only do refactoring as](https://youtu.be/mbmprym9SDM?t=01h15m38s)

[cleanup in other prs](https://youtu.be/mbmprym9SDM?t=01h15m40s)

[that i think is a is very good in](https://youtu.be/mbmprym9SDM?t=01h15m42s)

[principle and as long as your team has](https://youtu.be/mbmprym9SDM?t=01h15m44s)

[allocated time to do cleanup i think](https://youtu.be/mbmprym9SDM?t=01h15m47s)

[that that works](https://youtu.be/mbmprym9SDM?t=01h15m49s)

[the the problem that i see is oftentimes](https://youtu.be/mbmprym9SDM?t=01h15m50s)

[in processes](https://youtu.be/mbmprym9SDM?t=01h15m53s)

[that time never happens](https://youtu.be/mbmprym9SDM?t=01h15m55s)

[and if that cleanup is never occurring](https://youtu.be/mbmprym9SDM?t=01h15m57s)

[you're never actually making uh](https://youtu.be/mbmprym9SDM?t=01h15m59s)

[making progress](https://youtu.be/mbmprym9SDM?t=01h16m03s)

[um towards making your code cleaner so](https://youtu.be/mbmprym9SDM?t=01h16m04s)

[if you swing the pendulum the other](https://youtu.be/mbmprym9SDM?t=01h16m08s)

[direction on the boy scout principle you](https://youtu.be/mbmprym9SDM?t=01h16m09s)

[should probably not just change](https://youtu.be/mbmprym9SDM?t=01h16m11s)

[everything to filescope namespace](https://youtu.be/mbmprym9SDM?t=01h16m12s)

[willy-nilly because at a bare minimum](https://youtu.be/mbmprym9SDM?t=01h16m14s)

[it's going to bloat your pr size](https://youtu.be/mbmprym9SDM?t=01h16m16s)

[people should know to turn off white](https://youtu.be/mbmprym9SDM?t=01h16m18s)

[space when they're doing code reviews](https://youtu.be/mbmprym9SDM?t=01h16m19s)

[this is one of those things that i](https://youtu.be/mbmprym9SDM?t=01h16m22s)

[usually assume people know but it's not](https://youtu.be/mbmprym9SDM?t=01h16m23s)

[always apparent](https://youtu.be/mbmprym9SDM?t=01h16m25s)

[get cracking makes it easy](https://youtu.be/mbmprym9SDM?t=01h16m26s)

[most diff tools](https://youtu.be/mbmprym9SDM?t=01h16m28s)

[i think all i'm hesitant to say all but](https://youtu.be/mbmprym9SDM?t=01h16m31s)

[i think most if not all have a toggle](https://youtu.be/mbmprym9SDM?t=01h16m34s)

[white space option](https://youtu.be/mbmprym9SDM?t=01h16m36s)

[um](https://youtu.be/mbmprym9SDM?t=01h16m38s)

[i delete other people's useless comments](https://youtu.be/mbmprym9SDM?t=01h16m40s)

[that's my good deed when viewing code](https://youtu.be/mbmprym9SDM?t=01h16m42s)

[i love it i love it uh](https://youtu.be/mbmprym9SDM?t=01h16m44s)

[i have](https://youtu.be/mbmprym9SDM?t=01h16m48s)

[something interesting going on here](https://youtu.be/mbmprym9SDM?t=01h16m49s)

[uh i do love it so](https://youtu.be/mbmprym9SDM?t=01h16m53s)

[okay small tangent uh on the note of](https://youtu.be/mbmprym9SDM?t=01h16m56s)

[code comments i generally find that](https://youtu.be/mbmprym9SDM?t=01h16m59s)

[deleting](https://youtu.be/mbmprym9SDM?t=01h17m01s)

[comments](https://youtu.be/mbmprym9SDM?t=01h17m03s)

[a lot of people are i'll back up](https://youtu.be/mbmprym9SDM?t=01h17m06s)

[comments are very useful when you're](https://youtu.be/mbmprym9SDM?t=01h17m09s)

[documenting what the code or the why](https://youtu.be/mbmprym9SDM?t=01h17m10s)

[behind the code](https://youtu.be/mbmprym9SDM?t=01h17m13s)

[because the code usually tells you the](https://youtu.be/mbmprym9SDM?t=01h17m15s)

[what](https://youtu.be/mbmprym9SDM?t=01h17m17s)

[usually there are times where that where](https://youtu.be/mbmprym9SDM?t=01h17m19s)

[the what is not always apparent because](https://youtu.be/mbmprym9SDM?t=01h17m21s)

[you can write some really unreadable](https://youtu.be/mbmprym9SDM?t=01h17m22s)

[code at times so there](https://youtu.be/mbmprym9SDM?t=01h17m24s)

[um just last week](https://youtu.be/mbmprym9SDM?t=01h17m26s)

[i showed some code to a colleague and he](https://youtu.be/mbmprym9SDM?t=01h17m28s)

[looked at me he's like he's like i get](https://youtu.be/mbmprym9SDM?t=01h17m30s)

[it i understand why you did it you need](https://youtu.be/mbmprym9SDM?t=01h17m31s)

[to write some comments because if i saw](https://youtu.be/mbmprym9SDM?t=01h17m33s)

[that i would be fixing it i was like](https://youtu.be/mbmprym9SDM?t=01h17m35s)

[good point thank you so i did write some](https://youtu.be/mbmprym9SDM?t=01h17m37s)

[comments because there are times where](https://youtu.be/mbmprym9SDM?t=01h17m40s)

[the what](https://youtu.be/mbmprym9SDM?t=01h17m41s)

[may not be obvious there are there's](https://youtu.be/mbmprym9SDM?t=01h17m42s)

[some ways to subtly slip stuff in but in](https://youtu.be/mbmprym9SDM?t=01h17m44s)

[general the what is not necessarily](https://youtu.be/mbmprym9SDM?t=01h17m47s)

[something we're documenting the why](https://youtu.be/mbmprym9SDM?t=01h17m49s)

[however is very important because code](https://youtu.be/mbmprym9SDM?t=01h17m51s)

[can very rarely tell you the why](https://youtu.be/mbmprym9SDM?t=01h17m53s)

[um and in this case](https://youtu.be/mbmprym9SDM?t=01h17m56s)

[sorry switching back to my diff in this](https://youtu.be/mbmprym9SDM?t=01h17m58s)

[case this was an allowed debugging](https://youtu.be/mbmprym9SDM?t=01h18m00s)

[attach](https://youtu.be/mbmprym9SDM?t=01h18m02s)

[i i want the file scope name space i](https://youtu.be/mbmprym9SDM?t=01h18m03s)

[don't want this line so i can just right](https://youtu.be/mbmprym9SDM?t=01h18m05s)

[click and discard](https://youtu.be/mbmprym9SDM?t=01h18m07s)

[ah and you'll note as soon as i discard](https://youtu.be/mbmprym9SDM?t=01h18m08s)

[it automatically indented this thing and](https://youtu.be/mbmprym9SDM?t=01h18m11s)

[i don't want that so edit](https://youtu.be/mbmprym9SDM?t=01h18m13s)

[save close](https://youtu.be/mbmprym9SDM?t=01h18m16s)

[and](https://youtu.be/mbmprym9SDM?t=01h18m18s)

[go back show me that file again uh the](https://youtu.be/mbmprym9SDM?t=01h18m19s)

[test one](https://youtu.be/mbmprym9SDM?t=01h18m22s)

[so now i should just have the file scope](https://youtu.be/mbmprym9SDM?t=01h18m23s)

[namespace great](https://youtu.be/mbmprym9SDM?t=01h18m25s)

[and you'll note it has to kind of guess](https://youtu.be/mbmprym9SDM?t=01h18m27s)

[yes comments should be reserved for](https://youtu.be/mbmprym9SDM?t=01h18m29s)

[business logic business decisions in my](https://youtu.be/mbmprym9SDM?t=01h18m31s)

[opinion](https://youtu.be/mbmprym9SDM?t=01h18m33s)

[yeah in general and in general i would](https://youtu.be/mbmprym9SDM?t=01h18m36s)

[argue that is oftentimes the why for for](https://youtu.be/mbmprym9SDM?t=01h18m38s)

[why things were done](https://youtu.be/mbmprym9SDM?t=01h18m41s)

[like we did code this way because of x](https://youtu.be/mbmprym9SDM?t=01h18m44s)

[and sometimes they can be as simple like](https://youtu.be/mbmprym9SDM?t=01h18m48s)

[some i've seen people put in like links](https://youtu.be/mbmprym9SDM?t=01h18m51s)

[to your issue tracker which is okay-ish](https://youtu.be/mbmprym9SDM?t=01h18m52s)

[except for for your issue tracker ever](https://youtu.be/mbmprym9SDM?t=01h18m56s)

[changes](https://youtu.be/mbmprym9SDM?t=01h18m58s)

[you can kind of get hosed](https://youtu.be/mbmprym9SDM?t=01h18m59s)

[or if the issue gets edited](https://youtu.be/mbmprym9SDM?t=01h19m02s)

[so i i usually kind of like a link to an](https://youtu.be/mbmprym9SDM?t=01h19m04s)

[issue or a user story is great](https://youtu.be/mbmprym9SDM?t=01h19m07s)

[but i i always get a little twitchy if](https://youtu.be/mbmprym9SDM?t=01h19m10s)

[that's the only bit of the comment](https://youtu.be/mbmprym9SDM?t=01h19m12s)

[because](https://youtu.be/mbmprym9SDM?t=01h19m15s)

[in most issue tracking things it's easy](https://youtu.be/mbmprym9SDM?t=01h19m16s)

[to edit an issue or delete an issue or](https://youtu.be/mbmprym9SDM?t=01h19m18s)

[switch issue trackers and then it's like](https://youtu.be/mbmprym9SDM?t=01h19m20s)

[well now that comments just even more](https://youtu.be/mbmprym9SDM?t=01h19m21s)

[meaningless than what it was before](https://youtu.be/mbmprym9SDM?t=01h19m23s)

[okay so that is fine that is fine](https://youtu.be/mbmprym9SDM?t=01h19m27s)

[let me just make sure i didn't break](https://youtu.be/mbmprym9SDM?t=01h19m30s)

[anything](https://youtu.be/mbmprym9SDM?t=01h19m32s)

[oh i did break something start remote](https://youtu.be/mbmprym9SDM?t=01h19m34s)

[would then no longer be](https://youtu.be/mbmprym9SDM?t=01h19m37s)

[synchronous call it would be async](https://youtu.be/mbmprym9SDM?t=01h19m40s)

[[Music]](https://youtu.be/mbmprym9SDM?t=01h19m46s)

[that's a potentially scary thing](https://youtu.be/mbmprym9SDM?t=01h19m48s)

[i](https://youtu.be/mbmprym9SDM?t=01h19m54s)

[think i like the idea of making this](https://youtu.be/mbmprym9SDM?t=01h19m55s)

[async the vast majority of this library](https://youtu.be/mbmprym9SDM?t=01h19m57s)

[is async](https://youtu.be/mbmprym9SDM?t=01h20m00s)

[[Music]](https://youtu.be/mbmprym9SDM?t=01h20m01s)

[because most of the most of the calls](https://youtu.be/mbmprym9SDM?t=01h20m03s)

[that you make](https://youtu.be/mbmprym9SDM?t=01h20m04s)

[um](https://youtu.be/mbmprym9SDM?t=01h20m07s)

[like create window with content what](https://youtu.be/mbmprym9SDM?t=01h20m08s)

[that ends up doing is sending a request](https://youtu.be/mbmprym9SDM?t=01h20m11s)

[from your test host into your wpf app](https://youtu.be/mbmprym9SDM?t=01h20m13s)

[shell creating a window](https://youtu.be/mbmprym9SDM?t=01h20m16s)

[and then coming back to you and there's](https://youtu.be/mbmprym9SDM?t=01h20m18s)

[that communication runs over grpc with](https://youtu.be/mbmprym9SDM?t=01h20m20s)

[named pipes so it's just name pipe it's](https://youtu.be/mbmprym9SDM?t=01h20m23s)

[basically network communication but](https://youtu.be/mbmprym9SDM?t=01h20m25s)

[local](https://youtu.be/mbmprym9SDM?t=01h20m27s)

[um back and forth between them which is](https://youtu.be/mbmprym9SDM?t=01h20m28s)

[great](https://youtu.be/mbmprym9SDM?t=01h20m30s)

[but it does make everything async and](https://youtu.be/mbmprym9SDM?t=01h20m32s)

[i'm wondering if this should be](https://youtu.be/mbmprym9SDM?t=01h20m33s)

[like how bad is it if i just do this](https://youtu.be/mbmprym9SDM?t=01h20m36s)

[like that is](https://youtu.be/mbmprym9SDM?t=01h20m38s)

[that's a major breaking change](https://youtu.be/mbmprym9SDM?t=01h20m42s)

[oh boy](https://youtu.be/mbmprym9SDM?t=01h20m45s)

[oh boy](https://youtu.be/mbmprym9SDM?t=01h20m46s)

[and the only reason it would need to be](https://youtu.be/mbmprym9SDM?t=01h20m48s)

[a sink is for this](https://youtu.be/mbmprym9SDM?t=01h20m50s)

[so the other option is i could pull this](https://youtu.be/mbmprym9SDM?t=01h20m54s)

[out and make an overload](https://youtu.be/mbmprym9SDM?t=01h20m56s)

[that might not be a bad idea](https://youtu.be/mbmprym9SDM?t=01h21m01s)

[leave these other ones synchronous](https://youtu.be/mbmprym9SDM?t=01h21m04s)

[yeah it may be in the interest of not](https://youtu.be/mbmprym9SDM?t=01h21m11s)

[breaking](https://youtu.be/mbmprym9SDM?t=01h21m13s)

[back compact](https://youtu.be/mbmprym9SDM?t=01h21m15s)

[i break this in](https://youtu.be/mbmprym9SDM?t=01h21m20s)

[yeah i think in the interest of not](https://youtu.be/mbmprym9SDM?t=01h21m26s)

[breaking backwards compatibility i](https://youtu.be/mbmprym9SDM?t=01h21m28s)

[wow what do you do here](https://youtu.be/mbmprym9SDM?t=01h21m33s)

[okay so](https://youtu.be/mbmprym9SDM?t=01h21m36s)

[because if i make this an asynchronous](https://youtu.be/mbmprym9SDM?t=01h21m40s)

[method that's changing the return type](https://youtu.be/mbmprym9SDM?t=01h21m42s)

[changing the return type is a is very](https://youtu.be/mbmprym9SDM?t=01h21m46s)

[much a breaking change and i i kind of](https://youtu.be/mbmprym9SDM?t=01h21m48s)

[go so](https://youtu.be/mbmprym9SDM?t=01h21m50s)

[why this matters why this matters](https://youtu.be/mbmprym9SDM?t=01h21m51s)

[um](https://youtu.be/mbmprym9SDM?t=01h21m54s)

[simpler so](https://youtu.be/mbmprym9SDM?t=01h21m56s)

[uh on my](https://youtu.be/mbmprym9SDM?t=01h21m58s)

[most of my libraries including xaml test](https://youtu.be/mbmprym9SDM?t=01h22m00s)

[um i generally subscribe to the](https://youtu.be/mbmprym9SDM?t=01h22m04s)

[principle that until i hit a 10](https://youtu.be/mbmprym9SDM?t=01h22m05s)

[release um i don't bother to follow](https://youtu.be/mbmprym9SDM?t=01h22m08s)

[semantic versioning](https://youtu.be/mbmprym9SDM?t=01h22m11s)

[but](https://youtu.be/mbmprym9SDM?t=01h22m13s)

[oh i don't have a nuget link i should](https://youtu.be/mbmprym9SDM?t=01h22m15s)

[fix that](https://youtu.be/mbmprym9SDM?t=01h22m16s)

[but once you hit a](https://youtu.be/mbmprym9SDM?t=01h22m18s)

[once you hit a 1-0 release which is what](https://youtu.be/mbmprym9SDM?t=01h22m20s)

[i am now at](https://youtu.be/mbmprym9SDM?t=01h22m23s)

[it now follow](https://youtu.be/mbmprym9SDM?t=01h22m24s)

[now you should follow semantic version](https://youtu.be/mbmprym9SDM?t=01h22m26s)

[so i usually reserve everything below](https://youtu.be/mbmprym9SDM?t=01h22m28s)

[1.0 is i can do what i want break apis](https://youtu.be/mbmprym9SDM?t=01h22m30s)

[i'm not going to follow semver like the](https://youtu.be/mbmprym9SDM?t=01h22m33s)

[library is an active getting built](https://youtu.be/mbmprym9SDM?t=01h22m35s)

[thingy um](https://youtu.be/mbmprym9SDM?t=01h22m36s)

[yeah so it should be considered alpha](https://youtu.be/mbmprym9SDM?t=01h22m40s)

[releases and all apis are subject to](https://youtu.be/mbmprym9SDM?t=01h22m42s)

[change without notice 1.0 i now follow](https://youtu.be/mbmprym9SDM?t=01h22m44s)

[semantic versioning so if i break](https://youtu.be/mbmprym9SDM?t=01h22m46s)

[the api and there's there's binary](https://youtu.be/mbmprym9SDM?t=01h22m49s)

[backwards compatibility and source](https://youtu.be/mbmprym9SDM?t=01h22m52s)

[backwards compatibility](https://youtu.be/mbmprym9SDM?t=01h22m54s)

[binary is really difficult](https://youtu.be/mbmprym9SDM?t=01h22m56s)

[i subscribe to source backwards](https://youtu.be/mbmprym9SDM?t=01h22m58s)

[compatibility so this means by adding](https://youtu.be/mbmprym9SDM?t=01h23m00s)

[this in this is a backwards compatible](https://youtu.be/mbmprym9SDM?t=01h23m02s)

[change from source because anybody who](https://youtu.be/mbmprym9SDM?t=01h23m05s)

[had who didn't bother to specify before](https://youtu.be/mbmprym9SDM?t=01h23m07s)

[would be getting the same behavior that](https://youtu.be/mbmprym9SDM?t=01h23m09s)

[they were getting previously](https://youtu.be/mbmprym9SDM?t=01h23m11s)

[fine great not a big deal](https://youtu.be/mbmprym9SDM?t=01h23m12s)

[i](https://youtu.be/mbmprym9SDM?t=01h23m15s)

[think what i almost want to do is](https://youtu.be/mbmprym9SDM?t=01h23m16s)

[something like public static i app](https://youtu.be/mbmprym9SDM?t=01h23m19s)

[start](https://youtu.be/mbmprym9SDM?t=01h23m22s)

[with the debug](https://youtu.be/mbmprym9SDM?t=01h23m29s)

[you know what we could do](https://youtu.be/mbmprym9SDM?t=01h23m36s)

[because the only reason this matters](https://youtu.be/mbmprym9SDM?t=01h23m43s)

[is because if i don't pass the debug](https://youtu.be/mbmprym9SDM?t=01h23m46s)

[flag to myself](https://youtu.be/mbmprym9SDM?t=01h23m48s)

[because this all this is doing as if is](https://youtu.be/mbmprym9SDM?t=01h23m50s)

[this](https://youtu.be/mbmprym9SDM?t=01h23m52s)

[this api](https://youtu.be/mbmprym9SDM?t=01h23m53s)

[is a so](https://youtu.be/mbmprym9SDM?t=01h23m54s)

[this method exists inside of the xaml](https://youtu.be/mbmprym9SDM?t=01h23m56s)

[test project](https://youtu.be/mbmprym9SDM?t=01h23m59s)

[the xaml test project is itself a wpf](https://youtu.be/mbmprym9SDM?t=01h24m00s)

[app so when you invoke this method what](https://youtu.be/mbmprym9SDM?t=01h24m03s)

[it's doing is it's starting a new](https://youtu.be/mbmprym9SDM?t=01h24m06s)

[process](https://youtu.be/mbmprym9SDM?t=01h24m07s)

[point it at itself](https://youtu.be/mbmprym9SDM?t=01h24m08s)

[so it literally grabs itself](https://youtu.be/mbmprym9SDM?t=01h24m11s)

[and then executes on itself](https://youtu.be/mbmprym9SDM?t=01h24m14s)

[that's all it's doing](https://youtu.be/mbmprym9SDM?t=01h24m17s)

[but when it starts up it has the ability](https://youtu.be/mbmprym9SDM?t=01h24m20s)

[to pass itself some arguments and this](https://youtu.be/mbmprym9SDM?t=01h24m22s)

[is how we get the separate process going](https://youtu.be/mbmprym9SDM?t=01h24m24s)

[and how i can make some assumptions](https://youtu.be/mbmprym9SDM?t=01h24m26s)

[about how my client and server are](https://youtu.be/mbmprym9SDM?t=01h24m28s)

[working because the same library](https://youtu.be/mbmprym9SDM?t=01h24m30s)

[is also the um the at the app shell that](https://youtu.be/mbmprym9SDM?t=01h24m33s)

[gets started up](https://youtu.be/mbmprym9SDM?t=01h24m36s)

[i can be pretty confident that i don't](https://youtu.be/mbmprym9SDM?t=01h24m37s)

[have two versions like everything's](https://youtu.be/mbmprym9SDM?t=01h24m39s)

[always going to be the same version and](https://youtu.be/mbmprym9SDM?t=01h24m41s)

[i can change that](https://youtu.be/mbmprym9SDM?t=01h24m43s)

[the grpc protocol](https://youtu.be/mbmprym9SDM?t=01h24m44s)

[and i don't have to worry about like](https://youtu.be/mbmprym9SDM?t=01h24m46s)

[back back compat because](https://youtu.be/mbmprym9SDM?t=01h24m48s)

[whatever assembly you use to start the](https://youtu.be/mbmprym9SDM?t=01h24m50s)

[thing is the same assembly that's](https://youtu.be/mbmprym9SDM?t=01h24m52s)

[started so it's always going to have the](https://youtu.be/mbmprym9SDM?t=01h24m54s)

[same one or it's going to be really hard](https://youtu.be/mbmprym9SDM?t=01h24m55s)

[to not get the same one](https://youtu.be/mbmprym9SDM?t=01h24m57s)

[but](https://youtu.be/mbmprym9SDM?t=01h25m02s)

[i pass it the debug switch](https://youtu.be/mbmprym9SDM?t=01h25m02s)

[here](https://youtu.be/mbmprym9SDM?t=01h25m05s)

[and all this debug switch does so if we](https://youtu.be/mbmprym9SDM?t=01h25m07s)

[go and look um](https://youtu.be/mbmprym9SDM?t=01h25m10s)

[where is the startup](https://youtu.be/mbmprym9SDM?t=01h25m14s)

[it's like program cs here](https://youtu.be/mbmprym9SDM?t=01h25m18s)

[so if we look here](https://youtu.be/mbmprym9SDM?t=01h25m22s)

[um this is using system command line for](https://youtu.be/mbmprym9SDM?t=01h25m24s)

[those who care](https://youtu.be/mbmprym9SDM?t=01h25m26s)

[and for anybody who watched last week's](https://youtu.be/mbmprym9SDM?t=01h25m28s)

[stream](https://youtu.be/mbmprym9SDM?t=01h25m29s)

[um and i should probably update this for](https://youtu.be/mbmprym9SDM?t=01h25m31s)

[latest system command line but i don't](https://youtu.be/mbmprym9SDM?t=01h25m33s)

[think any of these things have largely](https://youtu.be/mbmprym9SDM?t=01h25m34s)

[changed](https://youtu.be/mbmprym9SDM?t=01h25m35s)

[this guy here is](https://youtu.be/mbmprym9SDM?t=01h25m37s)

[processing the arguments](https://youtu.be/mbmprym9SDM?t=01h25m39s)

[it's just doing a parse](https://youtu.be/mbmprym9SDM?t=01h25m41s)

[um](https://youtu.be/mbmprym9SDM?t=01h25m44s)

[and this is all being done just as an](https://youtu.be/mbmprym9SDM?t=01h25m47s)

[easy way of processing this args array i](https://youtu.be/mbmprym9SDM?t=01h25m48s)

[could have been a little](https://youtu.be/mbmprym9SDM?t=01h25m51s)

[less picky about](https://youtu.be/mbmprym9SDM?t=01h25m53s)

[using cystic command line because the](https://youtu.be/mbmprym9SDM?t=01h25m54s)

[only invoker of this should be me oh and](https://youtu.be/mbmprym9SDM?t=01h25m56s)

[there's the heartbeat timer yeah that](https://youtu.be/mbmprym9SDM?t=01h25m59s)

[was the thing i was looking for the](https://youtu.be/mbmprym9SDM?t=01h26m01s)

[thing that kills itself](https://youtu.be/mbmprym9SDM?t=01h26m02s)

[um](https://youtu.be/mbmprym9SDM?t=01h26m04s)

[and with this debug switch here being](https://youtu.be/mbmprym9SDM?t=01h26m08s)

[set what ends up happening is when that](https://youtu.be/mbmprym9SDM?t=01h26m11s)

[is set it will actually sit when it](https://youtu.be/mbmprym9SDM?t=01h26m14s)

[starts up it'll sit and spin](https://youtu.be/mbmprym9SDM?t=01h26m16s)

[waiting for a debugger to attach](https://youtu.be/mbmprym9SDM?t=01h26m18s)

[which is great it just is the debugger](https://youtu.be/mbmprym9SDM?t=01h26m21s)

[attached sleep is the debugger attached](https://youtu.be/mbmprym9SDM?t=01h26m23s)

[sleep and it'll just sit there and wait](https://youtu.be/mbmprym9SDM?t=01h26m25s)

[for a debugger to show up](https://youtu.be/mbmprym9SDM?t=01h26m27s)

[um](https://youtu.be/mbmprym9SDM?t=01h26m31s)

[and this guy and this heartbeat check](https://youtu.be/mbmprym9SDM?t=01h26m37s)

[will just come in here and go hey](https://youtu.be/mbmprym9SDM?t=01h26m39s)

[you know](https://youtu.be/mbmprym9SDM?t=01h26m42s)

[does is my parent process alive if it is](https://youtu.be/mbmprym9SDM?t=01h26m42s)

[i stay running if my parent process](https://youtu.be/mbmprym9SDM?t=01h26m45s)

[terminates it dies so this is the](https://youtu.be/mbmprym9SDM?t=01h26m47s)

[kind of the reverse of a job and the](https://youtu.be/mbmprym9SDM?t=01h26m50s)

[other thing to know about those process](https://youtu.be/mbmprym9SDM?t=01h26m53s)

[jobs is that there's only one level of](https://youtu.be/mbmprym9SDM?t=01h26m54s)

[hierarchy you can't have a child nested](https://youtu.be/mbmprym9SDM?t=01h26m56s)

[under a child](https://youtu.be/mbmprym9SDM?t=01h26m58s)

[and the other drawback is visual studio](https://youtu.be/mbmprym9SDM?t=01h27m00s)

[often wants to leave its test process](https://youtu.be/mbmprym9SDM?t=01h27m02s)

[running](https://youtu.be/mbmprym9SDM?t=01h27m04s)

[as a long-running process](https://youtu.be/mbmprym9SDM?t=01h27m06s)

[so you can kind of run into this fun](https://youtu.be/mbmprym9SDM?t=01h27m08s)

[situation where xaml test stays running](https://youtu.be/mbmprym9SDM?t=01h27m10s)

[because visual studio kept the test host](https://youtu.be/mbmprym9SDM?t=01h27m13s)

[running](https://youtu.be/mbmprym9SDM?t=01h27m15s)

[and so the heartbeat never actually](https://youtu.be/mbmprym9SDM?t=01h27m16s)

[kills itself](https://youtu.be/mbmprym9SDM?t=01h27m17s)

[so](https://youtu.be/mbmprym9SDM?t=01h27m20s)

[yeah that's fun](https://youtu.be/mbmprym9SDM?t=01h27m20s)

[that can be a little bit annoying](https://youtu.be/mbmprym9SDM?t=01h27m22s)

[i am still trying to decide how to](https://youtu.be/mbmprym9SDM?t=01h27m25s)

[handle this api](https://youtu.be/mbmprym9SDM?t=01h27m27s)

[because this method does need to be](https://youtu.be/mbmprym9SDM?t=01h27m29s)

[async the moment i want to do retry and](https://youtu.be/mbmprym9SDM?t=01h27m31s)

[waiting and that kind of thing it](https://youtu.be/mbmprym9SDM?t=01h27m34s)

[definitely needs to be async](https://youtu.be/mbmprym9SDM?t=01h27m35s)

[i think what i want to do is a separate](https://youtu.be/mbmprym9SDM?t=01h27m43s)

[method to avoid breaking back compat](https://youtu.be/mbmprym9SDM?t=01h27m45s)

[i think i want a separate method](https://youtu.be/mbmprym9SDM?t=01h27m50s)

[that does all of this](https://youtu.be/mbmprym9SDM?t=01h27m56s)

[oh](https://youtu.be/mbmprym9SDM?t=01h28m00s)

[technically this method here](https://youtu.be/mbmprym9SDM?t=01h28m02s)

[or this parameter here isn't in the 1.0](https://youtu.be/mbmprym9SDM?t=01h28m08s)

[release this is new](https://youtu.be/mbmprym9SDM?t=01h28m10s)

[i wonder](https://youtu.be/mbmprym9SDM?t=01h28m15s)

[i wonder if](https://youtu.be/mbmprym9SDM?t=01h28m20s)

[this](https://youtu.be/mbmprym9SDM?t=01h28m25s)

[guy here makes for a good compelling](https://youtu.be/mbmprym9SDM?t=01h28m26s)

[case okay so so what's the api](https://youtu.be/mbmprym9SDM?t=01h28m29s)

[public static](https://youtu.be/mbmprym9SDM?t=01h28m31s)

[async task](https://youtu.be/mbmprym9SDM?t=01h28m34s)

[of iap](https://youtu.be/mbmprym9SDM?t=01h28m36s)

[start](https://youtu.be/mbmprym9SDM?t=01h28m39s)

[start with debugger](https://youtu.be/mbmprym9SDM?t=01h28m43s)

[that what i want](https://youtu.be/mbmprym9SDM?t=01h28m45s)

[because if you don't want the debugger](https://youtu.be/mbmprym9SDM?t=01h28m50s)

[you can kind of ignore this all together](https://youtu.be/mbmprym9SDM?t=01h28m52s)

[and then this guy so](https://youtu.be/mbmprym9SDM?t=01h28m56s)

[that brings](https://youtu.be/mbmprym9SDM?t=01h28m59s)

[there's gonna this is huge duplication](https://youtu.be/mbmprym9SDM?t=01h29m00s)

[for the moment don't panic we're gonna](https://youtu.be/mbmprym9SDM?t=01h29m02s)

[fix it](https://youtu.be/mbmprym9SDM?t=01h29m03s)

[but now this is all happy](https://youtu.be/mbmprym9SDM?t=01h29m04s)

[and the only thing it's unhappy about is](https://youtu.be/mbmprym9SDM?t=01h29m07s)

[it wants these same parameters okay okay](https://youtu.be/mbmprym9SDM?t=01h29m09s)

[i think this is this is this is gonna](https://youtu.be/mbmprym9SDM?t=01h29m12s)

[this is gonna look a little better i i](https://youtu.be/mbmprym9SDM?t=01h29m14s)

[think i think i think](https://youtu.be/mbmprym9SDM?t=01h29m17s)

[okay so if this guy works like this](https://youtu.be/mbmprym9SDM?t=01h29m18s)

[then rather than there being a boolean](https://youtu.be/mbmprym9SDM?t=01h29m27s)

[parameter for toggling this thing on and](https://youtu.be/mbmprym9SDM?t=01h29m29s)

[off we can go back to the original code](https://youtu.be/mbmprym9SDM?t=01h29m31s)

[that i had without the the toggle](https://youtu.be/mbmprym9SDM?t=01h29m33s)

[however i then want to eliminate it](https://youtu.be/mbmprym9SDM?t=01h29m38s)

[from this altogether](https://youtu.be/mbmprym9SDM?t=01h29m42s)

[you are no longer a thing](https://youtu.be/mbmprym9SDM?t=01h29m44s)

[you go you go back down to here](https://youtu.be/mbmprym9SDM?t=01h29m47s)

[this goes away](https://youtu.be/mbmprym9SDM?t=01h29m51s)

[this goes away](https://youtu.be/mbmprym9SDM?t=01h29m54s)

[this goes away](https://youtu.be/mbmprym9SDM?t=01h29m57s)

[okay](https://youtu.be/mbmprym9SDM?t=01h30m01s)

[so](https://youtu.be/mbmprym9SDM?t=01h30m03s)

[dart remote](https://youtu.be/mbmprym9SDM?t=01h30m05s)

[[Music]](https://youtu.be/mbmprym9SDM?t=01h30m08s)

[okay so now the question is i don't like](https://youtu.be/mbmprym9SDM?t=01h30m10s)

[all of this useless duplication](https://youtu.be/mbmprym9SDM?t=01h30m13s)

[so the big difference are these lines](https://youtu.be/mbmprym9SDM?t=01h30m17s)

[here](https://youtu.be/mbmprym9SDM?t=01h30m19s)

[and this line here](https://youtu.be/mbmprym9SDM?t=01h30m21s)

[so how can i](https://youtu.be/mbmprym9SDM?t=01h30m25s)

[break this up](https://youtu.be/mbmprym9SDM?t=01h30m28s)

[i think what we do is we go with](https://youtu.be/mbmprym9SDM?t=01h30m40s)

[something about like this i think](https://youtu.be/mbmprym9SDM?t=01h30m42s)

[start](https://youtu.be/mbmprym9SDM?t=01h30m56s)

[uh](https://youtu.be/mbmprym9SDM?t=01h31m00s)

[remote](https://youtu.be/mbmprym9SDM?t=01h31m01s)

[this becomes private](https://youtu.be/mbmprym9SDM?t=01h31m04s)

[um](https://youtu.be/mbmprym9SDM?t=01h31m09s)

[yeah because i think what we can do](https://youtu.be/mbmprym9SDM?t=01h31m24s)

[um](https://youtu.be/mbmprym9SDM?t=01h31m28s)

[and these things all become non-optional](https://youtu.be/mbmprym9SDM?t=01h31m30s)

[because optional is not going to be a](https://youtu.be/mbmprym9SDM?t=01h31m33s)

[thing here](https://youtu.be/mbmprym9SDM?t=01h31m35s)

[this is you're going to if you're](https://youtu.be/mbmprym9SDM?t=01h31m36s)

[calling all of these guys are going to](https://youtu.be/mbmprym9SDM?t=01h31m38s)

[call the](https://youtu.be/mbmprym9SDM?t=01h31m40s)

[this one and how you expose it is up to](https://youtu.be/mbmprym9SDM?t=01h31m41s)

[you fool](https://youtu.be/mbmprym9SDM?t=01h31m43s)

[allow](https://youtu.be/mbmprym9SDM?t=01h31m45s)

[debugger attach](https://youtu.be/mbmprym9SDM?t=01h31m46s)

[right that's what we](https://youtu.be/mbmprym9SDM?t=01h31m50s)

[that's what it was called be a second](https://youtu.be/mbmprym9SDM?t=01h31m53s)

[ago right let me look](https://youtu.be/mbmprym9SDM?t=01h31m54s)

[uh](https://youtu.be/mbmprym9SDM?t=01h31m57s)

[yeah allow debugger attach](https://youtu.be/mbmprym9SDM?t=01h31m59s)

[great](https://youtu.be/mbmprym9SDM?t=01h32m01s)

[so we are going to have u and allow](https://youtu.be/mbmprym9SDM?t=01h32m02s)

[debugger attach](https://youtu.be/mbmprym9SDM?t=01h32m05s)

[which that goes back into here which is](https://youtu.be/mbmprym9SDM?t=01h32m06s)

[great](https://youtu.be/mbmprym9SDM?t=01h32m08s)

[that goes into there that goes into](https://youtu.be/mbmprym9SDM?t=01h32m10s)

[there](https://youtu.be/mbmprym9SDM?t=01h32m11s)

[and then we cheat](https://youtu.be/mbmprym9SDM?t=01h32m13s)

[blatantly cheat so this this method here](https://youtu.be/mbmprym9SDM?t=01h32m15s)

[is async](https://youtu.be/mbmprym9SDM?t=01h32m20s)

[and this becomes a weight start remote](https://youtu.be/mbmprym9SDM?t=01h32m22s)

[remote app](https://youtu.be/mbmprym9SDM?t=01h32m27s)

[saml test path](https://youtu.be/mbmprym9SDM?t=01h32m29s)

[log message](https://youtu.be/mbmprym9SDM?t=01h32m31s)

[and true](https://youtu.be/mbmprym9SDM?t=01h32m34s)

[those all go like that](https://youtu.be/mbmprym9SDM?t=01h32m36s)

[and then we're going to do an overload](https://youtu.be/mbmprym9SDM?t=01h32m39s)

[that looks kind of like this here](https://youtu.be/mbmprym9SDM?t=01h32m41s)

[and](https://youtu.be/mbmprym9SDM?t=01h32m47s)

[because doing the the t app here like](https://youtu.be/mbmprym9SDM?t=01h32m48s)

[this](https://youtu.be/mbmprym9SDM?t=01h32m51s)

[um is just used as a shorthand for](https://youtu.be/mbmprym9SDM?t=01h32m54s)

[getting access to the location](https://youtu.be/mbmprym9SDM?t=01h32m57s)

[um](https://youtu.be/mbmprym9SDM?t=01h33m00s)

[and we could we could avoid that](https://youtu.be/mbmprym9SDM?t=01h33m04s)

[duplication too if we wanted um](https://youtu.be/mbmprym9SDM?t=01h33m05s)

[this needs to be start with debugger](https://youtu.be/mbmprym9SDM?t=01h33m11s)

[start with debugger](https://youtu.be/mbmprym9SDM?t=01h33m13s)

[start with debugger](https://youtu.be/mbmprym9SDM?t=01h33m15s)

[and then this becomes location xaml path](https://youtu.be/mbmprym9SDM?t=01h33m17s)

[uh](https://youtu.be/mbmprym9SDM?t=01h33m23s)

[[Music]](https://youtu.be/mbmprym9SDM?t=01h33m23s)

[what is your problem here](https://youtu.be/mbmprym9SDM?t=01h33m27s)

[t](https://youtu.be/mbmprym9SDM?t=01h33m33s)

[what](https://youtu.be/mbmprym9SDM?t=01h33m34s)

[cannot implicitly convert from task oh](https://youtu.be/mbmprym9SDM?t=01h33m35s)

[oh oh oh oh oh](https://youtu.be/mbmprym9SDM?t=01h33m38s)

[async task](https://youtu.be/mbmprym9SDM?t=01h33m40s)

[there](https://youtu.be/mbmprym9SDM?t=01h33m43s)

[wait](https://youtu.be/mbmprym9SDM?t=01h33m46s)

[boom](https://youtu.be/mbmprym9SDM?t=01h33m48s)

[builds that out and away we go okay](https://youtu.be/mbmprym9SDM?t=01h33m49s)

[so both of those guys go there now](https://youtu.be/mbmprym9SDM?t=01h33m52s)

[because we know this is passing true](https://youtu.be/mbmprym9SDM?t=01h33m55s)

[these things need to be async](https://youtu.be/mbmprym9SDM?t=01h33m57s)

[this is where we do something bad](https://youtu.be/mbmprym9SDM?t=01h33m59s)

[this is where we do something bad](https://youtu.be/mbmprym9SDM?t=01h34m05s)

[and this is probably a good](https://youtu.be/mbmprym9SDM?t=01h34m09s)

[a good argument for wow did you just](https://youtu.be/mbmprym9SDM?t=01h34m12s)

[that's pretty close](https://youtu.be/mbmprym9SDM?t=01h34m18s)

[oh it guessed itself](https://youtu.be/mbmprym9SDM?t=01h34m23s)

[uh](https://youtu.be/mbmprym9SDM?t=01h34m27s)

[we should rename this to start remote](https://youtu.be/mbmprym9SDM?t=01h34m29s)

[because i don't want to accidentally](https://youtu.be/mbmprym9SDM?t=01h34m32s)

[land on the wrong overload because i'm](https://youtu.be/mbmprym9SDM?t=01h34m34s)

[an idiot](https://youtu.be/mbmprym9SDM?t=01h34m36s)

[um](https://youtu.be/mbmprym9SDM?t=01h34m37s)

[and then this needs to be false](https://youtu.be/mbmprym9SDM?t=01h34m38s)

[and we do dot result](https://youtu.be/mbmprym9SDM?t=01h34m44s)

[now](https://youtu.be/mbmprym9SDM?t=01h34m48s)

[for those people who watched my stream](https://youtu.be/mbmprym9SDM?t=01h34m50s)

[weeks ago about the tpl i believe i said](https://youtu.be/mbmprym9SDM?t=01h34m53s)

[dot result you should use almost never](https://youtu.be/mbmprym9SDM?t=01h34m56s)

[ever ever ever ever ever ever or](https://youtu.be/mbmprym9SDM?t=01h34m58s)

[something about like that](https://youtu.be/mbmprym9SDM?t=01h35m01s)

[however](https://youtu.be/mbmprym9SDM?t=01h35m03s)

[this](https://youtu.be/mbmprym9SDM?t=01h35m04s)

[is actually okay here](https://youtu.be/mbmprym9SDM?t=01h35m07s)

[currently actually okay](https://youtu.be/mbmprym9SDM?t=01h35m10s)

[so it is only okay](https://youtu.be/mbmprym9SDM?t=01h35m13s)

[because in the case of a false](https://youtu.be/mbmprym9SDM?t=01h35m15s)

[we will never hit an await](https://youtu.be/mbmprym9SDM?t=01h35m19s)

[and an asynchronous method in c sharp](https://youtu.be/mbmprym9SDM?t=01h35m22s)

[does not](https://youtu.be/mbmprym9SDM?t=01h35m25s)

[shell out and does not go asynchronous](https://youtu.be/mbmprym9SDM?t=01h35m26s)

[until it hits the first await](https://youtu.be/mbmprym9SDM?t=01h35m29s)

[and we know that by passing a false](https://youtu.be/mbmprym9SDM?t=01h35m32s)

[we're guaranteed to never hit inside or](https://youtu.be/mbmprym9SDM?t=01h35m34s)

[use debuggers guaranteed to be false](https://youtu.be/mbmprym9SDM?t=01h35m37s)

[which means we will never hit and await](https://youtu.be/mbmprym9SDM?t=01h35m39s)

[inside of here](https://youtu.be/mbmprym9SDM?t=01h35m41s)

[this feels a little risky](https://youtu.be/mbmprym9SDM?t=01h35m43s)

[because future kevin's an idiot and will](https://youtu.be/mbmprym9SDM?t=01h35m45s)

[probably forget about this stream and](https://youtu.be/mbmprym9SDM?t=01h35m47s)

[will probably need to be reminded of it](https://youtu.be/mbmprym9SDM?t=01h35m49s)

[little risky](https://youtu.be/mbmprym9SDM?t=01h35m55s)

[but should be fine](https://youtu.be/mbmprym9SDM?t=01h35m58s)

[okay now i have to write some tests](https://youtu.be/mbmprym9SDM?t=01h36m03s)

[because this is this is something that](https://youtu.be/mbmprym9SDM?t=01h36m04s)

[definitely needs to be tested so first](https://youtu.be/mbmprym9SDM?t=01h36m06s)

[of all does it compile](https://youtu.be/mbmprym9SDM?t=01h36m08s)

[step one](https://youtu.be/mbmprym9SDM?t=01h36m14s)

[and i've got a nullable warning in here](https://youtu.be/mbmprym9SDM?t=01h36m18s)

[too what did i do wrong here](https://youtu.be/mbmprym9SDM?t=01h36m20s)

[what's possibly no](https://youtu.be/mbmprym9SDM?t=01h36m24s)

[converting no literal](https://youtu.be/mbmprym9SDM?t=01h36m29s)

[line 47 to possibly none](https://youtu.be/mbmprym9SDM?t=01h36m32s)

[are you trying to insist that vs process](https://youtu.be/mbmprym9SDM?t=01h36m42s)

[could be null](https://youtu.be/mbmprym9SDM?t=01h36m44s)

[because](https://youtu.be/mbmprym9SDM?t=01h36m46s)

[no it can't be](https://youtu.be/mbmprym9SDM?t=01h36m47s)

[um](https://youtu.be/mbmprym9SDM?t=01h36m55s)

[no that is not possible to be null](https://youtu.be/mbmprym9SDM?t=01h36m57s)

[why would you think that that's possible](https://youtu.be/mbmprym9SDM?t=01h37m01s)

[to be null](https://youtu.be/mbmprym9SDM?t=01h37m03s)

[okay 40 says so it's still flagging so i](https://youtu.be/mbmprym9SDM?t=01h37m04s)

[am missing something here](https://youtu.be/mbmprym9SDM?t=01h37m07s)

[character 52 where is character 52](https://youtu.be/mbmprym9SDM?t=01h37m10s)

[where's my character counter there it is](https://youtu.be/mbmprym9SDM?t=01h37m19s)

[character](https://youtu.be/mbmprym9SDM?t=01h37m21s)

[you guys probably can't see it character](https://youtu.be/mbmprym9SDM?t=01h37m23s)

[counter](https://youtu.be/mbmprym9SDM?t=01h37m24s)

[is right about](https://youtu.be/mbmprym9SDM?t=01h37m26s)

[there](https://youtu.be/mbmprym9SDM?t=01h37m28s)

[behind my chair](https://youtu.be/mbmprym9SDM?t=01h37m30s)

[01:37:36,000 --> 01:37:43,679](https://youtu.be/mbmprym9SDM?t=01h37m32s)

so it's flagging

[line 47 character 52 to line 51](https://youtu.be/mbmprym9SDM?t=01h37m38s)

[character 95. oh](https://youtu.be/mbmprym9SDM?t=01h37m43s)

[[Music]](https://youtu.be/mbmprym9SDM?t=01h37m45s)

[no what it's flagging](https://youtu.be/mbmprym9SDM?t=01h37m47s)

[is this is non-nullable](https://youtu.be/mbmprym9SDM?t=01h37m49s)

[and i'm doing a first or default which](https://youtu.be/mbmprym9SDM?t=01h37m53s)

[could return a null that makes a little](https://youtu.be/mbmprym9SDM?t=01h37m54s)

[more sense](https://youtu.be/mbmprym9SDM?t=01h37m56s)

[that makes a little more sense i'm](https://youtu.be/mbmprym9SDM?t=01h37m58s)

[surprised i didn't get squiggles](https://youtu.be/mbmprym9SDM?t=01h37m59s)

[there okay warning fixed and we check it](https://youtu.be/mbmprym9SDM?t=01h38m03s)

[for null so that makes](https://youtu.be/mbmprym9SDM?t=01h38m06s)

[makes perfect sense](https://youtu.be/mbmprym9SDM?t=01h38m08s)

[okay so we would like to write some app](https://youtu.be/mbmprym9SDM?t=01h38m10s)

[tests though because i want to verify](https://youtu.be/mbmprym9SDM?t=01h38m12s)

[that this actually works so](https://youtu.be/mbmprym9SDM?t=01h38m17s)

[test method](https://youtu.be/mbmprym9SDM?t=01h38m19s)

[uh public async task](https://youtu.be/mbmprym9SDM?t=01h38m22s)

[uh let's see so we are testing](https://youtu.be/mbmprym9SDM?t=01h38m25s)

[app](https://youtu.be/mbmprym9SDM?t=01h38m28s)

[and](https://youtu.be/mbmprym9SDM?t=01h38m31s)

[uh let's do with this](https://youtu.be/mbmprym9SDM?t=01h38m34s)

[uh let's see so on start with debugger](https://youtu.be/mbmprym9SDM?t=01h38m39s)

[launches](https://youtu.be/mbmprym9SDM?t=01h38m55s)

[with](https://youtu.be/mbmprym9SDM?t=01h38m56s)

[debug flag so here's here's the fun part](https://youtu.be/mbmprym9SDM?t=01h38m57s)

[right so](https://youtu.be/mbmprym9SDM?t=01h39m02s)

[we have to try it](https://youtu.be/mbmprym9SDM?t=01h39m03s)

[try and test this a little bit](https://youtu.be/mbmprym9SDM?t=01h39m05s)

[and it's really hard to write an](https://youtu.be/mbmprym9SDM?t=01h39m09s)

[automated test that tests this because](https://youtu.be/mbmprym9SDM?t=01h39m11s)

[visual studio isn't going to be running](https://youtu.be/mbmprym9SDM?t=01h39m14s)

[on like](https://youtu.be/mbmprym9SDM?t=01h39m16s)

[the github actions runner](https://youtu.be/mbmprym9SDM?t=01h39m17s)

[that's not a thing that's going to be](https://youtu.be/mbmprym9SDM?t=01h39m19s)

[there](https://youtu.be/mbmprym9SDM?t=01h39m20s)

[however what i can test is this little](https://youtu.be/mbmprym9SDM?t=01h39m21s)

[argument list](https://youtu.be/mbmprym9SDM?t=01h39m24s)

[this guy here i'm pretty sure we can do](https://youtu.be/mbmprym9SDM?t=01h39m26s)

[it](https://youtu.be/mbmprym9SDM?t=01h39m28s)

[so](https://youtu.be/mbmprym9SDM?t=01h39m29s)

[let's do](https://youtu.be/mbmprym9SDM?t=01h39m30s)

[let's do one of these guys](https://youtu.be/mbmprym9SDM?t=01h39m32s)

[so if i do this](https://youtu.be/mbmprym9SDM?t=01h39m35s)

[right i should be able to go app](https://youtu.be/mbmprym9SDM?t=01h39m37s)

[and then](https://youtu.be/mbmprym9SDM?t=01h39m41s)

[it's the easiest way to grab that](https://youtu.be/mbmprym9SDM?t=01h39m45s)

[i think we could actually probably just](https://youtu.be/mbmprym9SDM?t=01h39m54s)

[grab it in the test app itself](https://youtu.be/mbmprym9SDM?t=01h39m55s)

[so we could just have main window expose](https://youtu.be/mbmprym9SDM?t=01h40m00s)

[it for me hey look boom oscar namespace](https://youtu.be/mbmprym9SDM?t=01h40m02s)

[um](https://youtu.be/mbmprym9SDM?t=01h40m05s)

[i think what we do here](https://youtu.be/mbmprym9SDM?t=01h40m06s)

[is we have this guy just contain](https://youtu.be/mbmprym9SDM?t=01h40m11s)

[because this is just using test app](https://youtu.be/mbmprym9SDM?t=01h40m15s)

[window and i think one of the other](https://youtu.be/mbmprym9SDM?t=01h40m17s)

[tests was already leveraging that](https://youtu.be/mbmprym9SDM?t=01h40m18s)

[yeah getting the title so i don't really](https://youtu.be/mbmprym9SDM?t=01h40m20s)

[want to change the title of the window](https://youtu.be/mbmprym9SDM?t=01h40m22s)

[what we could do though is we could set](https://youtu.be/mbmprym9SDM?t=01h40m27s)

[its tag property](https://youtu.be/mbmprym9SDM?t=01h40m30s)

[and i think if we do environment](https://youtu.be/mbmprym9SDM?t=01h40m33s)

[i'm pretty sure this thing contains the](https://youtu.be/mbmprym9SDM?t=01h40m37s)

[it's the command line for this process i](https://youtu.be/mbmprym9SDM?t=01h40m42s)

[believe this will contain all of the](https://youtu.be/mbmprym9SDM?t=01h40m44s)

[stuff](https://youtu.be/mbmprym9SDM?t=01h40m46s)

[but let's let's test and find out](https://youtu.be/mbmprym9SDM?t=01h40m47s)

[let's let's confirm it](https://youtu.be/mbmprym9SDM?t=01h40m50s)

[uh](https://youtu.be/mbmprym9SDM?t=01h40m52s)

[so this needs to be](https://youtu.be/mbmprym9SDM?t=01h40m53s)

[start with debugger](https://youtu.be/mbmprym9SDM?t=01h40m54s)

[uh and then this needs to be a weight](https://youtu.be/mbmprym9SDM?t=01h40m58s)

[that looks a little funny a weight using](https://youtu.be/mbmprym9SDM?t=01h41m03s)

[var app equals a weight app start with](https://youtu.be/mbmprym9SDM?t=01h41m05s)

[debugger](https://youtu.be/mbmprym9SDM?t=01h41m07s)

[could be worse](https://youtu.be/mbmprym9SDM?t=01h41m08s)

[okay](https://youtu.be/mbmprym9SDM?t=01h41m10s)

[uh and then i want to do something like](https://youtu.be/mbmprym9SDM?t=01h41m12s)

[app dot](https://youtu.be/mbmprym9SDM?t=01h41m14s)

[get main window](https://youtu.be/mbmprym9SDM?t=01h41m16s)

[of our window](https://youtu.be/mbmprym9SDM?t=01h41m18s)

[and then i want to do](https://youtu.be/mbmprym9SDM?t=01h41m22s)

[a window](https://youtu.be/mbmprym9SDM?t=01h41m25s)

[get tag](https://youtu.be/mbmprym9SDM?t=01h41m26s)

[i can do this](https://youtu.be/mbmprym9SDM?t=01h41m31s)

[no](https://youtu.be/mbmprym9SDM?t=01h41m33s)

[um bar tag i'm trying to remember what](https://youtu.be/mbmprym9SDM?t=01h41m35s)

[the](https://youtu.be/mbmprym9SDM?t=01h41m38s)

[what is the return of this object](https://youtu.be/mbmprym9SDM?t=01h41m40s)

[probably](https://youtu.be/mbmprym9SDM?t=01h41m44s)

[um](https://youtu.be/mbmprym9SDM?t=01h41m47s)

[get main window](https://youtu.be/mbmprym9SDM?t=01h41m51s)

[so how about](https://youtu.be/mbmprym9SDM?t=01h41m53s)

[cert](https://youtu.be/mbmprym9SDM?t=01h41m55s)

[not](https://youtu.be/mbmprym9SDM?t=01h41m56s)

[is not null window](https://youtu.be/mbmprym9SDM?t=01h41m57s)

[then](https://youtu.be/mbmprym9SDM?t=01h42m00s)

[that works there](https://youtu.be/mbmprym9SDM?t=01h42m02s)

[and then insert](https://youtu.be/mbmprym9SDM?t=01h42m03s)

[our equal](https://youtu.be/mbmprym9SDM?t=01h42m06s)

[debug](https://youtu.be/mbmprym9SDM?t=01h42m09s)

[tag](https://youtu.be/mbmprym9SDM?t=01h42m11s)

[i think this will work](https://youtu.be/mbmprym9SDM?t=01h42m14s)

[i don't think it's going to be equal to](https://youtu.be/mbmprym9SDM?t=01h42m18s)

[this i think this is going to need to be](https://youtu.be/mbmprym9SDM?t=01h42m20s)

[more like it contains but](https://youtu.be/mbmprym9SDM?t=01h42m22s)

[i think this works](https://youtu.be/mbmprym9SDM?t=01h42m24s)

[but we're going to launch this test with](https://youtu.be/mbmprym9SDM?t=01h42m27s)

[debugging and since we said start with](https://youtu.be/mbmprym9SDM?t=01h42m29s)

[debugger we should hit my breakpoint in](https://youtu.be/mbmprym9SDM?t=01h42m31s)

[the main window on the other app](https://youtu.be/mbmprym9SDM?t=01h42m33s)

[because of awesome debugging skills](https://youtu.be/mbmprym9SDM?t=01h42m36s)

[you see test host fires up](https://youtu.be/mbmprym9SDM?t=01h42m40s)

[saml test and we attach to it](https://youtu.be/mbmprym9SDM?t=01h42m42s)

[[Music]](https://youtu.be/mbmprym9SDM?t=01h42m45s)

[magic occurs](https://youtu.be/mbmprym9SDM?t=01h42m47s)

[sweet](https://youtu.be/mbmprym9SDM?t=01h42m50s)

[okay so this shows the entire invocation](https://youtu.be/mbmprym9SDM?t=01h42m52s)

[of what was used to start this](https://youtu.be/mbmprym9SDM?t=01h42m54s)

[so](https://youtu.be/mbmprym9SDM?t=01h42m56s)

[root host](https://youtu.be/mbmprym9SDM?t=01h42m59s)

[application path](https://youtu.be/mbmprym9SDM?t=01h43m01s)

[dash dash debug](https://youtu.be/mbmprym9SDM?t=01h43m03s)

[awesome](https://youtu.be/mbmprym9SDM?t=01h43m06s)

[awesome](https://youtu.be/mbmprym9SDM?t=01h43m07s)

[i like it i like it i like it i like it](https://youtu.be/mbmprym9SDM?t=01h43m08s)

[i like it okay](https://youtu.be/mbmprym9SDM?t=01h43m09s)

[so i think what's important for](https://youtu.be/mbmprym9SDM?t=01h43m11s)

[my purposes](https://youtu.be/mbmprym9SDM?t=01h43m14s)

[for the purposes of this test](https://youtu.be/mbmprym9SDM?t=01h43m15s)

[oh we didn't actually see](https://youtu.be/mbmprym9SDM?t=01h43m18s)

[i want to make sure i'm able to read](https://youtu.be/mbmprym9SDM?t=01h43m20s)

[that tag back](https://youtu.be/mbmprym9SDM?t=01h43m22s)

[debug](https://youtu.be/mbmprym9SDM?t=01h43m24s)

[boom](https://youtu.be/mbmprym9SDM?t=01h43m32s)

[tag look at that boom okay so i think](https://youtu.be/mbmprym9SDM?t=01h43m34s)

[we're just going to do a contains on it](https://youtu.be/mbmprym9SDM?t=01h43m37s)

[so assert](https://youtu.be/mbmprym9SDM?t=01h43m41s)

[uh](https://youtu.be/mbmprym9SDM?t=01h43m45s)

[the](https://youtu.be/mbmprym9SDM?t=01h43m46s)

[it's true](https://youtu.be/mbmprym9SDM?t=01h43m48s)

[tag](https://youtu.be/mbmprym9SDM?t=01h43m51s)

[uh to string because it's an object](https://youtu.be/mbmprym9SDM?t=01h43m53s)

[contains](https://youtu.be/mbmprym9SDM?t=01h43m57s)

[dash dash debug](https://youtu.be/mbmprym9SDM?t=01h43m59s)

[boom uh](https://youtu.be/mbmprym9SDM?t=01h44m04s)

[that should be fine](https://youtu.be/mbmprym9SDM?t=01h44m07s)

[i think a cert true is hip to noble](https://youtu.be/mbmprym9SDM?t=01h44m09s)

[boolean yeah sweet so it'll fail on null](https://youtu.be/mbmprym9SDM?t=01h44m11s)

[and it'll fail on](https://youtu.be/mbmprym9SDM?t=01h44m13s)

[contains](https://youtu.be/mbmprym9SDM?t=01h44m17s)

[oh i'm just realizing if i launch this](https://youtu.be/mbmprym9SDM?t=01h44m18s)

[without a debugger attached this thing](https://youtu.be/mbmprym9SDM?t=01h44m20s)

[fails doesn't it](https://youtu.be/mbmprym9SDM?t=01h44m22s)

[yeah](https://youtu.be/mbmprym9SDM?t=01h44m24s)

[um](https://youtu.be/mbmprym9SDM?t=01h44m27s)

[so and i i say that it fails because](https://youtu.be/mbmprym9SDM?t=01h44m29s)

[they're still so even though we pass](https://youtu.be/mbmprym9SDM?t=01h44m31s)

[through a](https://youtu.be/mbmprym9SDM?t=01h44m33s)

[start with debugger and start with](https://youtu.be/mbmprym9SDM?t=01h44m35s)

[debugger passes through a true](https://youtu.be/mbmprym9SDM?t=01h44m36s)

[that true is going to end up being a](https://youtu.be/mbmprym9SDM?t=01h44m38s)

[false because no debugger is attached](https://youtu.be/mbmprym9SDM?t=01h44m41s)

[because if this is false this is the](https://youtu.be/mbmprym9SDM?t=01h44m48s)

[equivalent of not](https://youtu.be/mbmprym9SDM?t=01h44m50s)

[doing any attachment](https://youtu.be/mbmprym9SDM?t=01h44m52s)

[so i think what i have to do](https://youtu.be/mbmprym9SDM?t=01h44m59s)

[ain't doing this but](https://youtu.be/mbmprym9SDM?t=01h45m03s)

[i don't know of a cleaner way to](https://youtu.be/mbmprym9SDM?t=01h45m13s)

[do this](https://youtu.be/mbmprym9SDM?t=01h45m15s)

[because normally um](https://youtu.be/mbmprym9SDM?t=01h45m18s)

[cert](https://youtu.be/mbmprym9SDM?t=01h45m24s)

[inconclusive](https://youtu.be/mbmprym9SDM?t=01h45m26s)

[uh](https://youtu.be/mbmprym9SDM?t=01h45m28s)

[this](https://youtu.be/mbmprym9SDM?t=01h45m29s)

[test](https://youtu.be/mbmprym9SDM?t=01h45m30s)

[must be](https://youtu.be/mbmprym9SDM?t=01h45m31s)

[run](https://youtu.be/mbmprym9SDM?t=01h45m33s)

[with a](https://youtu.be/mbmprym9SDM?t=01h45m34s)

[debugger attached](https://youtu.be/mbmprym9SDM?t=01h45m35s)

[if i run this i should get](https://youtu.be/mbmprym9SDM?t=01h45m39s)

[inconclusive and if i debug it i should](https://youtu.be/mbmprym9SDM?t=01h45m42s)

[be able to see it work](https://youtu.be/mbmprym9SDM?t=01h45m44s)

[i'm not sure how i feel about that](https://youtu.be/mbmprym9SDM?t=01h45m48s)

[but i'm also not sure i can do much](https://youtu.be/mbmprym9SDM?t=01h45m51s)

[better](https://youtu.be/mbmprym9SDM?t=01h45m53s)

[okay so test run finished what did you](https://youtu.be/mbmprym9SDM?t=01h45m55s)

[do exactly](https://youtu.be/mbmprym9SDM?t=01h45m58s)

[start true](https://youtu.be/mbmprym9SDM?t=01h46m02s)

[oh uh](https://youtu.be/mbmprym9SDM?t=01h46m05s)

[return](https://youtu.be/mbmprym9SDM?t=01h46m07s)

[the run test](https://youtu.be/mbmprym9SDM?t=01h46m11s)

[uh](https://youtu.be/mbmprym9SDM?t=01h46m21s)

[oh if debugger is not attached](https://youtu.be/mbmprym9SDM?t=01h46m23s)

[okay boolean logic is hard](https://youtu.be/mbmprym9SDM?t=01h46m29s)

[uh will inconclusive tests still mark](https://youtu.be/mbmprym9SDM?t=01h46m32s)

[the pipeline run as failed ah](https://youtu.be/mbmprym9SDM?t=01h46m34s)

[no](https://youtu.be/mbmprym9SDM?t=01h46m38s)

[no they will not](https://youtu.be/mbmprym9SDM?t=01h46m40s)

[um which is a blessing and a curse they](https://youtu.be/mbmprym9SDM?t=01h46m42s)

[will show up as uh like warning level so](https://youtu.be/mbmprym9SDM?t=01h46m45s)

[you will see like the little yellow](https://youtu.be/mbmprym9SDM?t=01h46m48s)

[thing saying hey](https://youtu.be/mbmprym9SDM?t=01h46m50s)

[this one didn't didn't run](https://youtu.be/mbmprym9SDM?t=01h46m52s)

[so yellow on run](https://youtu.be/mbmprym9SDM?t=01h46m55s)

[green on debug](https://youtu.be/mbmprym9SDM?t=01h46m58s)

[and it's worth noting that debug in this](https://youtu.be/mbmprym9SDM?t=01h47m01s)

[case doesn't mean the debug](https://youtu.be/mbmprym9SDM?t=01h47m03s)

[configuration it means with debugger](https://youtu.be/mbmprym9SDM?t=01h47m04s)

[attached](https://youtu.be/mbmprym9SDM?t=01h47m06s)

[okay](https://youtu.be/mbmprym9SDM?t=01h47m12s)

[well that worked with what i with what i](https://youtu.be/mbmprym9SDM?t=01h47m13s)

[wanted](https://youtu.be/mbmprym9SDM?t=01h47m15s)

[trying to think if there's any other way](https://youtu.be/mbmprym9SDM?t=01h47m16s)

[i can write a good test for this](https://youtu.be/mbmprym9SDM?t=01h47m18s)

[let's just run the the whole suite of](https://youtu.be/mbmprym9SDM?t=01h47m20s)

[tests through here](https://youtu.be/mbmprym9SDM?t=01h47m22s)

[because i just want to make sure that](https://youtu.be/mbmprym9SDM?t=01h47m24s)

[you'll see some windows flash as these](https://youtu.be/mbmprym9SDM?t=01h47m26s)

[tests go because they do a bunch of](https://youtu.be/mbmprym9SDM?t=01h47m28s)

[window creations](https://youtu.be/mbmprym9SDM?t=01h47m29s)

[okay so i at least didn't break the rest](https://youtu.be/mbmprym9SDM?t=01h47m31s)

[of the app class okay now we got to go](https://youtu.be/mbmprym9SDM?t=01h47m33s)

[back and really check](https://youtu.be/mbmprym9SDM?t=01h47m35s)

[um](https://youtu.be/mbmprym9SDM?t=01h47m37s)

[okay so that goes there](https://youtu.be/mbmprym9SDM?t=01h47m38s)

[that was just to clean up there](https://youtu.be/mbmprym9SDM?t=01h47m40s)

[noble warning fix there](https://youtu.be/mbmprym9SDM?t=01h47m43s)

[the test](https://youtu.be/mbmprym9SDM?t=01h47m48s)

[see app.xaml i](https://youtu.be/mbmprym9SDM?t=01h47m50s)

[i'm gonna discard that it's a good](https://youtu.be/mbmprym9SDM?t=01h47m54s)

[formatting change](https://youtu.be/mbmprym9SDM?t=01h47m56s)

[it's a good formatting change i don't](https://youtu.be/mbmprym9SDM?t=01h47m59s)

[need either of those](https://youtu.be/mbmprym9SDM?t=01h48m01s)

[this one i'm gonna keep](https://youtu.be/mbmprym9SDM?t=01h48m03s)

[okay](https://youtu.be/mbmprym9SDM?t=01h48m07s)

[now we've got a a little bit larger](https://youtu.be/mbmprym9SDM?t=01h48m09s)

[setup](https://youtu.be/mbmprym9SDM?t=01h48m11s)

[let's see uh](https://youtu.be/mbmprym9SDM?t=01h48m13s)

[fix issue with apps](https://youtu.be/mbmprym9SDM?t=01h48m15s)

[startup failing](https://youtu.be/mbmprym9SDM?t=01h48m18s)

[um](https://youtu.be/mbmprym9SDM?t=01h48m20s)

[tempted fix for](https://youtu.be/mbmprym9SDM?t=01h48m23s)

[and then i want the issue number](https://youtu.be/mbmprym9SDM?t=01h48m26s)

[so it's hard to say that this is the](https://youtu.be/mbmprym9SDM?t=01h48m30s)

[exact fix](https://youtu.be/mbmprym9SDM?t=01h48m32s)

[but we did see](https://youtu.be/mbmprym9SDM?t=01h48m34s)

[we did see a failure that was similar](https://youtu.be/mbmprym9SDM?t=01h48m36s)

[so i'll move this so my my big head](https://youtu.be/mbmprym9SDM?t=01h48m38s)

[isn't in the way we did see a failure](https://youtu.be/mbmprym9SDM?t=01h48m41s)

[that was similar so it's potentially](https://youtu.be/mbmprym9SDM?t=01h48m43s)

[related](https://youtu.be/mbmprym9SDM?t=01h48m46s)

[uh this](https://youtu.be/mbmprym9SDM?t=01h48m47s)

[may have](https://youtu.be/mbmprym9SDM?t=01h48m49s)

[been due to a](https://youtu.be/mbmprym9SDM?t=01h48m50s)

[timing issue with the](https://youtu.be/mbmprym9SDM?t=01h48m53s)

[latest vs](https://youtu.be/mbmprym9SDM?t=01h48m56s)

[debugger support](https://youtu.be/mbmprym9SDM?t=01h48m57s)

[this uh](https://youtu.be/mbmprym9SDM?t=01h49m00s)

[feature](https://youtu.be/mbmprym9SDM?t=01h49m02s)

[has been](https://youtu.be/mbmprym9SDM?t=01h49m03s)

[moved to a new](https://youtu.be/mbmprym9SDM?t=01h49m05s)

[app dot](https://youtu.be/mbmprym9SDM?t=01h49m08s)

[start with](https://youtu.be/mbmprym9SDM?t=01h49m10s)

[bugger method](https://youtu.be/mbmprym9SDM?t=01h49m12s)

[uh](https://youtu.be/mbmprym9SDM?t=01h49m16s)

[and now](https://youtu.be/mbmprym9SDM?t=01h49m18s)

[supports retry](https://youtu.be/mbmprym9SDM?t=01h49m20s)

[which](https://youtu.be/mbmprym9SDM?t=01h49m23s)

[likely will help](https://youtu.be/mbmprym9SDM?t=01h49m24s)

[we think](https://youtu.be/mbmprym9SDM?t=01h49m28s)

[so commit](https://youtu.be/mbmprym9SDM?t=01h49m29s)

[push oh wait wait wait we don't have to](https://youtu.be/mbmprym9SDM?t=01h49m31s)

[push we don't have to push](https://youtu.be/mbmprym9SDM?t=01h49m32s)

[oh that's so nice so nice i actually](https://youtu.be/mbmprym9SDM?t=01h49m36s)

[like the right click](https://youtu.be/mbmprym9SDM?t=01h49m39s)

[i like the right click](https://youtu.be/mbmprym9SDM?t=01h49m42s)

[let's see](https://youtu.be/mbmprym9SDM?t=01h49m47s)

[great pull request and i'm not going to](https://youtu.be/mbmprym9SDM?t=01h49m49s)

[mark this as fixes the issue but i think](https://youtu.be/mbmprym9SDM?t=01h49m51s)

[i am going to go back and leave a](https://youtu.be/mbmprym9SDM?t=01h49m54s)

[comment on this](https://youtu.be/mbmprym9SDM?t=01h49m55s)

[um](https://youtu.be/mbmprym9SDM?t=01h49m57s)

[questions](https://youtu.be/mbmprym9SDM?t=01h50m03s)

[uh first which](https://youtu.be/mbmprym9SDM?t=01h50m05s)

[version of the](https://youtu.be/mbmprym9SDM?t=01h50m07s)

[library are you using](https://youtu.be/mbmprym9SDM?t=01h50m09s)

[um](https://youtu.be/mbmprym9SDM?t=01h50m13s)

[uh](https://youtu.be/mbmprym9SDM?t=01h50m15s)

[if it](https://youtu.be/mbmprym9SDM?t=01h50m18s)

[was one of the](https://youtu.be/mbmprym9SDM?t=01h50m19s)

[what was my nuget version i gotta add it](https://youtu.be/mbmprym9SDM?t=01h50m22s)

[i gotta add a nuget.org link](https://youtu.be/mbmprym9SDM?t=01h50m25s)

[saml test](https://youtu.be/mbmprym9SDM?t=01h50m28s)

[uh if it was one of the](https://youtu.be/mbmprym9SDM?t=01h50m29s)

[oh i haven't actually](https://youtu.be/mbmprym9SDM?t=01h50m33s)

[well i haven't actually hit 1.0 yet i](https://youtu.be/mbmprym9SDM?t=01h50m35s)

[thought i released 1.0 i even hit 1.0](https://youtu.be/mbmprym9SDM?t=01h50m37s)

[these are preview builds](https://youtu.be/mbmprym9SDM?t=01h50m39s)

[uh](https://youtu.be/mbmprym9SDM?t=01h50m42s)

[the](https://youtu.be/mbmprym9SDM?t=01h50m44s)

[early 1.0](https://youtu.be/mbmprym9SDM?t=01h50m45s)

[review](https://youtu.be/mbmprym9SDM?t=01h50m48s)

[builds](https://youtu.be/mbmprym9SDM?t=01h50m50s)

[it's](https://youtu.be/mbmprym9SDM?t=01h50m51s)

[possible the failure was due to a](https://youtu.be/mbmprym9SDM?t=01h50m52s)

[uh](https://youtu.be/mbmprym9SDM?t=01h50m57s)

[yes](https://youtu.be/mbmprym9SDM?t=01h50m58s)

[debugger](https://youtu.be/mbmprym9SDM?t=01h51m00s)

[feature](https://youtu.be/mbmprym9SDM?t=01h51m02s)

[failure](https://youtu.be/mbmprym9SDM?t=01h51m03s)

[i have](https://youtu.be/mbmprym9SDM?t=01h51m04s)

[emptied](https://youtu.be/mbmprym9SDM?t=01h51m06s)

[a fix](https://youtu.be/mbmprym9SDM?t=01h51m08s)

[in](https://youtu.be/mbmprym9SDM?t=01h51m10s)

[full request number uh in](https://youtu.be/mbmprym9SDM?t=01h51m13s)

[pounds](https://youtu.be/mbmprym9SDM?t=01h51m17s)

[67 you](https://youtu.be/mbmprym9SDM?t=01h51m18s)

[could](https://youtu.be/mbmprym9SDM?t=01h51m20s)

[test](https://youtu.be/mbmprym9SDM?t=01h51m22s)

[uh let's see i'm trying to remember does](https://youtu.be/mbmprym9SDM?t=01h51m23s)

[this thing just kick nightlys all the](https://youtu.be/mbmprym9SDM?t=01h51m26s)

[time or how does it do it](https://youtu.be/mbmprym9SDM?t=01h51m28s)

[uh](https://youtu.be/mbmprym9SDM?t=01h51m31s)

[i can't remember if this thing just](https://youtu.be/mbmprym9SDM?t=01h51m33s)

[always](https://youtu.be/mbmprym9SDM?t=01h51m35s)

[pushes nougats](https://youtu.be/mbmprym9SDM?t=01h51m36s)

[it does so it'll push a nougat every](https://youtu.be/mbmprym9SDM?t=01h51m37s)

[time](https://youtu.be/mbmprym9SDM?t=01h51m40s)

[every time after a merge](https://youtu.be/mbmprym9SDM?t=01h51m41s)

[great](https://youtu.be/mbmprym9SDM?t=01h51m44s)

[fast](https://youtu.be/mbmprym9SDM?t=01h51m45s)

[uh you could test](https://youtu.be/mbmprym9SDM?t=01h51m46s)

[uh](https://youtu.be/mbmprym9SDM?t=01h51m50s)

[let's see i can i don't know exactly](https://youtu.be/mbmprym9SDM?t=01h51m51s)

[which one it is](https://youtu.be/mbmprym9SDM?t=01h51m53s)

[any build](https://youtu.be/mbmprym9SDM?t=01h51m54s)

[see here you could test](https://youtu.be/mbmprym9SDM?t=01h51m59s)

[any build](https://youtu.be/mbmprym9SDM?t=01h52m02s)

[after](https://youtu.be/mbmprym9SDM?t=01h52m06s)

[uh actually it's important to say](https://youtu.be/mbmprym9SDM?t=01h52m14s)

[uh](https://youtu.be/mbmprym9SDM?t=01h52m19s)

[is](https://youtu.be/mbmprym9SDM?t=01h52m22s)

[fixed](https://youtu.be/mbmprym9SDM?t=01h52m23s)

[uh](https://youtu.be/mbmprym9SDM?t=01h52m25s)

[that would be](https://youtu.be/mbmprym9SDM?t=01h52m26s)

[great](https://youtu.be/mbmprym9SDM?t=01h52m28s)

[cool it is worth noting i had initially](https://youtu.be/mbmprym9SDM?t=01h52m30s)

[built this library to not be a full ui](https://youtu.be/mbmprym9SDM?t=01h52m32s)

[testing library and had designed it to](https://youtu.be/mbmprym9SDM?t=01h52m35s)

[be](https://youtu.be/mbmprym9SDM?t=01h52m37s)

[testing around](https://youtu.be/mbmprym9SDM?t=01h52m38s)

[like ui components and styles and themes](https://youtu.be/mbmprym9SDM?t=01h52m40s)

[but it feels a little more useful than](https://youtu.be/mbmprym9SDM?t=01h52m44s)

[that](https://youtu.be/mbmprym9SDM?t=01h52m46s)

[so](https://youtu.be/mbmprym9SDM?t=01h52m49s)

[it feels a little nicer i like it a](https://youtu.be/mbmprym9SDM?t=01h52m50s)

[little better](https://youtu.be/mbmprym9SDM?t=01h52m52s)

[so we will](https://youtu.be/mbmprym9SDM?t=01h52m55s)

[see okay so while that guy well that guy](https://youtu.be/mbmprym9SDM?t=01h52m56s)

[thinks about about what he's doing we](https://youtu.be/mbmprym9SDM?t=01h53m00s)

[need to clean some stuff up here so](https://youtu.be/mbmprym9SDM?t=01h53m02s)

[specifically](https://youtu.be/mbmprym9SDM?t=01h53m04s)

[just read me](https://youtu.be/mbmprym9SDM?t=01h53m05s)

[we need a nudia badge](https://youtu.be/mbmprym9SDM?t=01h53m07s)

[where is the](https://youtu.be/mbmprym9SDM?t=01h53m11s)

[i thought there was a nice little nougat](https://youtu.be/mbmprym9SDM?t=01h53m14s)

[badge thingy right on here](https://youtu.be/mbmprym9SDM?t=01h53m16s)

[i am i making that up](https://youtu.be/mbmprym9SDM?t=01h53m19s)

[okay i apparently am making that up so](https://youtu.be/mbmprym9SDM?t=01h53m23s)

[let's just go steal one](https://youtu.be/mbmprym9SDM?t=01h53m26s)

[boom material design](https://youtu.be/mbmprym9SDM?t=01h53m29s)

[this thing has a nice nougat badge](https://youtu.be/mbmprym9SDM?t=01h53m31s)

[uh so i want to just look at whatever](https://youtu.be/mbmprym9SDM?t=01h53m36s)

[the heck i did here i did do something](https://youtu.be/mbmprym9SDM?t=01h53m38s)

[uh](https://youtu.be/mbmprym9SDM?t=01h53m41s)

[raw](https://youtu.be/mbmprym9SDM?t=01h53m43s)

[uh let's see](https://youtu.be/mbmprym9SDM?t=01h53m46s)

[oh i'm just going through img shields is](https://youtu.be/mbmprym9SDM?t=01h53m48s)

[how we're doing it](https://youtu.be/mbmprym9SDM?t=01h53m51s)

[we can grab](https://youtu.be/mbmprym9SDM?t=01h53m53s)

[this](https://youtu.be/mbmprym9SDM?t=01h53m55s)

[and we can come back over to here](https://youtu.be/mbmprym9SDM?t=01h53m58s)

[and then we slap this guy in](https://youtu.be/mbmprym9SDM?t=01h54m02s)

[now important thing to note this guy](https://youtu.be/mbmprym9SDM?t=01h54m05s)

[here needs to be](https://youtu.be/mbmprym9SDM?t=01h54m07s)

[xaml test](https://youtu.be/mbmprym9SDM?t=01h54m10s)

[and then](https://youtu.be/mbmprym9SDM?t=01h54m14s)

[nougat](https://youtu.be/mbmprym9SDM?t=01h54m16s)

[trying to think this is nougat themes](https://youtu.be/mbmprym9SDM?t=01h54m22s)

[and then this should be](https://youtu.be/mbmprym9SDM?t=01h54m25s)

[xaml test](https://youtu.be/mbmprym9SDM?t=01h54m29s)

[i believe is the right url](https://youtu.be/mbmprym9SDM?t=01h54m31s)

[let me just drop this off](https://youtu.be/mbmprym9SDM?t=01h54m34s)

[that will take me where i want to go](https://youtu.be/mbmprym9SDM?t=01h54m36s)

[and preview](https://youtu.be/mbmprym9SDM?t=01h54m40s)

[uh](https://youtu.be/mbmprym9SDM?t=01h54m45s)

[see i'm trying to decide what this text](https://youtu.be/mbmprym9SDM?t=01h54m46s)

[should be](https://youtu.be/mbmprym9SDM?t=01h54m48s)

[[Music]](https://youtu.be/mbmprym9SDM?t=01h54m50s)

[i think we just do nougat](https://youtu.be/mbmprym9SDM?t=01h54m53s)

[and drop this off and just let that be](https://youtu.be/mbmprym9SDM?t=01h54m55s)

[nuget as well](https://youtu.be/mbmprym9SDM?t=01h54m58s)

[i think that's probably just fine](https://youtu.be/mbmprym9SDM?t=01h55m00s)

[yeah](https://youtu.be/mbmprym9SDM?t=01h55m03s)

[though i'm also thinking that i don't](https://youtu.be/mbmprym9SDM?t=01h55m05s)

[like the](https://youtu.be/mbmprym9SDM?t=01h55m07s)

[flat style](https://youtu.be/mbmprym9SDM?t=01h55m08s)

[i think if i just turn that off](https://youtu.be/mbmprym9SDM?t=01h55m10s)

[default looks](https://youtu.be/mbmprym9SDM?t=01h55m12s)

[prettier yeah that's a little better](https://youtu.be/mbmprym9SDM?t=01h55m16s)

[is it different](https://youtu.be/mbmprym9SDM?t=01h55m21s)

[slightly has the rounded corners](https://youtu.be/mbmprym9SDM?t=01h55m24s)

[okay we'll go around the corners rounded](https://youtu.be/mbmprym9SDM?t=01h55m26s)

[corners are pretty](https://youtu.be/mbmprym9SDM?t=01h55m28s)

[okay so there's that there's that that](https://youtu.be/mbmprym9SDM?t=01h55m30s)

[works that works that works](https://youtu.be/mbmprym9SDM?t=01h55m33s)

[uh let's see here](https://youtu.be/mbmprym9SDM?t=01h55m35s)

[this extra set of](https://youtu.be/mbmprym9SDM?t=01h55m38s)

[doohickeys is it needed](https://youtu.be/mbmprym9SDM?t=01h55m41s)

[oh it is if i want that whole thing to](https://youtu.be/mbmprym9SDM?t=01h55m44s)

[be a link](https://youtu.be/mbmprym9SDM?t=01h55m47s)

[but won't this work without that](https://youtu.be/mbmprym9SDM?t=01h55m51s)

[ah it'll just take me to there oh that's](https://youtu.be/mbmprym9SDM?t=01h55m54s)

[why i did that](https://youtu.be/mbmprym9SDM?t=01h55m57s)

[that was smart of me okay so we put that](https://youtu.be/mbmprym9SDM?t=01h55m58s)

[back](https://youtu.be/mbmprym9SDM?t=01h56m00s)

[doesn't that mean this is a](https://youtu.be/mbmprym9SDM?t=01h56m02s)

[yeah that's](https://youtu.be/mbmprym9SDM?t=01h56m05s)

[okay okay we're fixing that too while](https://youtu.be/mbmprym9SDM?t=01h56m06s)

[we're in here](https://youtu.be/mbmprym9SDM?t=01h56m08s)

[so we'll make this a link actually over](https://youtu.be/mbmprym9SDM?t=01h56m10s)

[to the latest build](https://youtu.be/mbmprym9SDM?t=01h56m12s)

[so let's grab that](https://youtu.be/mbmprym9SDM?t=01h56m14s)

[and decide](https://youtu.be/mbmprym9SDM?t=01h56m17s)

[yeah we'll just do this](https://youtu.be/mbmprym9SDM?t=01h56m19s)

[this is probably a reasonable](https://youtu.be/mbmprym9SDM?t=01h56m22s)

[link](https://youtu.be/mbmprym9SDM?t=01h56m24s)

[let's test it](https://youtu.be/mbmprym9SDM?t=01h56m28s)

[uh](https://youtu.be/mbmprym9SDM?t=01h56m30s)

[middle click](https://youtu.be/mbmprym9SDM?t=01h56m32s)

[okay that works](https://youtu.be/mbmprym9SDM?t=01h56m34s)

[uh](https://youtu.be/mbmprym9SDM?t=01h56m37s)

[let's see i'm going to](https://youtu.be/mbmprym9SDM?t=01h56m38s)

[cheater mode this thing in](https://youtu.be/mbmprym9SDM?t=01h56m43s)

[think](https://youtu.be/mbmprym9SDM?t=01h56m46s)

[uh](https://youtu.be/mbmprym9SDM?t=01h56m47s)

[create a new branch](https://youtu.be/mbmprym9SDM?t=01h56m52s)

[about update read me](https://youtu.be/mbmprym9SDM?t=01h56m54s)

[close change](https://youtu.be/mbmprym9SDM?t=01h56m58s)

[boom create pull request](https://youtu.be/mbmprym9SDM?t=01h57m00s)

[watch merge squash merge](https://youtu.be/mbmprym9SDM?t=01h57m02s)

[cool so that goes in](https://youtu.be/mbmprym9SDM?t=01h57m07s)

[oh this thing's](https://youtu.be/mbmprym9SDM?t=01h57m10s)

[it's annoying](https://youtu.be/mbmprym9SDM?t=01h57m14s)

[it is really annoying okay so](https://youtu.be/mbmprym9SDM?t=01h57m16s)

[for people who didn't notice that that](https://youtu.be/mbmprym9SDM?t=01h57m19s)

[was the period hotkey](https://youtu.be/mbmprym9SDM?t=01h57m21s)

[on github you can also change the dot](https://youtu.be/mbmprym9SDM?t=01h57m24s)

[com.dev to get the same result](https://youtu.be/mbmprym9SDM?t=01h57m25s)

[and](https://youtu.be/mbmprym9SDM?t=01h57m30s)

[what i would like to do is come into](https://youtu.be/mbmprym9SDM?t=01h57m33s)

[here](https://youtu.be/mbmprym9SDM?t=01h57m35s)

[to ignore readme.md](https://youtu.be/mbmprym9SDM?t=01h57m38s)

[no why did that trigger then](https://youtu.be/mbmprym9SDM?t=01h57m42s)

[this feature is way too hidden](https://youtu.be/mbmprym9SDM?t=01h57m48s)

[the the period i i can agree it is](https://youtu.be/mbmprym9SDM?t=01h57m51s)

[it is one of the coolest things ever is](https://youtu.be/mbmprym9SDM?t=01h57m55s)

[you can literally get vs in a browser](https://youtu.be/mbmprym9SDM?t=01h57m57s)

[running against a repo](https://youtu.be/mbmprym9SDM?t=01h58m00s)

[and as you saw with like](https://youtu.be/mbmprym9SDM?t=01h58m02s)

[full pull requests and all that you can](https://youtu.be/mbmprym9SDM?t=01h58m05s)

[run extensions](https://youtu.be/mbmprym9SDM?t=01h58m07s)

[um](https://youtu.be/mbmprym9SDM?t=01h58m10s)

[however the extensions that you get are](https://youtu.be/mbmprym9SDM?t=01h58m11s)

[limited to extensions that don't require](https://youtu.be/mbmprym9SDM?t=01h58m13s)

[any sort of uh background compute](https://youtu.be/mbmprym9SDM?t=01h58m15s)

[so](https://youtu.be/mbmprym9SDM?t=01h58m18s)

[things like uh omnisharp you cannot run](https://youtu.be/mbmprym9SDM?t=01h58m19s)

[because omnisharp requires a server](https://youtu.be/mbmprym9SDM?t=01h58m22s)

[running for like c-sharp stuff but basic](https://youtu.be/mbmprym9SDM?t=01h58m24s)

[extensions that just do like syntax](https://youtu.be/mbmprym9SDM?t=01h58m26s)

[highlighting you can get working get](https://youtu.be/mbmprym9SDM?t=01h58m28s)

[lens you can get working](https://youtu.be/mbmprym9SDM?t=01h58m30s)

[um so some of the theming stuff and](https://youtu.be/mbmprym9SDM?t=01h58m32s)

[those types of stuff will will work for](https://youtu.be/mbmprym9SDM?t=01h58m34s)

[you](https://youtu.be/mbmprym9SDM?t=01h58m37s)

[and you'll note it also remembers your](https://youtu.be/mbmprym9SDM?t=01h58m38s)

[settings and whatnot because it's just](https://youtu.be/mbmprym9SDM?t=01h58m40s)

[that level of cool](https://youtu.be/mbmprym9SDM?t=01h58m42s)

[did that reload all my extensions yay](https://youtu.be/mbmprym9SDM?t=01h58m45s)

[um](https://youtu.be/mbmprym9SDM?t=01h58m49s)

[i'm a little confused as to why this](https://youtu.be/mbmprym9SDM?t=01h58m50s)

[paths to ignore](https://youtu.be/mbmprym9SDM?t=01h58m52s)

[oh](https://youtu.be/mbmprym9SDM?t=01h58m55s)

[it's because it's a pull request this](https://youtu.be/mbmprym9SDM?t=01h58m56s)

[path is to ignore](https://youtu.be/mbmprym9SDM?t=01h58m59s)

[uh](https://youtu.be/mbmprym9SDM?t=01h59m02s)

[if i recall correctly this is distinct](https://youtu.be/mbmprym9SDM?t=01h59m03s)

[from code spaces so no running your app](https://youtu.be/mbmprym9SDM?t=01h59m05s)

[right](https://youtu.be/mbmprym9SDM?t=01h59m07s)

[correct yes](https://youtu.be/mbmprym9SDM?t=01h59m08s)

[um](https://youtu.be/mbmprym9SDM?t=01h59m10s)

[and last i heard they were looking at](https://youtu.be/mbmprym9SDM?t=01h59m12s)

[ways of](https://youtu.be/mbmprym9SDM?t=01h59m14s)

[kind of bridging those two because right](https://youtu.be/mbmprym9SDM?t=01h59m16s)

[now you kind of have a one or the other](https://youtu.be/mbmprym9SDM?t=01h59m19s)

[option](https://youtu.be/mbmprym9SDM?t=01h59m20s)

[and they were wanting to have they been](https://youtu.be/mbmprym9SDM?t=01h59m21s)

[get up we're wanting to have some sort](https://youtu.be/mbmprym9SDM?t=01h59m24s)

[of like](https://youtu.be/mbmprym9SDM?t=01h59m25s)

[way that you could](https://youtu.be/mbmprym9SDM?t=01h59m27s)

[advance from this into the next one so](https://youtu.be/mbmprym9SDM?t=01h59m28s)

[you know get started with this if you](https://youtu.be/mbmprym9SDM?t=01h59m31s)

[like it it's going well hey let's go](https://youtu.be/mbmprym9SDM?t=01h59m32s)

[ahead and add in a little bit more let's](https://youtu.be/mbmprym9SDM?t=01h59m34s)

[get in some code spaces because once you](https://youtu.be/mbmprym9SDM?t=01h59m36s)

[bring in co-spaces now you're paying for](https://youtu.be/mbmprym9SDM?t=01h59m38s)

[the compute so now we can do more](https://youtu.be/mbmprym9SDM?t=01h59m40s)

[which is pretty slick](https://youtu.be/mbmprym9SDM?t=01h59m42s)

[um i'm pretty sure what i want to do is](https://youtu.be/mbmprym9SDM?t=01h59m44s)

[this](https://youtu.be/mbmprym9SDM?t=01h59m47s)

[here](https://youtu.be/mbmprym9SDM?t=01h59m49s)

[i](https://youtu.be/mbmprym9SDM?t=01h59m50s)

[i'm pretty sure that's what i want](https://youtu.be/mbmprym9SDM?t=01h59m51s)

[so that it ignores the paths on both the](https://youtu.be/mbmprym9SDM?t=01h59m55s)

[push](https://youtu.be/mbmprym9SDM?t=01h59m58s)

[and that but let's just confirm that](https://youtu.be/mbmprym9SDM?t=01h59m59s)

[github actions documentation](https://youtu.be/mbmprym9SDM?t=02h00m01s)

[uh the github actions docs are actually](https://youtu.be/mbmprym9SDM?t=02h00m05s)

[quite good](https://youtu.be/mbmprym9SDM?t=02h00m08s)

[quite good uh let's see](https://youtu.be/mbmprym9SDM?t=02h00m10s)

[triggers](https://youtu.be/mbmprym9SDM?t=02h00m14s)

[events that trigger a workflow](https://youtu.be/mbmprym9SDM?t=02h00m15s)

[let's go syntax i think might be a](https://youtu.be/mbmprym9SDM?t=02h00m20s)

[better thing](https://youtu.be/mbmprym9SDM?t=02h00m21s)

[because what i'm really looking for is](https://youtu.be/mbmprym9SDM?t=02h00m23s)

[where](https://youtu.be/mbmprym9SDM?t=02h00m25s)

[yeah on pull request because that's what](https://youtu.be/mbmprym9SDM?t=02h00m28s)

[i've got right i've got a](https://youtu.be/mbmprym9SDM?t=02h00m30s)

[on pull request](https://youtu.be/mbmprym9SDM?t=02h00m32s)

[okay](https://youtu.be/mbmprym9SDM?t=02h00m35s)

[including branches excluding branches](https://youtu.be/mbmprym9SDM?t=02h00m40s)

[uh](https://youtu.be/mbmprym9SDM?t=02h00m44s)

[on push](https://youtu.be/mbmprym9SDM?t=02h00m46s)

[does it not have](https://youtu.be/mbmprym9SDM?t=02h00m48s)

[okay so if you define both branches](https://youtu.be/mbmprym9SDM?t=02h00m53s)

[branches ignore and paths the workflow](https://youtu.be/mbmprym9SDM?t=02h00m55s)

[will only run when all of those things](https://youtu.be/mbmprym9SDM?t=02h00m58s)

[and paths i believe are what we were](https://youtu.be/mbmprym9SDM?t=02h01m00s)

[best find](https://youtu.be/mbmprym9SDM?t=02h01m02s)

[right because we were saying pads ignore](https://youtu.be/mbmprym9SDM?t=02h01m04s)

[paths ignore](https://youtu.be/mbmprym9SDM?t=02h01m08s)

[got it](https://youtu.be/mbmprym9SDM?t=02h01m11s)

[so yeah so that is so that is what i](https://youtu.be/mbmprym9SDM?t=02h01m13s)

[want](https://youtu.be/mbmprym9SDM?t=02h01m16s)

[is](https://youtu.be/mbmprym9SDM?t=02h01m17s)

[that guy](https://youtu.be/mbmprym9SDM?t=02h01m18s)

[tell it stop it](https://youtu.be/mbmprym9SDM?t=02h01m20s)

[um let's see](https://youtu.be/mbmprym9SDM?t=02h01m22s)

[including](https://youtu.be/mbmprym9SDM?t=02h01m24s)

[uh](https://youtu.be/mbmprym9SDM?t=02h01m26s)

[skipping builds or](https://youtu.be/mbmprym9SDM?t=02h01m28s)

[markdown](https://youtu.be/mbmprym9SDM?t=02h01m31s)

[i guess read me or whatnot probably](https://youtu.be/mbmprym9SDM?t=02h01m34s)

[would have been cleaner](https://youtu.be/mbmprym9SDM?t=02h01m36s)

[so your changes will be committed and](https://youtu.be/mbmprym9SDM?t=02h01m40s)

[immediately pushed to the updated readme](https://youtu.be/mbmprym9SDM?t=02h01m41s)

[branch on github so because there are](https://youtu.be/mbmprym9SDM?t=02h01m43s)

[because there is no](https://youtu.be/mbmprym9SDM?t=02h01m45s)

[local fork i'm](https://youtu.be/mbmprym9SDM?t=02h01m47s)

[basically editing out on my remote fork](https://youtu.be/mbmprym9SDM?t=02h01m49s)

[committing is the same as commit push](https://youtu.be/mbmprym9SDM?t=02h01m51s)

[from a from a functional perspective now](https://youtu.be/mbmprym9SDM?t=02h01m55s)

[what does this do here i would hope that](https://youtu.be/mbmprym9SDM?t=02h01m59s)

[it would cancel the existing action and](https://youtu.be/mbmprym9SDM?t=02h02m01s)

[then trigger the next one but i](https://youtu.be/mbmprym9SDM?t=02h02m02s)

[well clearly it didn't it queued another](https://youtu.be/mbmprym9SDM?t=02h02m07s)

[one](https://youtu.be/mbmprym9SDM?t=02h02m10s)

[i told you very explicitly to ignore](https://youtu.be/mbmprym9SDM?t=02h02m11s)

[this](https://youtu.be/mbmprym9SDM?t=02h02m14s)

[why are you still running against it](https://youtu.be/mbmprym9SDM?t=02h02m17s)

[readme.md i'm not stupid right like that](https://youtu.be/mbmprym9SDM?t=02h02m20s)

[is legitimately](https://youtu.be/mbmprym9SDM?t=02h02m23s)

[i don't have a file name problem here](https://youtu.be/mbmprym9SDM?t=02h02m26s)

[readme.md](https://youtu.be/mbmprym9SDM?t=02h02m29s)

[i mean it's valid syntax](https://youtu.be/mbmprym9SDM?t=02h02m39s)

[paths ignore](https://youtu.be/mbmprym9SDM?t=02h02m46s)

[if any pads neutrino](https://youtu.be/mbmprym9SDM?t=02h02m48s)

[will only run the push events that](https://youtu.be/mbmprym9SDM?t=02h02m54s)

[include at least one file outside the](https://youtu.be/mbmprym9SDM?t=02h02m56s)

[docs directory](https://youtu.be/mbmprym9SDM?t=02h02m58s)

[you can do the paths with a](https://youtu.be/mbmprym9SDM?t=02h03m11s)

[bang](https://youtu.be/mbmprym9SDM?t=02h03m13s)

[just](https://youtu.be/mbmprym9SDM?t=02h03m16s)

[fine](https://youtu.be/mbmprym9SDM?t=02h03m17s)

[oh is it](https://youtu.be/mbmprym9SDM?t=02h03m20s)

[that the problem](https://youtu.be/mbmprym9SDM?t=02h03m24s)

[is it legitimately a yaml problem i](https://youtu.be/mbmprym9SDM?t=02h03m25s)

[yaml](https://youtu.be/mbmprym9SDM?t=02h03m28s)

[indentation question mark anyone who has](https://youtu.be/mbmprym9SDM?t=02h03m32s)

[done](https://youtu.be/mbmprym9SDM?t=02h03m35s)

[yaml work should be familiar with this](https://youtu.be/mbmprym9SDM?t=02h03m36s)

[workflow of](https://youtu.be/mbmprym9SDM?t=02h03m39s)

[queue it about 80 million times](https://youtu.be/mbmprym9SDM?t=02h03m40s)

[uh okay so we're gonna](https://youtu.be/mbmprym9SDM?t=02h03m44s)

[that one i want to leave going](https://youtu.be/mbmprym9SDM?t=02h03m46s)

[you i just want to cancel](https://youtu.be/mbmprym9SDM?t=02h03m49s)

[because you're you're meaningless](https://youtu.be/mbmprym9SDM?t=02h03m51s)

[and then you](https://youtu.be/mbmprym9SDM?t=02h03m55s)

[triggered via pull request 16 seconds](https://youtu.be/mbmprym9SDM?t=02h03m59s)

[ago i said no](https://youtu.be/mbmprym9SDM?t=02h04m01s)

[paths ignore](https://youtu.be/mbmprym9SDM?t=02h04m07s)

[am i stupid](https://youtu.be/mbmprym9SDM?t=02h04m11s)

[that was a rhetorical question by the](https://youtu.be/mbmprym9SDM?t=02h04m14s)

[way](https://youtu.be/mbmprym9SDM?t=02h04m15s)

[um](https://youtu.be/mbmprym9SDM?t=02h04m16s)

[oh i wonder](https://youtu.be/mbmprym9SDM?t=02h04m30s)

[i wonder if i can't exclude it because](https://youtu.be/mbmprym9SDM?t=02h04m33s)

[it is a merge requirement into my branch](https://youtu.be/mbmprym9SDM?t=02h04m36s)

[i](https://youtu.be/mbmprym9SDM?t=02h04m43s)

[bet you that's the kicker](https://youtu.be/mbmprym9SDM?t=02h04m44s)

[because i have a requirement that says](https://youtu.be/mbmprym9SDM?t=02h04m50s)

[that](https://youtu.be/mbmprym9SDM?t=02h04m53s)

[yeah because i have a check that](https://youtu.be/mbmprym9SDM?t=02h04m57s)

[requires it to pass before it merges](https://youtu.be/mbmprym9SDM?t=02h04m59s)

[okay we run all jobs yes rerun](https://youtu.be/mbmprym9SDM?t=02h05m04s)

[i bet you that's the kicker is there's](https://youtu.be/mbmprym9SDM?t=02h05m08s)

[not a clean way to exclude](https://youtu.be/mbmprym9SDM?t=02h05m09s)

[on a pr](https://youtu.be/mbmprym9SDM?t=02h05m14s)

[i guess i should actually cancel this](https://youtu.be/mbmprym9SDM?t=02h05m20s)

[and](https://youtu.be/mbmprym9SDM?t=02h05m21s)

[push this in](https://youtu.be/mbmprym9SDM?t=02h05m22s)

[[Music]](https://youtu.be/mbmprym9SDM?t=02h05m24s)

[hmm](https://youtu.be/mbmprym9SDM?t=02h05m26s)

[that unfortunately makes sense and i](https://youtu.be/mbmprym9SDM?t=02h05m27s)

[don't know the best solution](https://youtu.be/mbmprym9SDM?t=02h05m29s)

[uh](https://youtu.be/mbmprym9SDM?t=02h05m31s)

[yes i'm now on four commits to add a](https://youtu.be/mbmprym9SDM?t=02h05m35s)

[badge to my readme that's probably](https://youtu.be/mbmprym9SDM?t=02h05m38s)

[overkill](https://youtu.be/mbmprym9SDM?t=02h05m40s)

[uh that should kick off one more](https://youtu.be/mbmprym9SDM?t=02h05m42s)

[you should run and you should finish](https://youtu.be/mbmprym9SDM?t=02h05m46s)

[you should now do a](https://youtu.be/mbmprym9SDM?t=02h05m51s)

[bunch more work](https://youtu.be/mbmprym9SDM?t=02h05m52s)

[okay so we will get](https://youtu.be/mbmprym9SDM?t=02h05m56s)

[yeah so i think that is the kicker is is](https://youtu.be/mbmprym9SDM?t=02h06m01s)

[when you have](https://youtu.be/mbmprym9SDM?t=02h06m04s)

[when you have a merger requirement so](https://youtu.be/mbmprym9SDM?t=02h06m06s)

[here and i can show you what i'm talking](https://youtu.be/mbmprym9SDM?t=02h06m08s)

[about](https://youtu.be/mbmprym9SDM?t=02h06m10s)

[under the settings under the branches](https://youtu.be/mbmprym9SDM?t=02h06m11s)

[i have this branch protection rule set](https://youtu.be/mbmprym9SDM?t=02h06m14s)

[and this requires](https://youtu.be/mbmprym9SDM?t=02h06m19s)

[status checks um](https://youtu.be/mbmprym9SDM?t=02h06m20s)

[to pass before these things can merge](https://youtu.be/mbmprym9SDM?t=02h06m23s)

[and because i have a status check](https://youtu.be/mbmprym9SDM?t=02h06m34s)

[requirement i don't know how to tell it](https://youtu.be/mbmprym9SDM?t=02h06m36s)

[to exclude](https://youtu.be/mbmprym9SDM?t=02h06m38s)

[hey](https://youtu.be/mbmprym9SDM?t=02h06m40s)

[xucci](https://youtu.be/mbmprym9SDM?t=02h06m41s)

[i apologize if i butchered that thanks](https://youtu.be/mbmprym9SDM?t=02h06m43s)

[for the follow appreciate it](https://youtu.be/mbmprym9SDM?t=02h06m44s)

[how's it going](https://youtu.be/mbmprym9SDM?t=02h06m49s)

[play](https://youtu.be/mbmprym9SDM?t=02h06m51s)

[a little annoyed at my github actions](https://youtu.be/mbmprym9SDM?t=02h06m52s)

[um but been playing with a library](https://youtu.be/mbmprym9SDM?t=02h06m56s)

[hey](https://youtu.be/mbmprym9SDM?t=02h07m00s)

[i credit the mountain dew with how late](https://youtu.be/mbmprym9SDM?t=02h07m02s)

[it is i i think it was probably half](https://youtu.be/mbmprym9SDM?t=02h07m04s)

[guest that got me there](https://youtu.be/mbmprym9SDM?t=02h07m06s)

[but no i've been working on my xaml test](https://youtu.be/mbmprym9SDM?t=02h07m10s)

[library](https://youtu.be/mbmprym9SDM?t=02h07m12s)

[which is a fun little library for](https://youtu.be/mbmprym9SDM?t=02h07m14s)

[testing c wpf ui stuff](https://youtu.be/mbmprym9SDM?t=02h07m16s)

[i i think we fixed](https://youtu.be/mbmprym9SDM?t=02h07m18s)

[the bug](https://youtu.be/mbmprym9SDM?t=02h07m21s)

[the only other thing that](https://youtu.be/mbmprym9SDM?t=02h07m22s)

[at some point i want to do i wrote this](https://youtu.be/mbmprym9SDM?t=02h07m24s)

[thing about document query syntax here](https://youtu.be/mbmprym9SDM?t=02h07m26s)

[uh](https://youtu.be/mbmprym9SDM?t=02h07m30s)

[[Music]](https://youtu.be/mbmprym9SDM?t=02h07m31s)

[uh reset move up](https://youtu.be/mbmprym9SDM?t=02h07m32s)

[the](https://youtu.be/mbmprym9SDM?t=02h07m36s)

[so](https://youtu.be/mbmprym9SDM?t=02h07m37s)

[okay i'll quickly talk through this but](https://youtu.be/mbmprym9SDM?t=02h07m38s)

[i don't know how much longer my stream's](https://youtu.be/mbmprym9SDM?t=02h07m40s)

[going to go because my mountain dew is](https://youtu.be/mbmprym9SDM?t=02h07m42s)

[empty](https://youtu.be/mbmprym9SDM?t=02h07m44s)

[and my energy is waning](https://youtu.be/mbmprym9SDM?t=02h07m45s)

[but](https://youtu.be/mbmprym9SDM?t=02h07m47s)

[so the the part that gets me or the part](https://youtu.be/mbmprym9SDM?t=02h07m48s)

[that has bitten me many times over](https://youtu.be/mbmprym9SDM?t=02h07m51s)

[uh yeah fire a question why i definitely](https://youtu.be/mbmprym9SDM?t=02h07m53s)

[don't mind questions at all](https://youtu.be/mbmprym9SDM?t=02h07m55s)

[i often rabbit trail](https://youtu.be/mbmprym9SDM?t=02h07m57s)

[the get element and get property have](https://youtu.be/mbmprym9SDM?t=02h08m02s)

[some somewhat advanced syntax that you](https://youtu.be/mbmprym9SDM?t=02h08m05s)

[can query on](https://youtu.be/mbmprym9SDM?t=02h08m07s)

[and it's kind of a pain](https://youtu.be/mbmprym9SDM?t=02h08m09s)

[so i was going to look at doing](https://youtu.be/mbmprym9SDM?t=02h08m11s)

[something fancy with a formattable](https://youtu.be/mbmprym9SDM?t=02h08m12s)

[string perhaps](https://youtu.be/mbmprym9SDM?t=02h08m14s)

[because th this one here says find the](https://youtu.be/mbmprym9SDM?t=02h08m18s)

[element that has the name my text block](https://youtu.be/mbmprym9SDM?t=02h08m20s)

[and this one here says find the first](https://youtu.be/mbmprym9SDM?t=02h08m23s)

[element that has the type of text block](https://youtu.be/mbmprym9SDM?t=02h08m25s)

[which is kind of cool](https://youtu.be/mbmprym9SDM?t=02h08m29s)

[um](https://youtu.be/mbmprym9SDM?t=02h08m31s)

[uh let's see for this code to work](https://youtu.be/mbmprym9SDM?t=02h08m36s)

[system cls](https://youtu.be/mbmprym9SDM?t=02h08m39s)

[[Music]](https://youtu.be/mbmprym9SDM?t=02h08m43s)

[looks like a function of some kind](https://youtu.be/mbmprym9SDM?t=02h08m44s)

[uh](https://youtu.be/mbmprym9SDM?t=02h08m48s)

[i was also contemplating expanding on](https://youtu.be/mbmprym9SDM?t=02h08m51s)

[this get element](https://youtu.be/mbmprym9SDM?t=02h08m53s)

[um because this feels like something](https://youtu.be/mbmprym9SDM?t=02h08m55s)

[that could easily be get element of t](https://youtu.be/mbmprym9SDM?t=02h08m57s)

[and have it automatically populate the](https://youtu.be/mbmprym9SDM?t=02h09m00s)

[query for me](https://youtu.be/mbmprym9SDM?t=02h09m02s)

[so rather than typing this](https://youtu.be/mbmprym9SDM?t=02h09m04s)

[feels like](https://youtu.be/mbmprym9SDM?t=02h09m07s)

[that should also be valid](https://youtu.be/mbmprym9SDM?t=02h09m10s)

[and then just have it infer that what i](https://youtu.be/mbmprym9SDM?t=02h09m15s)

[mean is a query by that the other thing](https://youtu.be/mbmprym9SDM?t=02h09m17s)

[i also contemplated](https://youtu.be/mbmprym9SDM?t=02h09m19s)

[is something rather than being like this](https://youtu.be/mbmprym9SDM?t=02h09m22s)

[something that's more along the lines of](https://youtu.be/mbmprym9SDM?t=02h09m25s)

[like](https://youtu.be/mbmprym9SDM?t=02h09m27s)

[query](https://youtu.be/mbmprym9SDM?t=02h09m29s)

[uh of type](https://youtu.be/mbmprym9SDM?t=02h09m32s)

[and you know](https://youtu.be/mbmprym9SDM?t=02h09m35s)

[something like this where there's an](https://youtu.be/mbmprym9SDM?t=02h09m37s)

[overload that takes in a some sort of](https://youtu.be/mbmprym9SDM?t=02h09m39s)

[query object that then you can build up](https://youtu.be/mbmprym9SDM?t=02h09m41s)

[so of type text blocks](https://youtu.be/mbmprym9SDM?t=02h09m44s)

[uh](https://youtu.be/mbmprym9SDM?t=02h09m47s)

[then and you know just start chaining](https://youtu.be/mbmprym9SDM?t=02h09m48s)

[things together](https://youtu.be/mbmprym9SDM?t=02h09m51s)

[i don't know if that makes it more](https://youtu.be/mbmprym9SDM?t=02h09m52s)

[readable slightly more discoverable](https://youtu.be/mbmprym9SDM?t=02h09m53s)

[perhaps](https://youtu.be/mbmprym9SDM?t=02h09m55s)

[not real sure not real sure i i the](https://youtu.be/mbmprym9SDM?t=02h09m59s)

[part of the issue is i can't remember my](https://youtu.be/mbmprym9SDM?t=02h10m02s)

[own magical query syntax that i wrote](https://youtu.be/mbmprym9SDM?t=02h10m04s)

[and if the author can't remember it i'm](https://youtu.be/mbmprym9SDM?t=02h10m07s)

[pretty sure](https://youtu.be/mbmprym9SDM?t=02h10m09s)

[uh nothing nothing is going to](https://youtu.be/mbmprym9SDM?t=02h10m11s)

[help and i i could i wrote on my issue](https://youtu.be/mbmprym9SDM?t=02h10m15s)

[that i need to document it because i'm](https://youtu.be/mbmprym9SDM?t=02h10m18s)

[tired of trying to remember where in the](https://youtu.be/mbmprym9SDM?t=02h10m20s)

[code it is to go and find it](https://youtu.be/mbmprym9SDM?t=02h10m21s)

[however](https://youtu.be/mbmprym9SDM?t=02h10m24s)

[i think it would be better to just make](https://youtu.be/mbmprym9SDM?t=02h10m26s)

[the code a little bit more intuitive so](https://youtu.be/mbmprym9SDM?t=02h10m28s)

[that i don't have to go and look it up](https://youtu.be/mbmprym9SDM?t=02h10m30s)

[every time](https://youtu.be/mbmprym9SDM?t=02h10m32s)

[because clearly i can't remember it](https://youtu.be/mbmprym9SDM?t=02h10m33s)

[which means it's not intuitive](https://youtu.be/mbmprym9SDM?t=02h10m34s)

[what lane what uh programming language](https://youtu.be/mbmprym9SDM?t=02h10m47s)

[is that](https://youtu.be/mbmprym9SDM?t=02h10m50s)

[it's a it's a c based or similar](https://youtu.be/mbmprym9SDM?t=02h10m55s)

[similar language i can tell that much](https://youtu.be/mbmprym9SDM?t=02h10m58s)

[uh okay so pull request this guy should](https://youtu.be/mbmprym9SDM?t=02h11m01s)

[be clear now c plus plus okay](https://youtu.be/mbmprym9SDM?t=02h11m04s)

[uh](https://youtu.be/mbmprym9SDM?t=02h11m08s)

[what this so in order to get that code](https://youtu.be/mbmprym9SDM?t=02h11m10s)

[to work](https://youtu.be/mbmprym9SDM?t=02h11m13s)

[because i assume the intent is to just](https://youtu.be/mbmprym9SDM?t=02h11m15s)

[clear the system terminal](https://youtu.be/mbmprym9SDM?t=02h11m17s)

[i assume that is what is intended](https://youtu.be/mbmprym9SDM?t=02h11m21s)

[um and that is](https://youtu.be/mbmprym9SDM?t=02h11m26s)

[i'm not a i don't do a lot of c plus so](https://youtu.be/mbmprym9SDM?t=02h11m29s)

[i probably have to look some of this up](https://youtu.be/mbmprym9SDM?t=02h11m32s)

[but](https://youtu.be/mbmprym9SDM?t=02h11m34s)

[uh](https://youtu.be/mbmprym9SDM?t=02h11m36s)

[i'm going to go out on a limb and guess](https://youtu.be/mbmprym9SDM?t=02h11m39s)

[that it's this guy here](https://youtu.be/mbmprym9SDM?t=02h11m42s)

[he said write after c out](https://youtu.be/mbmprym9SDM?t=02h11m50s)

[uh to clear it okay](https://youtu.be/mbmprym9SDM?t=02h11m54s)

[um](https://youtu.be/mbmprym9SDM?t=02h11m57s)

[not horribly surprised](https://youtu.be/mbmprym9SDM?t=02h11m58s)

[system cmd](https://youtu.be/mbmprym9SDM?t=02h12m04s)

[string copy into there](https://youtu.be/mbmprym9SDM?t=02h12m08s)

[so yeah so this thing](https://youtu.be/mbmprym9SDM?t=02h12m10s)

[okay](https://youtu.be/mbmprym9SDM?t=02h12m13s)

[just kind of looking at the example](https://youtu.be/mbmprym9SDM?t=02h12m15s)

[um](https://youtu.be/mbmprym9SDM?t=02h12m18s)

[so if i](https://youtu.be/mbmprym9SDM?t=02h12m20s)

[let me just open this up real quick](https://youtu.be/mbmprym9SDM?t=02h12m23s)

[if i go here and i open up a regular](https://youtu.be/mbmprym9SDM?t=02h12m25s)

[command prompt nothing fancy](https://youtu.be/mbmprym9SDM?t=02h12m28s)

[i](https://youtu.be/mbmprym9SDM?t=02h12m30s)

[uh](https://youtu.be/mbmprym9SDM?t=02h12m31s)

[so like their example here where they're](https://youtu.be/mbmprym9SDM?t=02h12m32s)

[firing um the system command off and](https://youtu.be/mbmprym9SDM?t=02h12m34s)

[they're passing it the string dir](https://youtu.be/mbmprym9SDM?t=02h12m36s)

[uh the dir command is just the directory](https://youtu.be/mbmprym9SDM?t=02h12m40s)

[listing](https://youtu.be/mbmprym9SDM?t=02h12m43s)

[and so](https://youtu.be/mbmprym9SDM?t=02h12m44s)

[system cls i assume would do](https://youtu.be/mbmprym9SDM?t=02h12m45s)

[the same as typing cls at the command](https://youtu.be/mbmprym9SDM?t=02h12m48s)

[prompt so it's a little more common to](https://youtu.be/mbmprym9SDM?t=02h12m50s)

[type it lowercase rather than all caps](https://youtu.be/mbmprym9SDM?t=02h12m52s)

[to clear it out](https://youtu.be/mbmprym9SDM?t=02h12m56s)

[i'm](https://youtu.be/mbmprym9SDM?t=02h12m57s)

[i'm guessing](https://youtu.be/mbmprym9SDM?t=02h13m01s)

[let's see uh](https://youtu.be/mbmprym9SDM?t=02h13m08s)

[[Music]](https://youtu.be/mbmprym9SDM?t=02h13m09s)

[the code to work so is it failing to](https://youtu.be/mbmprym9SDM?t=02h13m11s)

[clear your output](https://youtu.be/mbmprym9SDM?t=02h13m15s)

[for what you have there because what i](https://youtu.be/mbmprym9SDM?t=02h13m17s)

[would expect you to do is](https://youtu.be/mbmprym9SDM?t=02h13m19s)

[something where it's like see out](https://youtu.be/mbmprym9SDM?t=02h13m21s)

[and then dump some dump some text out to](https://youtu.be/mbmprym9SDM?t=02h13m24s)

[the screen](https://youtu.be/mbmprym9SDM?t=02h13m26s)

[uh](https://youtu.be/mbmprym9SDM?t=02h13m28s)

[followed up by system cls would then](https://youtu.be/mbmprym9SDM?t=02h13m28s)

[leave your terminal in an empty state](https://youtu.be/mbmprym9SDM?t=02h13m31s)

[so](https://youtu.be/mbmprym9SDM?t=02h13m37s)

[ball parking again i don't i don't have](https://youtu.be/mbmprym9SDM?t=02h13m39s)

[i don't necessarily have the tooling](https://youtu.be/mbmprym9SDM?t=02h13m42s)

[installed and it's been a while since](https://youtu.be/mbmprym9SDM?t=02h13m43s)

[i've done c plus plus but i would](https://youtu.be/mbmprym9SDM?t=02h13m44s)

[imagine it something like this would be](https://youtu.be/mbmprym9SDM?t=02h13m46s)

[would be what you're looking for](https://youtu.be/mbmprym9SDM?t=02h13m51s)

[is](https://youtu.be/mbmprym9SDM?t=02h13m53s)

[we'll start with fixing the quotes](https://youtu.be/mbmprym9SDM?t=02h13m56s)

[because that's ugly](https://youtu.be/mbmprym9SDM?t=02h13m57s)

[um](https://youtu.be/mbmprym9SDM?t=02h13m59s)

[right so](https://youtu.be/mbmprym9SDM?t=02h14m04s)

[we'll call this](https://youtu.be/mbmprym9SDM?t=02h14m06s)

[first](https://youtu.be/mbmprym9SDM?t=02h14m08s)

[do second](https://youtu.be/mbmprym9SDM?t=02h14m10s)

[and then i assume system](https://youtu.be/mbmprym9SDM?t=02h14m12s)

[cls](https://youtu.be/mbmprym9SDM?t=02h14m15s)

[clears it](https://youtu.be/mbmprym9SDM?t=02h14m17s)

[um let me just double check](https://youtu.be/mbmprym9SDM?t=02h14m19s)

[they were copying it the so this small](https://youtu.be/mbmprym9SDM?t=02h14m23s)

[example here i don't i don't have the](https://youtu.be/mbmprym9SDM?t=02h14m26s)

[api up for it here](https://youtu.be/mbmprym9SDM?t=02h14m28s)

[the fact that it takes in](https://youtu.be/mbmprym9SDM?t=02h14m32s)

[yeah the current date is there](https://youtu.be/mbmprym9SDM?t=02h14m35s)

[s standard h is what that means](https://youtu.be/mbmprym9SDM?t=02h14m40s)

[and for what](https://youtu.be/mbmprym9SDM?t=02h14m43s)

[um](https://youtu.be/mbmprym9SDM?t=02h14m45s)

[so i would assume](https://youtu.be/mbmprym9SDM?t=02h14m47s)

[uh oh no you're fine](https://youtu.be/mbmprym9SDM?t=02h14m49s)

[i assume what is probably being](https://youtu.be/mbmprym9SDM?t=02h14m52s)

[and again without i i'm gonna go out on](https://youtu.be/mbmprym9SDM?t=02h14m54s)

[a limb and guess that this is some sort](https://youtu.be/mbmprym9SDM?t=02h14m56s)

[of school assignment or similar](https://youtu.be/mbmprym9SDM?t=02h14m58s)

[um but a](https://youtu.be/mbmprym9SDM?t=02h15m01s)

[a program similar to this i would](https://youtu.be/mbmprym9SDM?t=02h15m03s)

[imagine what you would see when you run](https://youtu.be/mbmprym9SDM?t=02h15m06s)

[it](https://youtu.be/mbmprym9SDM?t=02h15m07s)

[is](https://youtu.be/mbmprym9SDM?t=02h15m08s)

[just the word second](https://youtu.be/mbmprym9SDM?t=02h15m09s)

[because it would write first out](https://youtu.be/mbmprym9SDM?t=02h15m12s)

[initially](https://youtu.be/mbmprym9SDM?t=02h15m14s)

[this would call the cls command](https://youtu.be/mbmprym9SDM?t=02h15m16s)

[which would clear your terminal](https://youtu.be/mbmprym9SDM?t=02h15m18s)

[and then this would get written out as](https://youtu.be/mbmprym9SDM?t=02h15m21s)

[well](https://youtu.be/mbmprym9SDM?t=02h15m23s)

[the other thing that's worth noting cls](https://youtu.be/mbmprym9SDM?t=02h15m24s)

[is a windows based command](https://youtu.be/mbmprym9SDM?t=02h15m26s)

[so if you are inside of a different](https://youtu.be/mbmprym9SDM?t=02h15m28s)

[operating system i don't think cls works](https://youtu.be/mbmprym9SDM?t=02h15m30s)

[the the linux equivalent](https://youtu.be/mbmprym9SDM?t=02h15m35s)

[would just be](https://youtu.be/mbmprym9SDM?t=02h15m38s)

[clear](https://youtu.be/mbmprym9SDM?t=02h15m39s)

[and that does depend a little bit on the](https://youtu.be/mbmprym9SDM?t=02h15m43s)

[terminal so i do enough command line](https://youtu.be/mbmprym9SDM?t=02h15m45s)

[stuff](https://youtu.be/mbmprym9SDM?t=02h15m47s)

[some terminals behave a little weird](https://youtu.be/mbmprym9SDM?t=02h15m48s)

[some of them when you type clear all it](https://youtu.be/mbmprym9SDM?t=02h15m50s)

[does is press the enter key for however](https://youtu.be/mbmprym9SDM?t=02h15m53s)

[height your terminal is and so it pushes](https://youtu.be/mbmprym9SDM?t=02h15m55s)

[the content off the top rather than](https://youtu.be/mbmprym9SDM?t=02h15m57s)

[actually legitimately clearing it so](https://youtu.be/mbmprym9SDM?t=02h15m59s)

[using windows so yeah so you would so i](https://youtu.be/mbmprym9SDM?t=02h16m01s)

[would expect something like this would](https://youtu.be/mbmprym9SDM?t=02h16m04s)

[give you](https://youtu.be/mbmprym9SDM?t=02h16m05s)

[would give you what you're looking for](https://youtu.be/mbmprym9SDM?t=02h16m08s)

[at least from what i see i don't see any](https://youtu.be/mbmprym9SDM?t=02h16m12s)

[reason why that code would work does](https://youtu.be/mbmprym9SDM?t=02h16m13s)

[that kind of answer the question](https://youtu.be/mbmprym9SDM?t=02h16m15s)

[so the intent would be that](https://youtu.be/mbmprym9SDM?t=02h16m18s)

[that you would use this function at any](https://youtu.be/mbmprym9SDM?t=02h16m20s)

[point you wanted to clear what was](https://youtu.be/mbmprym9SDM?t=02h16m22s)

[previously written to](https://youtu.be/mbmprym9SDM?t=02h16m23s)

[um](https://youtu.be/mbmprym9SDM?t=02h16m25s)

[console out which is what c out stands](https://youtu.be/mbmprym9SDM?t=02h16m26s)

[for i believe](https://youtu.be/mbmprym9SDM?t=02h16m29s)

[it's been a little while since i've done](https://youtu.be/mbmprym9SDM?t=02h16m31s)

[c plus so](https://youtu.be/mbmprym9SDM?t=02h16m32s)

[apparently vs code even knows that it's](https://youtu.be/mbmprym9SDM?t=02h16m36s)

[yes i understand cool](https://youtu.be/mbmprym9SDM?t=02h16m39s)

[sweet](https://youtu.be/mbmprym9SDM?t=02h16m41s)

[feel free to drop in anytime i'm](https://youtu.be/mbmprym9SDM?t=02h16m43s)

[streaming with questions i don't i don't](https://youtu.be/mbmprym9SDM?t=02h16m45s)

[mind rabbit trailing and answering](https://youtu.be/mbmprym9SDM?t=02h16m46s)

[questions for people](https://youtu.be/mbmprym9SDM?t=02h16m48s)

[but like i said i think i am running out](https://youtu.be/mbmprym9SDM?t=02h16m50s)

[of steam and tiredness i'm i'm out of](https://youtu.be/mbmprym9SDM?t=02h16m52s)

[mountain dew and it's already post 11 so](https://youtu.be/mbmprym9SDM?t=02h16m54s)

[with that i think i'm going to say happy](https://youtu.be/mbmprym9SDM?t=02h16m58s)

[coding thank you for everyone who](https://youtu.be/mbmprym9SDM?t=02h17m01s)

[came and hang out appreciate the](https://youtu.be/mbmprym9SDM?t=02h17m03s)

[questions always like the interaction i](https://youtu.be/mbmprym9SDM?t=02h17m05s)

[will see everyone next time](https://youtu.be/mbmprym9SDM?t=02h17m07s)

[you](https://youtu.be/mbmprym9SDM?t=02h17m27s)

