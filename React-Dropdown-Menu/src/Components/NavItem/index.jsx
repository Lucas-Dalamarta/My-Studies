import { useState, useCallback } from "react"

const NavItem = ({ icon, children }) => {
  const [open, setOpen] = useState(false);

  const handleOpen = useCallback(() => {
    setOpen(!open)
  }, [open]);

  return (
    <li className="nav-item">
      <a href="#" className="icon-button" onClick={handleOpen}>
        {icon}
      </a>

      {open && children}
    </li>
  );
};

export default NavItem;
