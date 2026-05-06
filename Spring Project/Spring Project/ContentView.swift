//
//  ContentView.swift
//  Spring Project
//
//  Created by Joaquin Robert Vincent-DaGrace on 5/6/26.
//

import SwiftUI

struct ContentView: View {
    var body: some View {
        VStack {
            Image(systemName: "pencil.line")
                .imageScale(.large)
                .foregroundStyle(.tint)
            Image("Headshot1")
            Text("Hello Everyone!!! My name is Joaquin Vincent DaGrace and i cam a 9th grader from De Anza High. I like to code and make apps.")
        }
        .padding()
    }
}

#Preview {
    ContentView()
}
