// ConsoleApplication1.cpp : This file contains the 'main' function. Program execution begins and ends there.
//
// atomic_flag as a spinning lock
#include <iostream>       // std::cout
#include <atomic>         // std::atomic_flag
#include <thread>         // std::thread
#include <vector>         // std::vector
#include <sstream>        // std::stringstream
#include <cstdlib>

std::atomic_flag lock_stream = ATOMIC_FLAG_INIT;
std::stringstream stream;

void append_number(int x) {
	while (true) {
		while (lock_stream.test_and_set()) {}
		std::cout << "thread #" << x << '\n';
		//stream << "thread #" << x << '\n';
		std::this_thread::sleep_for(std::chrono::milliseconds(1000));
		//std::cout << stream.str();
		lock_stream.clear();
	}
}

int main()
{
	std::vector<std::thread> threads;
	for (int i = 1; i <= 10; ++i) threads.push_back(std::thread(append_number, i));
	for (auto& th : threads) th.join();

	std::cout << stream.str();
	return 0;
}
// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
