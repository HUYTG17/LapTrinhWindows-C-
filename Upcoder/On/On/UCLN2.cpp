#define ll long long
#define TrGiaHuy return 0
#include <iostream>
using namespace std;
int main() {
	ll a, b, c;
	cin >> a >> b;
	while (b > 0) {
		c = a % b;
		a = b;
		b = c;
	}
	cout << a;
	TrGiaHuy;
}