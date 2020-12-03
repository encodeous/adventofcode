/*
 * MIT License
 *
 * Copyright (c) 2020 Adam Chen
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 */
#include <bits/stdc++.h>
#include <ext/pb_ds/assoc_container.hpp>
#include <unistd.h>
#pragma message("Compiling at: " __TIMESTAMP__ ". Executing File: " __FILE__ ". If this date is not the same as the submission date, it could be an indication that the submission was rejudged.")
#ifdef NDEBUG
#pragma GCC optimize("O3,unroll-loops")
#endif
#pragma GCC target("avx,avx2,fma")
using namespace std;
using namespace __gnu_pbds;
#define pb push_back
#define ll long long
#define lp pair<ll,ll>
#define ld long double
#ifdef __MINGW32__
#pragma clang diagnostic push
#pragma ide diagnostic ignored "hicpp-signed-bitwise"
#pragma ide diagnostic ignored "cert-err58-cpp"
#pragma ide diagnostic ignored "cppcoreguidelines-narrowing-conversions"
#pragma ide diagnostic ignored "cppcoreguidelines-pro-type-member-init"
#endif
static struct IO {
#define _i inline void
#define __t template<typename T>
#define __c unsigned char
#define __1(x,y,z) inline IO &operator x (y &s){z; return*this;}
#define __2 val=0;int c=gc();while(c<=' ')c=gc();bool n=(c=='-');if(n)c=gc();do{val=val*10+c-'0';}while((c=gc())>='0'&&c<='9');
#define p_str(x) for (char i: x)pc(i);
#define likely(x) __builtin_expect(x,true)
#define unlikely(x) __builtin_expect(x,false)
    const unsigned int bfz=1<<15;const static bool line_buf; __c *_rb=new __c[bfz]; __c *_wb=new __c[bfz];unsigned int rl=0,ri=0,wi=0;bool eof=false;
#ifdef _getchar_nolock
#define ugc _getchar_nolock
#endif
#ifdef getchar_unlocked
#define ugc getchar_unlocked
#endif
#ifndef ugc
#define ugc getchar
#endif
    inline __c gc(){if(line_buf){return ugc();}else{if(unlikely(ri>=rl)){if(unlikely(eof))return EOF;fill_buffer();}
            return _rb[ri++];}} _i pc(char x){if(unlikely(wi>=bfz))flush_buffer();_wb[wi++]=x;} _i fill_buffer(){auto x=fread(_rb,sizeof(char),bfz,stdin);
        if(unlikely(x!=0&&x<bfz)){eof=true;}rl=x;ri= 0;} _i flush_buffer(){fwrite(_wb,sizeof(char),wi,stdout);fflush(stdout);wi=0;}~IO(){flush_buffer();}
    __t _i _ni(T &val){__2 if(n)val=-val;} __t _i _nd(T &val){__2 T div=1;if(c=='.'){while((c=gc())>='0'&&c<='9')val+=(c-'0')/(div*=10);}if(n)val=-val;}
    _i _nt(string &s,char token=' '){ostringstream oss;int c=gc();while(c==token||c<' ')c=gc();do{oss<<static_cast<char>(c);}while((c=gc())!=token&&c>=' ');
        s=oss.str();} _i _nln(string &s){_nt(s,'\n');}static inline int fast_log10(const unsigned ll& val){return val<=9?0:val<=99?1:val<=999?2:val<=
                                                                                                                                                9999?3:val<=99999?4:val<=999999?5:val<=9999999?6:val<=99999999?7:val<=999999999?8:val<=9999999999?9:val<=99999999999?10:val<=999999999999?11:val<=
                                                                                                                                                                                                                                                                                             9999999999999?12:val<=99999999999999?13:val<=999999999999999?14:val<=9999999999999999?15:val<=99999999999999999?16:val<=999999999999999999?17:val<=
                                                                                                                                                                                                                                                                                                                                                                                                                                           9999999999999999999ull?18:val<=ULLONG_MAX?19:-1;}char buf[20]; __t _i write_int(T data){if(data==0)pc('0');else{int len;if(data<0){pc('-');data
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              =-data;}len=fast_log10(data)+1;for(int i=len-1;i>=0;i--){buf[i]=data%10+'0';data/=10;}for(int i=0;i<len;i++){pc(buf[i]);}}} __1(>,char,s=gc())
    __1(>=,char,s=' ';while(s<=' ')s=gc()) __1(>,string,_nt(s)) __1(>,ld,_nd(s)) __1(>,ll,_ni(s)) __1(>,int,_ni(s)) __1(>=,string,_nln(s))
    __1(<,const int,write_int(s)) __1(<,const ll,write_int(s)) __1(<,const ld,p_str(to_string(s));) __1(<,const string,p_str(s);)
    __1(<,const char,pc(s);)IO(){if(line_buf){std::istream::sync_with_stdio(false);cin.tie(nullptr);}
        else{setvbuf(stdin,nullptr,_IONBF,0);}setvbuf(stdout, nullptr, _IONBF, 0);}}io;
// ORZ Template 2.3 | DO NOT RANDOMLY EDIT THIS TEMPLATE OR CHANGE FORMATTING! clion will crash!
// IO Operations: > read < write >= read line (string) >= next token (char)
_i setbit(ll &mask, int idx, bool bit){if(bit){mask = mask | (1 << idx);}else{mask = mask & ~(1 << idx);}}
inline bool getbit(ll mask, int idx) {return (mask >> idx) & 1;}
#ifdef __MINGW32__ // Assuming your local programming environment is MINGW
#pragma clang diagnostic pop
// Switches between line buffered io, and EOF buffered io. Non-lined buffered io requires EOF (Ctrl+D) on termination.
const bool IO::line_buf = true;
#else
const bool IO::line_buf = false;
#endif
#define el < '\n'
inline ll gcd(ll a, ll b) { return b == 0 ? a : gcd(b, a % b);}
inline ll lcm(ll a, ll b) { return a * b / gcd(a, b);}
#define tts(x) #x
#define l2(x) __lg(x)
template <typename T, class cmp = less<T>> using ordered_set = tree<T, null_type, less<T>, rb_tree_tag, tree_order_statistics_node_update>;
template <typename T, typename X> using hash_map = gp_hash_table<T, X>;
char grid[323][31];
ll find_count(int dx, int dy){
    int x = -dx, y = -dy;
    int cnt = 0;
    while(y < 323){
        x += dx;
        y += dy;
        x %= 31;
        if(grid[y][x] == '#')cnt++;
    }
    return cnt;
}
int main()
{
    freopen("../2020/inputs/day3.txt","r",stdin);
    for(int i = 0; i < 323; i++){
        string s;
        io > s;
        for(int j = 0; j < 31; j++){
            grid[i][j] = s[j];
        }
    }
    io < (find_count(1,1) * find_count(3, 1) * find_count(5, 1) * find_count(7, 1) * find_count(1, 2));
    return 0;
}