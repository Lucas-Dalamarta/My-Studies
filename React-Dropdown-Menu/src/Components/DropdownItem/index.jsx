import { useContext } from 'react'

import { ActiveMenuContext } from "../ActiveMenuContext";

const DropdownItem = ({ goToMenu, leftIcon, rightIcon, children }) => {
  const [activeMenu, setActiveMenu] = useContext(ActiveMenuContext);
  
  return (
    <a
      href="#"
      className="menu-item"
      onClick={() => goToMenu && setActiveMenu(goToMenu)}
    >
      <span className="icon-button">{leftIcon}</span>
      {children}
      <span className="icon-right">{rightIcon}</span>
    </a>
  );
}

export default DropdownItem;