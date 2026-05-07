//
//  Session 2.swift
//  Spring Project
//
//  Created by Joaquin Robert Vincent-DaGrace on 5/6/26.
//

import SwiftUI

struct Session_2: View {
    var body: some View {
        VStack{
            Text("Hello, My name is Joaquin")
            Image("Headshot1")
                .resizable()
                .frame(width: 200, height: 200)
                .padding()
                .background(Color.white)
                .shadow(color: .gray, radius: 3, x: 0, y: 5)
                
    }
        HStack{
            Text("Hello, My name is Joaquin")
                .padding()
                .background(Color.white)
                .shadow(color: .gray, radius: 3, x: 0, y: 5)
            Image("Headshot1")
                .resizable()
                .frame(width: 200, height: 200)
                .padding()
                .background(Color.white)
                .shadow(color: .gray, radius: 3, x: 0, y: 5)
    }
        ZStack{
            Image("Headshot1")
                .resizable()
                .frame(width: 200, height: 200)
                .padding()
                .background(Color.white)
                .shadow(color: .gray, radius: 3, x: 0, y: 5)
            Text("Hello, My name is Joaquin")
                .foregroundStyle(.blue)
    }
        
    }
}

#Preview {
    Session_2()
}
