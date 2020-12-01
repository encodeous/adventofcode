#include <bits/stdc++.h>
#ifdef NDEBUG
#pragma GCC optimize("Ofast")
#pragma GCC optimize("unroll-loops")
#endif
#pragma GCC target("avx,avx2,fma")
using namespace std;
#define ll long long
#define lp pair<ll,ll>
#define ld long double
int arr[200];
/*
 * Brute force the solution in O(n^2)
 */
int main()
{
    for(int i =0 ; i < 200; i++){
        cin >> arr[i];
    }
    for(int i = 0; i < 200; i++){
        for(int j = i + 1; j < 200; j++){
            if(arr[i] + arr[j] == 2020){
                cout << arr[i] * arr[j];
            }
        }
    }
    return 0;
}