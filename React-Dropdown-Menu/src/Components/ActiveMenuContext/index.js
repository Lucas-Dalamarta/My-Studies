import { useState, createContext } from 'react'

export const ActiveMenuContext = createContext();

export const ActiveMenuProvider = ({ children }) => {
  const [activeMenu, setActiveMenu] = useState("main");

  return (
    <ActiveMenuContext.Provider value={[activeMenu, setActiveMenu]}>
      {children}
    </ActiveMenuContext.Provider>
  );
}